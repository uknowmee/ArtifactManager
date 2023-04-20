using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class EditUser : Form, IStandardView
    {
        private readonly DbUserBuilder _dbUserBuilder;

        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditUser(Form last, LoggedIn loggedIn)
        {
            _dbUserBuilder = new DbUserBuilder("");

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
            comboBoxRoleName.Enabled = toSet;

            textBoxNick.Enabled = toSet;
            textBoxNewPass1.Enabled = toSet;
            textBoxNewPass2.Enabled = toSet;

            buttonApply.Enabled = toSet;
            buttonCheck.Enabled = toSet;
            buttonClear.Enabled = toSet;
            buttonDelete.Enabled = toSet;
        }

        private void ClearControls()
        {
            textBoxNick.Text = "";
            textBoxNewPass1.Text = "";
            textBoxNewPass2.Text = "";
            comboBoxRoleName.Items.Clear();
        }
        
        private void ShowUsers()
        {
            ClearControls();

            comboBoxNick.Items.Clear();
            using (var db = new DbCtx())
            {
                foreach (String nick in db.UserNicksWithoutAdmin())
                {
                    comboBoxNick.Items.Add(nick);
                }
            }
        }

        private void ShowRoles()
        {
            if (comboBoxNick.Text == "") return;

            comboBoxRoleName.Items.Clear();

            using (var db = new DbCtx())
            {
                comboBoxRoleName.Items.Add(db.GetUserRole(comboBoxNick.Text)[0].Name);
                comboBoxRoleName.SelectedIndex = 0;
                var roleName = comboBoxRoleName.Text;

                foreach (Role role in db.GetRolesWithoutUserRole(roleName))
                {
                    comboBoxRoleName.Items.Add(role.Name);
                }
            }
        }

        public void LoadData()
        {
            ShowUsers();
            ControlsLocked(false);
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

        private void EditUser_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void EditUser_Resize(object sender, EventArgs e)
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

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            _dbUserBuilder.Update(comboBoxRoleName, textBoxNick, textBoxNewPass1, textBoxNewPass2);

            if (_dbUserBuilder.UserCompare(comboBoxNick.Text))
            {
                MessageBox.Show(@"You cant create specified user!", @"Data is incorrect", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_dbUserBuilder.IsAvailable(comboBoxRoleName.Text, comboBoxNick.Text))
            {
                MessageBox.Show(@"You can create specified user!", @"Data is correct", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            _dbUserBuilder.Update(comboBoxRoleName, textBoxNick, textBoxNewPass1, textBoxNewPass2);

            if (_dbUserBuilder.UserCompare(comboBoxNick.Text))
            {
                MessageBox.Show(@"You cant create specified user!", @"Data is incorrect", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!_dbUserBuilder.IsAvailable(comboBoxRoleName.Text, comboBoxNick.Text)) return;

            _dbUserBuilder.UpdateUser(comboBoxNick.Text);
            
            MessageBox.Show(@"User updated!!!", @"Success!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(@"Do you really want to delete user?", @"proceed delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                _dbUserBuilder.DeleteUser(comboBoxNick.Text);
                LoadData();
            }
        }

        private void comboBoxNick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNick.Text == "")
            {
                ShowUsers();
                LoadData();
                return;
            }

            ClearControls();
            ShowRoles();
            ControlsLocked(true);
        }
    }
}