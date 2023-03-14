using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MasterDevs.ChromeDevTools.Local.Windows
{
    public sealed class Clipboard
    {
        public static unsafe void SetText(string text)
        {
            var length = (uint)text.Length * 2 + 1;
            var textPtr = Marshal.StringToHGlobalUni(text);
            var textCopyPtr = Win32.GlobalAlloc(0x0002, length);

            Buffer.MemoryCopy(textPtr.ToPointer(), Win32.GlobalLock(textCopyPtr).ToPointer(), length, length);
            Win32.GlobalUnlock(textCopyPtr);
            Marshal.FreeHGlobal(textPtr);

            if (!Win32.OpenClipboard(IntPtr.Zero))
                throw new Win32Exception();
            if (!Win32.SetClipboardData(13, textCopyPtr))
                throw new Win32Exception();
            if (!Win32.CloseClipboard())
                throw new Win32Exception();
        }
    }
}