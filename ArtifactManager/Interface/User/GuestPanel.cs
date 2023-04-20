using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class GuestPanel : Form, IStandardView
    {
        private Login _lastWindow;
        public LoggedIn LoggedIn;

        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public GuestPanel(Form last, LoggedIn loggedIn)
        {
            _lastWindow = (Login) last;
            LoggedIn = loggedIn;

            Path = _lastWindow.Path;
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

        private void GuestPanel_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void GuestPanel_Resize(object sender, EventArgs e)
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


        private void buttonCategoryTree_Click(object sender, EventArgs e)
        {
            new CategoryTree(this, true, false, false, false).ShowDialog();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            new Categories(this, true, false).ShowDialog();
        }

        private void buttonInstances_Click(object sender, EventArgs e)
        {
            new Instances(this, true, false).ShowDialog();
        }
    }
}