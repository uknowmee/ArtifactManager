using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class EditMyProfile : Form, IStandardView
    {
        private readonly AdminPanel _lastWindow;
        private readonly LoggedAdmin _loggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditMyProfile(Form last, LoggedIn loggedIn)
        {
            _loggedIn = (LoggedAdmin) loggedIn;
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
            textBoxNick.Text = _loggedIn.User.Nick;
            textBoxRoleName.Text = _loggedIn.Role.Name;
            textBoxDescription.Text = _loggedIn.Role.Description;

            textBoxOldPass.Text = "";
            textBoxNewPass1.Text = "";
            textBoxNewPass2.Text = "";

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

        private void EditMyProfile_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void EditMyProfile_Resize(object sender, EventArgs e)
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

        private void textBoxNick_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void textBoxRoleName_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void textBoxOldPass_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void textBoxNewPass1_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void textBoxNewPass2_TextChanged(object sender, EventArgs e)
        {
            checkBoxChanged = CheckBoxChanged.AdminProfileEdited(textBoxNick.Text, textBoxRoleName.Text,
                textBoxDescription.Text,
                textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text, _loggedIn, checkBoxChanged);

            if (checkBoxChanged.Checked)
            {
                checkBoxSaved.Checked = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (_loggedIn.IsMyNewDataValid(textBoxNick.Text, textBoxRoleName.Text, textBoxDescription.Text,
                    textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text))
            {
                MessageBox.Show(@"You can save your Data!", @"CORRECT!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!_loggedIn.SaveAdminData(textBoxNick.Text, textBoxRoleName.Text, textBoxDescription.Text,
                    textBoxOldPass.Text, textBoxNewPass1.Text, textBoxNewPass2.Text)) return;

            checkBoxChanged.Checked = false;
            checkBoxSaved.Checked = true;
            LoadData();

            MessageBox.Show(@"Your data has been saved!", @"SAVED!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void checkBoxChanged_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(false, (CheckBox) sender);
        }

        private void checkBoxSaved_Click(object sender, EventArgs e)
        {
            CheckBoxChanged.CheckPreviousState(false, (CheckBox) sender);
        }
    }
}