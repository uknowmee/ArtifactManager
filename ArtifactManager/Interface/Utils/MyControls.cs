using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArtifactManager.Interface.Utils
{
    public class MyControls
    {
        private readonly List<MyControl> _myControls;

        public MyControls(Form form)
        {
            _myControls = new List<MyControl>();

            foreach (Control formControl in form.Controls)
            {
                _myControls.Add(new MyControl(formControl));
            }
        }
        
        public MyControls(Control.ControlCollection controls)
        {
            _myControls = new List<MyControl>();

            foreach (Control control in controls)
            {
                _myControls.Add(new MyControl(control));
            }
        }

        private class MyControl
        {
            public readonly String Name;
            public readonly Rectangle Shape;

            public MyControl(Control control)
            {
                Name = control.Name;
                Shape = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            }
        }

        public Rectangle GetControlRectangle(Control control)
        {
            return _myControls.Single(c => c.Name == control.Name).Shape;
        }

    }
}