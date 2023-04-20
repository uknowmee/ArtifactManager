using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class AdminPanel : Form, IStandardView
    {
        private Login _lastWindow;
        private readonly LoggedAdmin _loggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public AdminPanel(Form last, LoggedIn loggedIn)
        {
            _loggedIn = (LoggedAdmin)loggedIn;
            _lastWindow = (Login) last;

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        public void LoadData()
        {
            
        }

        public void Components()
        {
            var ret = StandardView.FormInit(this, panel1);
            Loaded = ret.Item1;
            OriginalFormSize = ret.originalFormSize;
            MyControls = ret.myControls;
            WindowState = FormWindowState.Maximized;
        }

        public void ShowWindow()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }

            LoadData();
            Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void AdminPanel_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            _lastWindow = new Login(_lastWindow.LastWindow);
            _lastWindow.ShowWindow();
            Close();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            new NewUser(this, _loggedIn).ShowDialog();
        }

        private void buttonNewRole_Click(object sender, EventArgs e)
        {
            new NewRole(this, _loggedIn).ShowDialog();
        }

        private void buttonNewPermission_Click(object sender, EventArgs e)
        {
            new NewPermission(this, _loggedIn).ShowDialog();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            new EditUser(this, _loggedIn).ShowDialog();
        }

        private void buttonEditRole_Click(object sender, EventArgs e)
        {
            new EditRole(this, _loggedIn).ShowDialog();
        }

        private void buttonEditPermission_Click(object sender, EventArgs e)
        {
            new EditPermission(this, _loggedIn).ShowDialog();
        }

        private void buttonEditMyProfile_Click(object sender, EventArgs e)
        {
            new EditMyProfile(this, _loggedIn).ShowDialog();
        }
    }
}