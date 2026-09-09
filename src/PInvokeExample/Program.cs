using System.Runtime.InteropServices;

namespace PInvokeExample
{
    public static class NativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    }

    class Program
    {
        static void Main()
        {
            NativeMethods.MessageBox(IntPtr.Zero, "Hallo aus P/Invoke!", "Test", 0);
        }
    }
}

