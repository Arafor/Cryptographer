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
        int resolutionWidth = resolution.Width;
        int resolutionHeight = resolution.Height;
        // For testing on other resolutions
        //int resolutionWidth = 320;
        //int resolutionHeight = 200;

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
