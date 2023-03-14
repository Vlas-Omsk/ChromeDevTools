using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Local.Windows
{
    public class Input
    {
        private readonly int _inputDelay;

        public Input(int inputDelay)
        {
            _inputDelay = inputDelay;
        }

        public Task SendPasteCommand()
        {
            return SendKeys(0xA2, 0x56);
        }

        public async Task SendKeys(params short[] virtualKeyCodes)
        {
            SendInput(virtualKeyCodes.Select(x => new Win32.INPUT()
            {
                type = Win32.InputType.INPUT_KEYBOARD,
                U = new Win32.InputUnion()
                {
                    ki = new Win32.KEYBDINPUT()
                    {
                        wVk = x,
                        dwFlags = Win32.KEYEVENTF.KEYDOWN,
                    }
                }
            }).ToArray());

            await Task.Delay(_inputDelay);

            SendInput(virtualKeyCodes.Reverse().Select(x => new Win32.INPUT()
            {
                type = Win32.InputType.INPUT_KEYBOARD,
                U = new Win32.InputUnion()
                {
                    ki = new Win32.KEYBDINPUT()
                    {
                        wVk = x,
                        dwFlags = Win32.KEYEVENTF.KEYUP,
                    }
                }
            }).ToArray());
        }

        public async Task MouseLeftClick(int x, int y)
        {
            var screenWidth = Win32.GetSystemMetrics(0);
            var screenHeight = Win32.GetSystemMetrics(1);

            SendInput(new Win32.INPUT[]
            {
                new Win32.INPUT()
                {
                    type = Win32.InputType.INPUT_MOUSE,
                    U = new Win32.InputUnion()
                    {
                        mi = new Win32.MOUSEINPUT()
                        {
                            dx = x * 65535 / screenWidth,
                            dy = y * 65535 / screenHeight,
                            dwFlags = Win32.MOUSEEVENTF.ABSOLUTE | Win32.MOUSEEVENTF.MOVE
                        }
                    }
                },
                new Win32.INPUT()
                {
                    type = Win32.InputType.INPUT_MOUSE,
                    U = new Win32.InputUnion()
                    {
                        mi = new Win32.MOUSEINPUT()
                        {
                            dwFlags = Win32.MOUSEEVENTF.LEFTDOWN
                        }
                    }
                },
            });

            await Task.Delay(_inputDelay);

            SendInput(new Win32.INPUT[]
            {
                new Win32.INPUT()
                {
                    type = Win32.InputType.INPUT_MOUSE,
                    U = new Win32.InputUnion()
                    {
                        mi = new Win32.MOUSEINPUT()
                        {
                            dwFlags = Win32.MOUSEEVENTF.LEFTUP
                        }
                    }
                }
            });
        }

        private static void SendInput(Win32.INPUT[] inputs)
        {
            if (Win32.SendInput((uint)inputs.Length, inputs, Win32.INPUT.Size) != inputs.Length)
                throw new Win32Exception();
        }
    }
}