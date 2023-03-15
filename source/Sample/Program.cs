using MasterDevs.ChromeDevTools.Protocol.Chrome.Page;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using MasterDevs.ChromeDevTools.Protocol.Chrome.DOM;
using Task = System.Threading.Tasks.Task;
using MasterDevs.ChromeDevTools.Local;
using MasterDevs.ChromeDevTools.Protocol;

namespace MasterDevs.ChromeDevTools.Sample
{
    internal class Program
    {
        const int ViewPortWidth = 1440;
        const int ViewPortHeight = 900;
        private static async Task Main(string[] args)
        {
            // synchronization
            var screenshotDone = new ManualResetEventSlim();

            // STEP 1 - Run Chrome
            var methodTypeMap = new MethodTypeMap();
            var commandsExecutor = new CommonCommandsExecutor();
            var chromeSessionFactory = new ChromeSessionFactory(methodTypeMap, commandsExecutor);
            var chromeProcessFactory = new LocalChromeProcessFactory(chromeSessionFactory, @"F:\Utils\ungoogled-chromium-103.0.5060.68-1_Win64\chrome.exe");
            var chromeProcessParameters = new ChromeProcessParametersBuilder(9222)
                .Build();
            using (var chromeProcess = chromeProcessFactory.Create(chromeProcessParameters))
            {
                await chromeProcess.Start();

                // STEP 2 - Create a debugging session
                var sessionInfo = (await chromeProcess.GetSessionsRaw()).LastOrDefault();
                var chromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl, sessionInfo.Id);

                // STEP 3 - Send a command
                //
                // Here we are sending a commands to tell chrome to set the viewport size 
                // and navigate to the specified URL
                await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand
                {
                    Width = ViewPortWidth,
                    Height = ViewPortHeight,
                    Scale = 1
                });

                var navigateResponse = await chromeSession.SendAsync(new NavigateCommand
                {
                    Url = "http://www.google.com"
                });
                Console.WriteLine("NavigateResponse: " + navigateResponse.Id);

                // STEP 4 - Register for events (in this case, "Page" domain events)
                // send an command to tell chrome to send us all Page events
                // but we only subscribe to certain events in this session
                var pageEnableResult = await chromeSession.SendAsync<Protocol.Chrome.Page.EnableCommand>();
                Console.WriteLine("PageEnable: " + pageEnableResult.Id);

                chromeSession.Subscribe<LoadEventFiredEvent>(loadEventFired =>
                {
                    // we cannot block in event handler, hence the task
                    Task.Run(async () =>
                    {
                        Console.WriteLine("LoadEventFiredEvent: " + loadEventFired.Timestamp);

                        var documentNodeId = (await chromeSession.SendAsync(new GetDocumentCommand())).Result.Root.NodeId;
                        var bodyNodeId =
                            (await chromeSession.SendAsync(new QuerySelectorCommand
                            {
                                NodeId = documentNodeId,
                                Selector = "body"
                            })).Result.NodeId;
                        var height = (await chromeSession.SendAsync(new GetBoxModelCommand { NodeId = bodyNodeId })).Result.Model.Height;

                        await chromeSession.SendAsync(new SetDeviceMetricsOverrideCommand
                        {
                            Width = ViewPortWidth,
                            Height = height,
                            Scale = 1
                        });

                        Console.WriteLine("Taking screenshot");
                        var screenshot = await chromeSession.SendAsync(new CaptureScreenshotCommand { Format = "png" });

                        var data = Convert.FromBase64String(screenshot.Result.Data);
                        File.WriteAllBytes("output.png", data);
                        Console.WriteLine("Screenshot stored");

                        // tell the main thread we are done
                        screenshotDone.Set();
                    });
                });

                // wait for screenshoting thread to (start and) finish
                screenshotDone.Wait();

                Console.WriteLine("Exiting ..");
            }
        }
    }
}