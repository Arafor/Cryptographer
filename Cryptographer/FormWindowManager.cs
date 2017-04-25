using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographer
{
    class FormWindowManager
    {
        // Get working area of primary screen (no task bar)
        static Rectangle resolution = Screen.PrimaryScreen.Bounds;
        Rectangle taskbar = new Rectangle();
        //Size(Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height);
        int resolutionWidth = resolution.Width;
        int resolutionHeight = resolution.Height;
        // For testing on other resolutions
        //int resolutionWidth = 320;
        //int resolutionHeight = 200;

        public FormWindowManager()
        {
            taskbar = GetTaskbarPosition();
            if (resolution.Width != taskbar.Width)
            {
                resolutionWidth = resolution.Width - taskbar.Width;
            }

            if (resolution.Height != taskbar.Height)
            {
                resolutionHeight = resolution.Height - taskbar.Height;
            }
        }

        public static Rectangle GetTaskbarPosition()
        {
            var data = new APPBARDATA();
            data.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(data);
            IntPtr retval = SHAppBarMessage(ABM_GETTASKBARPOS, ref data);
            if (retval == IntPtr.Zero) throw new Win32Exception("Please re-install Windows");
            return new Rectangle(data.rc.left, data.rc.top,
                data.rc.right - data.rc.left, data.rc.bottom - data.rc.top);

        }

        // P/Invoke goo:
        private const int ABM_GETTASKBARPOS = 5;
        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        private static extern IntPtr SHAppBarMessage(int msg, ref APPBARDATA data);
        private struct APPBARDATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }
        private struct RECT
        {
            public int left, top, right, bottom;
        }

        public Rectangle getTaskbar()
        {
            Rectangle taskbar = new Rectangle();
            taskbar.Size = new Size(Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height);
            taskbar.Location = new Point(Screen.PrimaryScreen.WorkingArea.Location.X, Screen.PrimaryScreen.WorkingArea.Location.Y);

            return taskbar;
        }

        public void setFormWindowLocation(Form previousForm, Form targetForm)
        {
            if (previousForm == null)
            {
                targetForm.Location = new Point(0, 0);
                return;
            }

            if (targetForm.Size.Width > resolutionWidth)
            {
                // Window is bigger than the screen
                targetForm.Location = new Point(0, 0);
            }
            else if (previousForm.Location.X + previousForm.Size.Width + targetForm.Size.Width < resolutionWidth)
            {
                // Window fits next to previous window
                targetForm.Location = new Point(previousForm.Location.X + previousForm.Size.Width, previousForm.Location.Y);
            }
            else
            {
                // Window fits on screen but not next to previous window
                targetForm.Location = new Point(resolutionWidth - targetForm.Size.Width, previousForm.Location.Y);
            }

            return;
        }

        public void setFormWindowSize(Form targetForm)
        {
            if (targetForm.Size.Height > resolutionHeight)
            {
                if (targetForm.Size.Width > resolutionWidth)
                {
                    // Width does not fit, height does not fit
                    targetForm.Size = new Size(resolutionWidth, resolutionHeight);
                } else
                {
                    // Width does fit, height does not fit
                    targetForm.Size = new Size(targetForm.Size.Width, resolutionHeight);
                }
                
            } else
            {
                if (targetForm.Size.Width > resolutionWidth)
                {
                    // Width does not fit, height does fit
                    targetForm.Size = new Size(resolutionWidth, targetForm.Size.Height);
                }
                else
                {
                    // Width does fit, height does fit
                    targetForm.Size = new Size(targetForm.Size.Width, targetForm.Size.Height);
                }
            }
        }
    }
}
