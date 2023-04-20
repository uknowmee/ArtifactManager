using System;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class AddInstance : Form, IStandardView
    {
        public bool Setting;
        
        private readonly DbInstanceBuilder _instanceBuilder;
        private readonly UserPanel _lastWindow;
        public readonly LoggedIn LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }
        public AddInstance(Form last, LoggedIn loggedIn, String categoryName, String instanceName)
        {
            Setting = false;
            
            _instanceBuilder = new DbInstanceBuilder(loggedIn, categoryName, instanceName);
            
            _lastWindow = (UserPanel) last;
            LoggedIn = loggedIn;

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        private void ChangeVis()
        {
            _instanceBuilder.DataToShow(treeView.SelectedNode.Text);
            comboBoxExistingAttribute = _instanceBuilder.GetComboBox(comboBoxExistingAttribute);
        }
        
        public void LoadData()
        {
            LoggedIn.Update(LoggedIn.User.Nick);
        }

        public void Components()
        {
            treeView = _instanceBuilder.ShowTree(treeView);
            
            var ret = StandardView.FormInit(this, panel1);
            Loaded = ret.Item1;
            OriginalFormSize = ret.originalFormSize;
            MyControls = ret.myControls;
            
            StandardView.SmallWindow(this);
            CenterToParent();
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

        private void AddInstance_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void AddInstance_Resize(object sender, EventArgs e)
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

        private void comboBoxExistingAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Setting)
            {
                return;
            }

            textBoxValue.Text = _instanceBuilder.GetValue(comboBoxExistingAttribute.SelectedIndex);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!_instanceBuilder.Apply(comboBoxExistingAttribute.Text, textBoxValue.Text))
            {
                MessageBox.Show(@"Incorrect value!", @"Change value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxValue.Text = "";
            Setting = true;
            comboBoxExistingAttribute.SelectedIndex = 0;
            Setting = false;
        }

        private void buttonApplyAll_Click(object sender, EventArgs e)
        {
            if (!_instanceBuilder.AllFilled())
            {
                MessageBox.Show(@"Fill data value!", @"Not ready yet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_instanceBuilder.MakeInstance())
            {
                MessageBox.Show(@"Your instance is to strong!", @"Too strong!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            MessageBox.Show(@"Created!!", @"Instance Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            buttonQuit.PerformClick();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            ChangeVis();
        }
    }
}