using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Journey
{
    public class WindowsAnimation
    {
        [DllImport("User32")]
        static extern bool AnimateWindow(IntPtr hand, int time, AnimateWindowsFlags flags);

        enum AnimateWindowsFlags : uint
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public void animacionCerrar(IntPtr handle,int time)
        {
            AnimateWindow(handle, 350, AnimateWindowsFlags.AW_BLEND | AnimateWindowsFlags.AW_HIDE);
        }

        public void animacionAbrir(IntPtr handle,int time)
        {
            AnimateWindow(handle, time, AnimateWindowsFlags.AW_BLEND);
        }

        public void animacionMinimizar(IntPtr handle)
        {
            AnimateWindow(handle, 500, AnimateWindowsFlags.AW_SLIDE
               | AnimateWindowsFlags.AW_HOR_NEGATIVE | AnimateWindowsFlags.AW_VER_POSITIVE | AnimateWindowsFlags.AW_HIDE);
        }

        public void animacionDeslizarPanelAbrir(IntPtr handle)
        {
            AnimateWindow(handle, 350, AnimateWindowsFlags.AW_SLIDE | AnimateWindowsFlags.AW_HOR_POSITIVE);
        }

        public void animacionDeslizarPanelCerrar(IntPtr handle)
        {
            AnimateWindow(handle, 350, AnimateWindowsFlags.AW_SLIDE | AnimateWindowsFlags.AW_HOR_NEGATIVE |
                  AnimateWindowsFlags.AW_HIDE);
        }

        public void animacionDeslizarPanelUsuarioAbrir(IntPtr handle)
        {
            AnimateWindow(handle, 350, AnimateWindowsFlags.AW_SLIDE | AnimateWindowsFlags.AW_HOR_NEGATIVE);
        }

        public void animacionDeslizarPanelUsuarioCerrar(IntPtr handle)
        {
            AnimateWindow(handle, 350, AnimateWindowsFlags.AW_SLIDE | AnimateWindowsFlags.AW_HOR_POSITIVE
                | AnimateWindowsFlags.AW_HIDE);
        }
    }
}
