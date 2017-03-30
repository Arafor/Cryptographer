using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographer
{
    class FormWindowManager
    {
        // Get screen resolution
        static Rectangle resolution = Screen.PrimaryScreen.Bounds;
        int resolutionHeight = resolution.Height;
        int resolutionWidth = resolution.Width;
        // For testing on other resolutions
        //int resolutionHeight = 768;
        //int resolutionWidth = 1366;

        public void setFormWindowLocation(Form previousForm, Form targetForm)
        {
            if (previousForm == null)
            {
                targetForm.Location = new Point(0, 0);
                return;
            }

            if (previousForm.Location.X + previousForm.Size.Width + targetForm.Size.Width < resolutionWidth)
            {
                targetForm.Location = new Point(previousForm.Location.X + previousForm.Size.Width, previousForm.Location.Y);
            } else
            {
                targetForm.Location = new Point(resolutionWidth - targetForm.Size.Width, previousForm.Location.Y);
            }

            return;
        }

        public void setFormWindowSize(Form targetForm)
        {
            if (targetForm.Size.Height > resolutionHeight)
            {
                targetForm.Size = new Size(targetForm.Size.Width, resolutionHeight);
            }
        }
    }
}
