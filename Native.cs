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
            public static extern bool UpdateLayeredWindow(IntPtr hWnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref GDI32.BLENDFUNCTION pblend, int dwFlags);
        }
    }
}
