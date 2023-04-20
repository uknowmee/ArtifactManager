using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class NewPermission : Form, IStandardView
    {
        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public NewPermission(Form last, LoggedIn loggedIn)
        {
            LoggedIn = (LoggedAdmin) loggedIn;
            _lastWindow = (AdminPanel) last;

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        public void LoadData()
        {
            checkBoxAdd.Checked = false;
            checkBoxDelete.Checked = false;
            checkBoxEdit.Checked = false;
            checkBoxMakeInstance.Checked = false;
            checkBoxKillInstance.Checked = false;

            comboBoxCategories = NewPermissionView.CategoriesToPermissionMake(comboBoxCategories);
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

        private void NewPermission_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void NewPermission_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            _lastWindow.ShowWindow();
            Close();
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            NewPermissionView.IsPermissionValid(LoggedIn, checkBoxAdd.Checked, checkBoxDelete.Checked, checkBoxEdit.Checked,
                checkBoxMakeInstance.Checked, checkBoxKillInstance.Checked , comboBoxCategories.Text);
        }

        private void buttonSavePermission_Click(object sender, EventArgs e)
        {
            if (NewPermissionView.IsPermissionValid(LoggedIn, checkBoxAdd.Checked, checkBoxDelete.Checked, checkBoxEdit.Checked,
                    checkBoxMakeInstance.Checked, checkBoxKillInstance.Checked , comboBoxCategories.Text))
            {
                LoggedIn.AddPermission(checkBoxAdd.Checked, checkBoxDelete.Checked, checkBoxEdit.Checked,
                    checkBoxMakeInstance.Checked, checkBoxKillInstance.Checked , comboBoxCategories.Text);
                
                LoadData();
            }
        }
    }
}