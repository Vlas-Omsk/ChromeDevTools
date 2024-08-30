using System;

namespace MasterDevs.ChromeDevTools
{
    public interface IProtocolTypeMap
    {
        Type GetCommand(string method);

        Type GetCommandResponse(string method);

        Type GetEvent(string method);
    }
}