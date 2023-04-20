using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class NewRole : Form, IStandardView
    {
        private readonly DbRoleBuilder _dbRoleBuilder;
        private bool _showingData;

        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public NewRole(Form last, LoggedIn loggedIn)
        {
            _showingData = false;
            _dbRoleBuilder = new DbRoleBuilder();

            LoggedIn = (LoggedAdmin) loggedIn;
            _lastWindow = (AdminPanel) last;

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        private void ShowPermissions()
        {
            comboBoxAddPermissions.Items.Clear();
            foreach (Permission roleBuilderPermission in _dbRoleBuilder.Permissions)
            {
                comboBoxAddPermissions.Items.Add(roleBuilderPermission);
            }
        }

        private void ShowRolePermissions()
        {
            comboBoxDeletePermission.Items.Clear();
            foreach (Permission roleBuilderPermission in _dbRoleBuilder.RolePermissions)
            {
                comboBoxDeletePermission.Items.Add(roleBuilderPermission);
            }
        }

        private void ShowData()
        {
            ShowPermissions();
            ShowRolePermissions();

            _showingData = true;
            textBoxRoleName.Text = _dbRoleBuilder.Name;
            textBoxDescription.Text = _dbRoleBuilder.Description;
            _showingData = false;
        }

        public void LoadData()
        {
            _dbRoleBuilder.FreshRoleBuilder();
            ShowData();
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

        private void NewRole_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void NewRole_Resize(object sender, EventArgs e)
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

        private void buttonAddPermission_Click(object sender, EventArgs e)
        {
            if (!_dbRoleBuilder.ToRolePermission(comboBoxAddPermissions)) return;

            ShowPermissions();
            ShowRolePermissions();
        }

        private void buttonDeletePermission_Click(object sender, EventArgs e)
        {
            if (!_dbRoleBuilder.ToPermission(comboBoxDeletePermission)) return;

            ShowPermissions();
            ShowRolePermissions();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            if (_dbRoleBuilder.IsAvailable(null))
            {
                MessageBox.Show(@"You can add your role!", @"CORRECT ROLE", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonSaveRole_Click(object sender, EventArgs e)
        {
            _dbRoleBuilder.Save();
            LoadData();
        }

        private void textBoxRoleName_TextChanged(object sender, EventArgs e)
        {
            if (_showingData)
            {
                return;
            }

            _dbRoleBuilder.Update(textBoxRoleName.Text, textBoxDescription.Text);
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (_showingData)
            {
                return;
            }

            _dbRoleBuilder.Update(textBoxRoleName.Text, textBoxDescription.Text);
        }
    }
}