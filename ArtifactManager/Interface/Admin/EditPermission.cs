using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class EditPermission : Form, IStandardView
    {
        private List<Permission> _permissions;

        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditPermission(Form last, LoggedIn loggedIn)
        {
            _permissions = new List<Permission>();

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

            _permissions = EditPermissionView.GetPermissions(_permissions);
            comboBoxPermissions = EditPermissionView.ShowPermissions(_permissions, comboBoxPermissions);
            comboBoxCategory = EditPermissionView.ShowCategories(comboBoxCategory);

            checkBoxChanged.Checked = false;
            checkBoxSaved.Checked = false;
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

        private void EditPermission_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void EditPermission_Resize(object sender, EventArgs e)
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

        private void comboBoxPermissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxAdd.Checked = false;
                checkBoxDelete.Checked = false;
                checkBoxEdit.Checked = false;
                checkBoxMakeInstance.Checked = false;
                checkBoxKillInstance.Checked = false;

                if (comboBoxCategory.Items.Count == 0) return;

                comboBoxCategory.SelectedIndex = 0;
                comboBoxCategory.Enabled = false;
                return;
            }

            Permission permission =
                EditPermissionView.PermissionDetails(comboBoxPermissions.SelectedIndex, _permissions);

            checkBoxAdd.Checked = permission.Add;
            checkBoxDelete.Checked = permission.Delete;
            checkBoxEdit.Checked = permission.Edit;
            checkBoxMakeInstance.Checked = permission.MakeInstance;
            checkBoxKillInstance.Checked = permission.KillInstance;

            comboBoxCategory =
                EditPermissionView.ShowPermissionCategory(permission.PermissionId, comboBoxCategory);
        }

        private void checkBoxChanged_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(false, (CheckBox) sender);
        }

        private void checkBoxSaved_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(false, (CheckBox) sender);
        }

        private void checkBoxAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxAdd.Checked = false;
                return;
            }

            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void checkBoxDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxDelete.Checked = false;
                return;
            }

            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void checkBoxEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxEdit.Checked = false;
                return;
            }

            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void checkBoxMakeInstance_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxMakeInstance.Checked = false;
                return;
            }

            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void checkBoxKillInstance_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                checkBoxKillInstance.Checked = false;
                return;
            }

            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permission permission = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            checkBoxChanged = CheckBoxChanged.PermissionEdited(permission, comboBoxPermissions,
                _permissions, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "") return;

            Permission permission1 = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            EditPermissionView.IsEditedPermissionValid(LoggedIn, permission1, checkBoxChanged.Checked);
        }

        private void buttonSavePermission_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "") return;

            Permission permission1 = DbGenerator.MakeTempPermission(comboBoxCategory.Text, checkBoxAdd.Checked,
                checkBoxDelete.Checked, checkBoxEdit.Checked, checkBoxMakeInstance.Checked,
                checkBoxKillInstance.Checked);

            if (!EditPermissionView.IsEditedPermissionValid(LoggedIn, permission1, checkBoxChanged.Checked)) return;

            LoggedIn.EditPermission(permission1, comboBoxPermissions, _permissions);

            checkBoxChanged.Checked = false;
            checkBoxSaved.Checked = true;
            LoadData();

            MessageBox.Show(@"Permission has been updated!", @"SAVED!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonDeletePermission_Click(object sender, EventArgs e)
        {
            if (comboBoxPermissions.Text == "")
            {
                return;
            }

            if (checkBoxChanged.Checked)
            {
                MessageBox.Show(@"Save Permission, before you delete it", @"UNSAVED!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            
            EditPermissionView.DeletePermission(_permissions, comboBoxPermissions);

            LoadData();
        }
    }
}