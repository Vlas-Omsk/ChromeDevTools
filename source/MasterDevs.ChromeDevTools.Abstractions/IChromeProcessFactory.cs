﻿namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(ChromeProcessParameters parameters);
    }
}