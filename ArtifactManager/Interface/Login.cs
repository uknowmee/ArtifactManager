using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models.Instances;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface
{
    public partial class Login : Form, IStandardView
    {
        public readonly AppStart LastWindow;

        private int _changesNum;

        private int _instancesNum;

        private List<Instance> _instances;

        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public Login(Form last)
        {
            _changesNum = 5;
            _instancesNum = 5;
            LastWindow = (AppStart) last;

            Path = LastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        public void LoadData()
        {
            labelChanges.Text = _changesNum.ToString();
            listBoxChanges = LoginView.ChangesLoad(_changesNum, listBoxChanges);

            comboBoxNick = LoginView.Nicks(comboBoxNick);
            labelAccInfo = LoginView.AccInfo(comboBoxNick.Text, labelAccInfo);

            labelInstance.Text = _instancesNum.ToString();
            comboBoxCategory = LoginView.ExistingInstancesCategories(comboBoxCategory);
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

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            LastWindow.ShowWindow();
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool authSuccess = UserManager.TryAuth(comboBoxNick.Text, textBoxPass.Text);

            if (!authSuccess)
            {
                MessageBox.Show(@"Wrong password!", @"WRONG PASS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass.Text = "";
                return;
            }

            LoginView.PerformLogin(this, comboBoxNick.Text);
            Hide();
            textBoxPass.Text = "";
        }

        private void buttonChangesLess_Click(object sender, EventArgs e)
        {
            if (_changesNum > 1)
            {
                _changesNum -= 1;
                labelChanges.Text = _changesNum.ToString();
                listBoxChanges = LoginView.ChangesLoad(_changesNum, listBoxChanges);
            } else
            {
                MessageBox.Show(@"Cant go lower", @"INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChangesMore_Click(object sender, EventArgs e)
        {
            if (_changesNum < 20)
            {
                _changesNum += 1;
                labelChanges.Text = _changesNum.ToString();
                listBoxChanges = LoginView.ChangesLoad(_changesNum, listBoxChanges);
            } else
            {
                MessageBox.Show(@"Cant go higher", @"INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInstancesLess_Click(object sender, EventArgs e)
        {
            if (_instancesNum > 1)
            {
                _instancesNum -= 1;
                comboBoxCategory = LoginView.ExistingInstancesCategories(comboBoxCategory);
            } else
            {
                MessageBox.Show(@"Cant go lower", @"INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInstancesMore_Click(object sender, EventArgs e)
        {
            if (_instancesNum < 20)
            {
                _instancesNum += 1;
                comboBoxCategory = LoginView.ExistingInstancesCategories(comboBoxCategory);
            } else
            {
                MessageBox.Show(@"Cant go higher", @"INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxNick_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAccInfo = LoginView.AccInfo(comboBoxNick.Text, labelAccInfo);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "") return;
            
            _instances = LoginView.Instances(comboBoxCategory.Text, _instancesNum);
            listBoxInstances = LoginView.InstancesShow(_instances, listBoxInstances);
            labelInstanceInfo = LoginView.InstanceInfo(_instances, labelInstanceInfo);
        }
    }
}