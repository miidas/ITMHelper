using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ITMHelper
{
    internal static class Native
    {
        internal static class GDI32
        {
            // BLENDFUNCTION structure (wingdi.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-blendfunction
            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public struct BLENDFUNCTION
            {
                public byte BlendOp;
                public byte BlendFlags;
                public byte SourceConstantAlpha;
                public byte AlphaFormat;
            }

            // SelectObject function (wingdi.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-selectobject
            [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr SelectObject(IntPtr hdc, IntPtr h);

            // DeleteObject function (wingdi.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-deleteobject
            [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
            public static extern bool DeleteObject(IntPtr ho);
        }

        internal static class User32
        {
            // Extended Window Styles
            // https://docs.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles
            public const int WS_EX_LAYERED = 0x00080000;
            public const int WS_EX_NOACTIVATE = 0x08000000;
            public const int WS_EX_TOOLWINDOW = 0x00000080;
            public const int WS_EX_TOPMOST = 0x00000008;
            public const int WS_EX_TRANSPARENT = 0x00000020;

            // UpdateLayeredWindow function (winuser.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-updatelayeredwindow
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool UpdateLayeredWindow(IntPtr hWnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref GDI32.BLENDFUNCTION pblend, uint dwFlags);

            // dwFlags for AnimateWindow
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-animatewindow#parameters
            public const int AW_ACTIVATE = 0x00020000;
            public const int AW_BLEND = 0x00000020;
            public const int AW_CENTER = 0x00000010;
            public const int AW_HIDE = 0x00010000;
            public const int AW_HOR_POSITIVE = 0x00000001;
            public const int AW_HOR_NEGATIVE = 0x00000002;
            public const int AW_SLIDE = 0x00040000;
            public const int AW_VER_POSITIVE = 0x00000004;
            public const int AW_VER_NEGATIVE = 0x00000008;

            // AnimateWindow function (winuser.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-animatewindow
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(IntPtr hWnd, uint dwTime, uint dwFlags);

            // nCmdShow for ShowWindow
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-showwindow#parameters
            public const int SW_HIDE = 0;
            public const int SW_SHOWNORMAL = 1;
            public const int SW_NORMAL = 1;
            public const int SW_SHOWMINIMIZED = 2;
            public const int SW_SHOWMAXIMIZED = 3;
            public const int SW_MAXIMIZE = 3;
            public const int SW_SHOWNOACTIVATE = 4;
            public const int SW_SHOW = 5;
            public const int SW_MINIMIZE = 6;
            public const int SW_SHOWMINNOACTIVE = 7;
            public const int SW_SHOWNA = 8;
            public const int SW_RESTORE = 9;
            public const int SW_SHOWDEFAULT = 10;
            public const int SW_FORCEMINIMIZE = 11;

            // ShowWindow function (winuser.h)
            // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-showwindow
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            internal static extern int ShowWindow(IntPtr hWnd, int nCmdShow);
        }
    }
}
