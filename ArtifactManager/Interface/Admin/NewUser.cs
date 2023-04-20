using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.Admin
{
    public partial class NewUser : Form, IStandardView
    {
        private readonly DbUserBuilder _dbUserBuilder;

        private readonly AdminPanel _lastWindow;
        public LoggedAdmin LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public NewUser(Form last, LoggedIn loggedIn)
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

        public void LoadData()
        {
            comboBoxRoleName = NewUserView.GetRoleNames(comboBoxRoleName);
            textBoxNick.Text = "";
            textBoxNewPass1.Text = "";
            textBoxNewPass2.Text = "";
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

        private void NewUser_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void NewUser_Resize(object sender, EventArgs e)
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

        private void comboBoxRoleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dbUserBuilder.Update(comboBoxRoleName, textBoxNick, textBoxNewPass1, textBoxNewPass2);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            _dbUserBuilder.Update(comboBoxRoleName, textBoxNick, textBoxNewPass1, textBoxNewPass2);

            if (_dbUserBuilder.IsAvailable(comboBoxRoleName.Text, ""))
            {
                MessageBox.Show(@"You can create specified user!", @"Data are correct", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            _dbUserBuilder.Update(comboBoxRoleName, textBoxNick, textBoxNewPass1, textBoxNewPass2);

            if (_dbUserBuilder.CreateUser(comboBoxRoleName.Text))
            {
                MessageBox.Show(@"User created!", @"Success!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}