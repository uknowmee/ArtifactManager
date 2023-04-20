using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models.Instances;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class Instances : Form, IStandardView
    {
        private List<Instance> _instances;

        private readonly Form _lastWindow;
        private readonly bool _isGuest;
        public LoggedIn LoggedIn;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public Instances(Form last, bool isGuest, bool isNew)
        {
            _isGuest = isGuest;

            if (isGuest)
            {
                Path = ((GuestPanel) last).Path;
                _lastWindow = last;
                LoggedIn = ((GuestPanel) last).LoggedIn;
            } else
            {
                Path = ((UserPanel) last).Path;
                _lastWindow = last;
                LoggedIn = ((UserPanel) last).LoggedIn;
            }

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
            treeView1 = DbTreeBuilder.MakeTree(treeView1);
            
            var ret = StandardView.FormInit(this, panel1);
            Loaded = ret.Item1;
            OriginalFormSize = ret.originalFormSize;
            MyControls = ret.myControls;

            WindowState = FormWindowState.Maximized;
        }

        public void ShowWindow()
        {
            StandardView.SmallWindow(this);
            CenterToParent();

            LoadData();
            Show();
        }

        private void Instances_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void Instances_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (_isGuest)
            {
                ((GuestPanel) _lastWindow).ShowWindow();
                Close();
            } else
            {
                ((UserPanel) _lastWindow).ShowWindow();
                Close();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Text == @"World")
            {
                return;
            }
            
            listBox1.Items.Clear();
            label1.Text = "";

            _instances = LoginView.Instances(treeView1.SelectedNode.Text, 100);
            listBox1 = LoginView.InstancesShow(_instances, listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            
            string insName = ((Instance) listBox1.Items[listBox1.SelectedIndex]).Name;
            
            if ( insName == "")
            {
                return;
            }
            
            label1 = LoginView.InstanceInfo(treeView1.SelectedNode.Text, insName, label1);

        }
    }
}