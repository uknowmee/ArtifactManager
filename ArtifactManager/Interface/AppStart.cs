using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface
{
    public partial class AppStart : Form, IStandardView
    {
        private bool _shouldMakeDb;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public AppStart()
        {
            _shouldMakeDb = DbGenerator.ShouldMakeDb();
            Path = "../../Resources/Pictures/Background.jpg";

            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();

            labelPending.Hide();
        }

        public void LoadData()
        {
            _shouldMakeDb = DbGenerator.ShouldMakeDb();
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

        private void AppStart_Load(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }

            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void AppStart_Resize(object sender, EventArgs e)
        {
            MinimizeMaximizeChange = StandardView.ResizeDecision(this, MyControls, panel1, Width, Height,
                OriginalFormSize,
                MinimizeMaximizeChange, buttonQuit, Loaded);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            AppStartView.MakeOrConnectDb(_shouldMakeDb);

            buttonStart.Enabled = false;
            buttonQuit.Enabled = false;

            timerPending.Enabled = true;
            labelPending.Show();

            Task.Run(() =>
            {
                DbGenerator.MakeDb(_shouldMakeDb);

                Invoke(new Action(() =>
                {
                    labelPending.Hide();

                    timerPending.Enabled = false;
                    labelPending.Text = "";

                    buttonStart.Enabled = true;
                    buttonQuit.Enabled = true;

                    MessageBox.Show(@"Connected to Database!", @"Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    new Login(this).Show();
                    Hide();
                }));
            });
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerPending_Elapsed(object sender, ElapsedEventArgs e)
        {
            StandardView.Pending(labelPending);
        }
    }
}