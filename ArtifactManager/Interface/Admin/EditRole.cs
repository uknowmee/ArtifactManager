using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class EditRole : Form, IStandardView
    {
        private readonly DbRoleBuilder _oldDbRoleBuilder;
        private readonly DbRoleBuilder _dbRoleBuilder;
        private bool _showingData;

        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditRole(Form last, LoggedIn loggedIn)
        {
            _showingData = false;
            _dbRoleBuilder = new DbRoleBuilder();
            _oldDbRoleBuilder = new DbRoleBuilder();

            LoggedIn = (LoggedAdmin) loggedIn;
            _lastWindow = (AdminPanel) last;

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        private void ControlsLocked(bool toSet)
        {
            buttonAddPermission.Enabled = toSet;
            buttonDeletePermission.Enabled = toSet;
            buttonReset.Enabled = toSet;
            buttonCheckAvailability.Enabled = toSet;
            buttonSaveRole.Enabled = toSet;
            buttonDeleteRole.Enabled = toSet;

            comboBoxAddPermissions.Enabled = toSet;
            comboBoxDeletePermission.Enabled = toSet;

            textBoxRoleName.Enabled = toSet;
            textBoxDescription.Enabled = toSet;
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
            ControlsLocked(false);
            comboBoxOldRoleName = EditRoleView.ShowRoleNames(comboBoxOldRoleName);
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

        private void EditRole_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void EditRole_Resize(object sender, EventArgs e)
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
            if (_oldDbRoleBuilder.Compare(_dbRoleBuilder))
            {
                MessageBox.Show(@"Change Something!", @"UNCHANGED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (_dbRoleBuilder.IsAvailable(_oldDbRoleBuilder.Name))
            {
                MessageBox.Show(@"You can save your role!", @"CORRECT ROLE", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonSaveRole_Click(object sender, EventArgs e)
        {
            if (_oldDbRoleBuilder.Compare(_dbRoleBuilder))
            {
                MessageBox.Show(@"Change Something!", @"UNCHANGED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            _dbRoleBuilder.SaveExistingRole(_oldDbRoleBuilder.Name);
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

        private void comboBoxOldRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOldRoleName.Text == "") return;

            _oldDbRoleBuilder.FromRoleName(comboBoxOldRoleName.Text);
            _dbRoleBuilder.FromRoleName(comboBoxOldRoleName.Text);

            ControlsLocked(true);
            ShowData();
        }

        private void buttonDeleteRole_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(@"Do you want to delete?", @"Proceed delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog != DialogResult.Yes) return;
            
            if (_dbRoleBuilder.removeRole(comboBoxOldRoleName.Text))
            {
                LoadData();
            }
        }
    }
}