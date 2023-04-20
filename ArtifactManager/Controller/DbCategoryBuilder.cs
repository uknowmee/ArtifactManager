using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public class DbCategoryBuilder
    {
        private readonly LoggedIn _loggedIn;

        public DbGenerator.ValueType ValueType;

        public List<Category> Categories;

        public List<Property> Properties;
        public List<BaseProperty> BaseProperties;
        private List<Limit> _limits;

        public Category Category;

        private String _categoryName;
        private int _categoryId;

        private readonly bool _loaded;

        public DbCategoryBuilder(LoggedIn loggedIn)
        {
            _loggedIn = loggedIn;
            _loaded = false;
        }

        public DbCategoryBuilder(LoggedIn loggedIn, string categoryName)
        {
            _loggedIn = loggedIn;
            _loaded = true;
            LoadCategory(categoryName);
        }

        private void LoadCategory(string categoryName)
        {
            using (var db = new DbCtx())
            {
                Category = db.GetCategory(categoryName);
                _categoryName = categoryName;
                Properties = db.GetCategoryProperties(Category.CategoryId);
                BaseProperties = db.GetCategoryBaseProperties(Category.CategoryId);
                _limits = db.GetCategoryLimits(Category.CategoryId);

                _categoryId = Category.CategoryId;

                Categories = db.GetCategories();

                foreach (Category category in Categories)
                {
                    if (category.CategoryId == _categoryId)
                    {
                        Categories.Remove(category);
                        break;
                    }
                }
            }
        }

        private bool IsPropertyValid(String elementName)
        {
            if ((from baseProperty in BaseProperties
                    from property in Properties
                    where baseProperty.Name == elementName || property.Name == elementName
                    select baseProperty).Any())
            {
                return false;
            }

            if (elementName == "")
            {
                return false;
            }

            return true;
        }

        private bool IsBasePropertyValid(string attrName, string type, bool strongest)
        {
            if (_limits.Any(limit => limit.MeansStronger && strongest))
            {
                return false;
            }

            if (!(type == "Int" || type == "Bool" || type == "String"))
            {
                return false;
            }

            if (strongest && type != "Int")
            {
                return false;
            }

            if ((from baseProperty in BaseProperties
                    from property in Properties
                    where baseProperty.Name == attrName || property.Name == attrName
                    select baseProperty).Any())
            {
                return false;
            }

            if (attrName == "")
            {
                return false;
            }

            return true;
        }

        private bool IsCategoryNameValid(String newCategoryName)
        {
            if (newCategoryName == "")
            {
                MessageBox.Show(@"Category Name cant be empty", @"Fill name", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (_loaded)
            {
                if (Category.Name == _categoryName)
                {
                    return true;
                }
            }

            using (var db = new DbCtx())
            {
                if (db.GetCategoryNames().Contains(newCategoryName))
                {
                    MessageBox.Show(@"You cant create category!", @"NO PERMISSION", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }

            return true;
        }

        private bool CanUserCreateCategory(String parentName, String newCategoryName)
        {
            if (!_loggedIn.CanCreateCategory(parentName, newCategoryName))
            {
                MessageBox.Show(@"You cant create category!", @"NO PERMISSION", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public bool CanUserEditCategory(string categoryName)
        {
            if (!_loggedIn.CanEditCategory(categoryName))
            {
                MessageBox.Show(@"You cant edit category!", @"NO PERMISSION", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool CanUserDeleteCategory(String categoryName)
        {
            if (!_loggedIn.CanDeleteCategory(categoryName))
            {
                MessageBox.Show(@"You cant delete category!", @"NO PERMISSION", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public bool CreateCategory(string parentName, string newCategoryName)
        {
            if (!IsCategoryNameValid(newCategoryName))
            {
                return false;
            }

            if (!CanUserCreateCategory(parentName, newCategoryName))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                Category category = db.CreateCategory(parentName, newCategoryName, _loggedIn.User.Id);
                db.ModifiedAdd(true, false, false, category, _loggedIn.User.Id);
            }

            return true;
        }

        public void UpdateCategoryBuilder()
        {
            using (var db = new DbCtx())
            {
                LoadCategory(db.GetCategory(_categoryId).Name);
            }
        }

        public bool NewElement(TextBox textBoxElementName, string categoryName)
        {
            if (!IsPropertyValid(textBoxElementName.Text))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                db.AddProperty(textBoxElementName.Text, db.GetCategory(categoryName).CategoryId, _categoryId,
                    _loggedIn.User.Id);
            }

            UpdateCategoryBuilder();

            return true;
        }

        public bool NewAttribute(TextBox attributeName, string type, bool strongest)
        {
            if (!IsBasePropertyValid(attributeName.Text, type, strongest))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                db.AddBaseProperty(attributeName.Text, type, strongest, _categoryId, _loggedIn.User.Id);
            }

            UpdateCategoryBuilder();

            return true;
        }

        public bool DeleteCategory(String categoryName)
        {
            if (!CanUserDeleteCategory(categoryName))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                db.DeleteCategory(categoryName);
            }

            return true;
        }

        public bool DeleteAttribute(string basePropertyName)
        {
            using (var db = new DbCtx())
            {
                foreach (Category parentCategory in DbTreeBuilder.MakeParentCategories(_categoryName))
                {
                    if (db.GetCategoryBaseProperties(parentCategory.CategoryId).Select(p => p.Name)
                        .Contains(basePropertyName))
                    {
                        return false;
                    }
                }

                db.DeleteBaseProperty(_categoryName, basePropertyName);
            }

            return true;
        }

        public bool DeleteElement(string propertyName)
        {
            using (var db = new DbCtx())
            {
                foreach (Category parentCategory in DbTreeBuilder.MakeParentCategories(_categoryName))
                {
                    if (db.GetCategoryProperties(parentCategory.CategoryId).Select(p => p.Name).Contains(propertyName))
                    {
                        return false;
                    }
                }

                db.DeleteProperty(_categoryName, propertyName);
            }

            return true;
        }

        public ComboBox ElemTypeInfo(ComboBox comboBoxElementType, string elemName)
        {
            string elem;
            using (var db = new DbCtx())
            {
                elem = db.GetCategory(db.GetCategoryProperties(_categoryId).Single(p => p.Name == elemName).ElementId)
                    .Name;
            }

            comboBoxElementType.Items.Clear();
            comboBoxElementType.Items.Add(elem);
            comboBoxElementType.SelectedIndex = 0;
            List<String> parents = DbTreeBuilder.MakeParentCategories(Category.Name).Select(c => c.Name).ToList();
            List<String> child;
            child = parents.Count > 0
                ? DbTreeBuilder.MakeChildCategories(parents[0]).Select(c => c.Name).ToList()
                : DbTreeBuilder.MakeChildCategories(Category.Name).Select(c => c.Name).ToList();

            child.AddRange(parents);

            foreach (var category in Categories.Where(category => !child.Contains(category.Name)))
            {
                if (!comboBoxElementType.Items.Contains(category.Name) &&
                    !comboBoxElementType.Items.Contains(category.Name))
                {
                    comboBoxElementType.Items.Add(category.Name);
                }
            }

            return comboBoxElementType;
        }

        public int AttrTypeInfo(string attrName)
        {
            using (var db = new DbCtx())
            {
                var num = db.GetCategoryBaseProperties(_categoryId)
                    .Single(b => b.Name == attrName)
                    .Type;

                int ret = 0;
                switch (num)
                {
                    case "Int":
                        ret = 1;
                        break;
                    case "String":
                        ret = 2;
                        break;
                    case "Bool":
                        ret = 3;
                        break;
                }

                return ret;
            }
        }

        public bool NewName(TextBox textBoxCategoryName)
        {
            using (var db = new DbCtx())
            {
                var cat = db.GetCategory(_categoryId);
                cat.Name = textBoxCategoryName.Text;
                db.SaveChanges();
            }

            _categoryName = textBoxCategoryName.Text;
            return true;
        }
    }
}