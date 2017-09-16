using System;
using System.Windows.Forms;
using System.Drawing;

namespace MouseMover
{
    class Program
    {
        private static int IDLE_WAIT = 1000 * 60 * 1; // 1 minutes

        static void Main(string[] args)
        {
            while (true)
            {
                // SetCursorPos を使うのは誤り。これでは ScreenSaver が認識してくれない。
                // jdk7 では mouse_event(MOUSEEVENTF_MOVE, x, y, 0, 0) を使っていた。
                //   https://msdn.microsoft.com/ja-jp/library/cc410921.aspx
                //   但し、ここによると mouse_move ではなく SendInput を使え、とのこと。
                Win32.mouse_event(Win32.MOUSEEVENTF_MOVE, 10, 0, 0, 0);
                System.Threading.Thread.Sleep(10);
                Win32.mouse_event(Win32.MOUSEEVENTF_MOVE, -10, 0, 0, 0);
                System.Threading.Thread.Sleep(IDLE_WAIT);
            }
        }
    }
}
