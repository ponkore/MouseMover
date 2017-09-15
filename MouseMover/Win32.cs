using System;
using System.Runtime.InteropServices;

namespace MouseMover
{
    public class Win32
    {
        // https://stackoverflow.com/questions/8050825/how-to-move-mouse-cursor-using-c
        // こっちは使わないことにしたが定義を残しておく
        [DllImport("User32.Dll", CallingConvention = CallingConvention.StdCall)]
        public static extern long SetCursorPos(int x, int y);

        // こっちを使う。
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int MOUSEEVENTF_MOVE       = 0x0001;
        public const int MOUSEEVENTF_LEFTDOWN   = 0x0002;
        public const int MOUSEEVENTF_LEFTUP     = 0x0004;
        public const int MOUSEEVENTF_RIGHTDOWN  = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP    = 0x0010;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const int MOUSEEVENTF_MIDDLEUP   = 0x0040;

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
    }
}