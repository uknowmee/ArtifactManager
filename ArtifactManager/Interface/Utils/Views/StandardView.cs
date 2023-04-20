using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class StandardView
    {
        public static void SmallWindow(Form form)
        {
            form.WindowState = FormWindowState.Normal;
        }
        
        public static (bool, Rectangle originalFormSize, MyControls myControls) FormInit(Form form, Panel panel)
        {
            ControlsColorsAndSpecs(form, panel);

            Rectangle originalFormSize =
                new Rectangle(form.Location.X, form.Location.Y, form.Size.Width, form.Size.Height);
            MyControls myControls = new MyControls(panel.Controls);

            return (true, originalFormSize, myControls);
        }

        public static void Pending(Label labelPending)
        {
            switch (labelPending.Text)
            {
                case "":
                case "Pending":
                    labelPending.Text = @"Pending.";
                    break;
                case @"Pending.":
                    labelPending.Text = @"Pending..";
                    break;
                case @"Pending..":
                    labelPending.Text = @"Pending...";
                    break;
                case @"Pending...":
                    labelPending.Text = @"Pending....";
                    break;
                case @"Pending....":
                    labelPending.Text = @"Pending";
                    break;
            }
        }

        public static bool ResizeDecision(Form form, MyControls myControls, Panel panel, int width,
            int height, Rectangle origFSize, bool minimizeMaximizeChange, Button buttonQuit, bool loaded)
        {
            QuitButtonLocation(buttonQuit);

            if (!loaded)
            {
                return Resize(form, myControls, panel, width, height, origFSize, minimizeMaximizeChange);
            }

            ResizeEnd(myControls, panel, width, height, origFSize);
            return minimizeMaximizeChange;
        }

        private static void ControlsColorsAndSpecs(Form form, Panel panel)
        {
            foreach (Control control in form.Controls)
            {
                ColorsAndSpecs(control);
            }

            foreach (Control control in panel.Controls)
            {
                ColorsAndSpecs(control);
            }
        }

        private static void ColorsAndSpecs(Control control)
        {
            if (control.GetType() == typeof(Button) || control.GetType() == typeof(Label) ||
                control.GetType() == typeof(ListBox) || control.GetType() == typeof(CheckBox) ||
                control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox) ||
                control.GetType() == typeof(TreeView))
            {
                control.BackColor = SystemColors.GradientInactiveCaption;
            }
            
            if (control.GetType() == typeof(ComboBox))
            {
                ((ComboBox) control).DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private static void QuitButtonLocation(Button button)
        {
            button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        }

        private static bool Resize(Form form, MyControls myControls, Panel panel, int width,
            int height, Rectangle origFSize, bool minChange)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                panel.Visible = false;

                ResizeControls(myControls, panel.Controls, width, height, origFSize);

                panel.Visible = true;

                return true;
            }

            if (!minChange) return false;

            panel.Visible = false;

            ResizeControls(myControls, panel.Controls, width, height, origFSize);

            panel.Visible = true;

            return false;
        }

        private static void ResizeEnd(MyControls myControls, Panel panel, int width, int height,
            Rectangle rectangle)
        {
            panel.Visible = false;

            ResizeControls(myControls, panel.Controls, width, height, rectangle);

            panel.Visible = true;
        }

        private static void ResizeControls(MyControls myControls, Control.ControlCollection controls, int width,
            int height, Rectangle rectangle)
        {
            if (myControls == null)
            {
                return;
            }

            float xRatio = width / (float) (rectangle.Width);
            float yRatio = height / (float) (rectangle.Height);

            foreach (Control c in controls)
            {
                if (c.Name == "buttonQuit")
                {
                    continue;
                }

                Rectangle r = myControls.GetControlRectangle(c);

                int newX = (int) (r.Location.X * xRatio);
                int newY = (int) (r.Location.Y * yRatio);

                int newWidth = (int) (r.Width * xRatio);
                int newHeight = (int) (r.Height * yRatio);

                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
        }
    }

    internal interface IStandardView
    {
        String Path { get; set; }
        Rectangle OriginalFormSize { get; set; }
        MyControls MyControls { get; set; }
        bool MinimizeMaximizeChange { get; set; }
        bool Loaded { get; set; }
        void LoadData();
        void Components();
        void ShowWindow();
    }
}