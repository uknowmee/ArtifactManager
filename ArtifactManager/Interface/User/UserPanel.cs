using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class UserPanel : Form, IStandardView
    {
        private Login _lastWindow;
        public readonly LoggedIn LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public UserPanel(Form last, LoggedIn loggedIn)
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

        private void UserPanel_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void UserPanel_Resize(object sender, EventArgs e)
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
            new CategoryTree(this, false, false, false, false).ShowDialog();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            new Categories(this, false, false).ShowDialog();
        }

        private void buttonInstances_Click(object sender, EventArgs e)
        {
            new Instances(this, false, false).ShowDialog();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var treeWindow = new CategoryTree(this, false, true, false, false);
            treeWindow.ShowDialog();

            if (!treeWindow.ToReturn) return;
            
            if (new DbCategoryBuilder(LoggedIn).CreateCategory(treeWindow.ParentName, treeWindow.CategoryInstanceName))
            {
                MessageBox.Show(@"Category created!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Editing category will kill all existing instances!", @"Proceed?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            var treeWindow = new CategoryTree(this, false, false, false, true);
            treeWindow.ShowDialog();

            if (!treeWindow.ToReturn) return;

            if (new DbCategoryBuilder(LoggedIn).CanUserEditCategory(treeWindow.CategoryInstanceName))
            {
                new EditCategory(this, LoggedIn, treeWindow.CategoryInstanceName).ShowDialog();
            }
        }

        private void buttonAddInstance_Click(object sender, EventArgs e)
        {
            var treeWindow = new CategoryTree(this, false, true, true, false);
            treeWindow.ShowDialog();
            if (treeWindow.ToReturn)
            {
                if (new DbInstanceBuilder(LoggedIn).CreateInstance(treeWindow.ParentName,
                        treeWindow.CategoryInstanceName))
                {
                    using (var db = new DbCtx())
                    {
                        new AddInstance(this, LoggedIn, treeWindow.ParentName, treeWindow.CategoryInstanceName).ShowDialog();
                    }
                }
            }
        }

        private void buttonEditMyPassword_Click(object sender, EventArgs e)
        {
            new EditMyPassword(this, false).ShowDialog();
        }
    }
}