using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.Interface.Utils;
using ArtifactManager.Interface.Utils.Views;

namespace ArtifactManager.Interface.User
{
    public partial class EditCategory : Form, IStandardView
    {
        private readonly UserPanel _lastWindow;
        public readonly LoggedIn LoggedIn;
        public DbCategoryBuilder CategoryBuilder;
        private bool _selecting;
        public string Path { get; set; }
        public Rectangle OriginalFormSize { get; set; }
        public MyControls MyControls { get; set; }
        public bool MinimizeMaximizeChange { get; set; }
        public bool Loaded { get; set; }

        public EditCategory(Form last, LoggedIn loggedIn, String categoryName)
        {
            using (var db = new DbCtx())
            {
                db.DeleteInstances(db.GetCategory(categoryName).CategoryId);
            }
            
            _selecting = false;

            _lastWindow = (UserPanel) last;
            LoggedIn = loggedIn;

            CategoryBuilder = new DbCategoryBuilder(LoggedIn, categoryName);

            Path = _lastWindow.Path;
            MinimizeMaximizeChange = false;
            Loaded = false;

            InitializeComponent();
            Components();
            LoadData();
        }

        private void AttTypeReset()
        {
            comboBoxAttributeType.Items.Clear();
            comboBoxAttributeType.Items.Add("");
            comboBoxAttributeType.Items.Add("Int");
            comboBoxAttributeType.Items.Add("String");
            comboBoxAttributeType.Items.Add("Bool");

            _selecting = true;
            comboBoxAttributeType.SelectedIndex = 0;
            _selecting = false;
        }

        private void CategoryNamesReset()
        {
            comboBoxCategoryName.Items.Clear();
            foreach (Category category in CategoryBuilder.Categories)
            {
                comboBoxCategoryName.Items.Add(category.Name);
            }

            comboBoxCategoryName.Items.Add(CategoryBuilder.Category.Name);

            _selecting = true;
            comboBoxCategoryName.SelectedIndex = comboBoxCategoryName.Items.Count - 1;
            _selecting = false;
        }

        private void ExistingAttributeReset()
        {
            comboBoxExistingAttribute.Items.Clear();
            comboBoxExistingAttribute.Items.Add("");
            foreach (BaseProperty baseProperty in CategoryBuilder.BaseProperties)
            {
                comboBoxExistingAttribute.Items.Add(baseProperty.Name);
            }

            _selecting = true;
            comboBoxExistingAttribute.SelectedIndex = 0;
            _selecting = false;
        }

        private void ExistingElementReset()
        {
            comboBoxExistingElement.Items.Clear();
            comboBoxExistingElement.Items.Add("");
            foreach (Property property in CategoryBuilder.Properties)
            {
                comboBoxExistingElement.Items.Add(property.Name);
            }

            _selecting = true;
            comboBoxExistingElement.SelectedIndex = 0;
            _selecting = false;
        }

        private void ElemTypeReset()
        {
            comboBoxElementType.Items.Clear();

            List<String> parents = DbTreeBuilder.MakeParentCategories(CategoryBuilder.Category.Name).Select(c => c.Name)
                .ToList();
            List<String> child;
            child = parents.Count > 0
                ? DbTreeBuilder.MakeChildCategories(parents[0]).Select(c => c.Name).ToList()
                : DbTreeBuilder.MakeChildCategories(CategoryBuilder.Category.Name).Select(c => c.Name).ToList();
            
            child.AddRange(parents);

            foreach (var category in CategoryBuilder.Categories.Where(category => !child.Contains(category.Name)))
            {
                if (!comboBoxElementType.Items.Contains(category.Name) &&
                    !comboBoxElementType.Items.Contains(category.Name))
                {
                    comboBoxElementType.Items.Add(category.Name);
                }
            }
        }

        public void ShowView()
        {
            textBoxCategoryName.Text = CategoryBuilder.Category.Name;
            textBoxAttributeName.Text = "";
            textBoxElementName.Text = "";

            AttTypeReset();
            ElemTypeReset();
            CategoryNamesReset();
            ExistingAttributeReset();
            ExistingElementReset();
        }

        public void LoadData()
        {
            LoggedIn.Update(LoggedIn.User.Nick);

            CategoryBuilder.UpdateCategoryBuilder();

            ShowView();
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
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }

            LoadData();
            Show();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackgroundImage = Image.FromFile(Path);
        }

        private void EditCategory_Resize(object sender, EventArgs e)
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

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selecting)
            {
                return;
            }

            CategoryBuilder = new DbCategoryBuilder(LoggedIn, comboBoxCategoryName.Text);
            LoadData();
        }

        private void comboBoxExistingAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selecting)
            {
                return;
            }

            if (comboBoxExistingAttribute.Text == "")
            {
                textBoxAttributeName.Text = "";
                AttTypeReset();
                return;
            }

            textBoxAttributeName.Text = comboBoxExistingAttribute.Text;
            AttTypeReset();

            _selecting = true;
            comboBoxAttributeType.SelectedIndex = CategoryBuilder.AttrTypeInfo(comboBoxExistingAttribute.Text);
            _selecting = false;
        }

        private void comboBoxExistingElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selecting)
            {
                return;
            }

            if (comboBoxExistingElement.Text == "")
            {
                textBoxElementName.Text = "";
                ElemTypeReset();
                return;
            }

            textBoxElementName.Text = comboBoxExistingElement.Text;
            ElemTypeReset();

            _selecting = true;
            comboBoxElementType = CategoryBuilder.ElemTypeInfo(comboBoxElementType, comboBoxExistingElement.Text);
            _selecting = false;
        }

        private void buttonDeleteElement_Click(object sender, EventArgs e)
        {
            if (!CategoryBuilder.DeleteElement(comboBoxExistingElement.Text))
            {
                MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void buttonDeleteAttribute_Click(object sender, EventArgs e)
        {
            if (!CategoryBuilder.DeleteAttribute(comboBoxExistingAttribute.Text))
            {
                MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"You really want to delete?!", @"Proceed?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (!CategoryBuilder.DeleteCategory(comboBoxCategoryName.Text))
                {
                    MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonQuit.PerformClick();
            }
        }

        private void buttonNewAttribute_Click(object sender, EventArgs e)
        {
            if (!CategoryBuilder.NewAttribute(textBoxAttributeName, comboBoxAttributeType.Text,
                    checkBoxMeansStronger.Checked))
            {
                MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void buttonNewElement_Click(object sender, EventArgs e)
        {
            if (!CategoryBuilder.NewElement(textBoxElementName, comboBoxElementType.Text))
            {
                MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!CategoryBuilder.NewName(textBoxCategoryName))
            {
                MessageBox.Show(@"Error!", @":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Success!", @":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }
    }
}