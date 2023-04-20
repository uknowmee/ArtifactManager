using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class EditMyPassword : Form, IStandardView
    {
        private readonly Form _lastWindow;
        private readonly bool _isGuest;
        public LoggedIn LoggedIn;

        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditMyPassword(Form last, bool isGuest)
        {
            _isGuest = isGuest;

            if (isGuest)
            {
                Path = ((GuestPanel) last).Path;
                _lastWindow = last;
                LoggedIn = ((GuestPanel) last).LoggedIn;
            } else
            {
                Path = ((UserPanel) last).Path;
                _lastWindow = last;
                LoggedIn = ((UserPanel) last).LoggedIn;
            }

            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        public void LoadData()
        {
            LoggedIn.Update(LoggedIn.User.Nick);
        }

        public void Components()
        {
            var ret = StandardView.FormInit(this, panel1);
            Loaded = ret.Item1;
            OriginalFormSize = ret.originalFormSize;
            MyControls = ret.myControls;

            StandardView.SmallWindow(this);
            CenterToParent();
        }

        public void ShowWindow()
        {
            StandardView.SmallWindow(this);
            CenterToParent();

            LoadData();
            Show();
        }

        private void EditMyPassword_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }


        private void EditMyPassword_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (_isGuest)
            {
                ((GuestPanel) _lastWindow).ShowWindow();
                Close();
            } else
            {
                ((UserPanel) _lastWindow).ShowWindow();
                Close();
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (LoggedIn.IsNewPasswordValid(textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text))
            {
                MessageBox.Show(@"You can change your password!", @"New Password Accepted!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (LoggedIn.PasswordChange(textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text))
            {
                MessageBox.Show(@"Password changed!", @"New Password Accepted!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                buttonQuit.PerformClick();
            }
        }
    }
}