using System;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class CategoryTree : Form, IStandardView
    {
        private readonly LoggedIn _loggedIn;
        private readonly Form _lastWindow;
        private readonly bool _isGuest;
        private readonly bool _isNew;
        private readonly bool _isInstance;
        private readonly bool _isEditCategory;

        public bool ToReturn;
        public String ParentName;
        public String CategoryInstanceName;


        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public CategoryTree(Form last, bool isGuest, bool isNew, bool isInstance, bool isEditCategory)
        {
            _isGuest = isGuest;
            _isNew = isNew;
            _isInstance = isInstance;
            _isEditCategory = isEditCategory;
            ToReturn = false;

            if (isGuest)
            {
                Path = ((GuestPanel) last).Path;
                _lastWindow = last;
                _loggedIn = ((GuestPanel) last).LoggedIn;
            } else
            {
                Path = ((UserPanel) last).Path;
                _lastWindow = last;
                _loggedIn = ((UserPanel) last).LoggedIn;
            }

            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        public void LoadData()
        {
            _loggedIn.Update(_loggedIn.User.Nick);
        }

        public void Components()
        {
            buttonApply.Visible = false;
            textBoxCategoryInstanceName.Visible = false;
            treeViewCategory = DbTreeBuilder.MakeTree(treeViewCategory);

            if (_isNew)
            {
                if (_isInstance)
                {
                    MessageBox.Show(
                        @"Define instance parent and Name! Remember, each instance name can exist only once!",
                        @"Name defining", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonApply.Visible = true;
                    textBoxCategoryInstanceName.Visible = true;
                } else
                {
                    MessageBox.Show(
                        @"Define category parent and Name! Remember, each category name can exist only once!",
                        @"Name defining", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonApply.Visible = true;
                    textBoxCategoryInstanceName.Visible = true;
                }
            }

            if (_isEditCategory)
            {
                MessageBox.Show(@"Define category you want to edit!", @"Category defining", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                buttonApply.Visible = true;
            }

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

        private void CategoryTree_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void CategoryTree_Resize(object sender, EventArgs e)
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

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ToReturn = true;
            try
            {
                ParentName = treeViewCategory.SelectedNode.Text;
            } catch (Exception exception)
            {
                MessageBox.Show(@"Select category!", @"No category selected", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CategoryInstanceName = textBoxCategoryInstanceName.Text;

            if (_isEditCategory)
            {
                CategoryInstanceName = ParentName;
            }

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
    }
}