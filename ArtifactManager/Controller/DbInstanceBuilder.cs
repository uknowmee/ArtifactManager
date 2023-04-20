using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;

namespace ArtifactManager.Controller
{
    public class DbInstanceBuilder
    {
        private LoggedIn _loggedIn;
        private String _categoryName;
        private String _instanceName;

        private List<Instance> _instances;
        private List<List<InsBaseProperty>> _baseProperties;
        private TreeView _myTree;
        private List<Container> _containers;

        private int currentIndex;

        public DbInstanceBuilder(LoggedIn loggedIn)
        {
            _loggedIn = loggedIn;
        }

        public DbInstanceBuilder(LoggedIn loggedIn, string categoryName, string instanceName)
        {
            _loggedIn = loggedIn;
            _instances = new List<Instance>();
            _baseProperties = new List<List<InsBaseProperty>>();
            _containers = new List<Container>();
            _categoryName = categoryName;
            _instanceName = instanceName;
        }

        private bool IsInstanceNameValid(String instanceName)
        {
            if (instanceName == "")
            {
                MessageBox.Show(@"Instance Name cant be empty", @"Fill name", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            using (var db = new DbCtx())
            {
                if (db.GetInstanceNames().Contains(instanceName))
                {
                    MessageBox.Show(@"You cant create category!", @"Exists!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }

            return true;
        }

        private bool CanUserCreateInstance(string categoryName)
        {
            if (!_loggedIn.CanCreateInstance(categoryName))
            {
                MessageBox.Show(@"You cant create instance!", @"NO PERMISSION", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public bool CanUserDeleteInstance(String instanceName)
        {
            if (!_loggedIn.CanDeleteInstance(instanceName))
            {
                MessageBox.Show(@"You cant delete instance!", @"NO PERMISSION", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public bool CreateInstance(string categoryName, String instanceName)
        {
            if (!CanUserCreateInstance(categoryName))
            {
                return false;
            }

            if (!IsInstanceNameValid(instanceName))
            {
                return false;
            }

            return true;
        }

        public void MakeTree(TreeNode node)
        {
            var nodeName = node.Text;
            using (var db = new DbCtx())
            {
                List<Property> childProperties = db.GetCategoryProperties(_instances[_instances.Count - 1].CategoryId);

                foreach (Property property in childProperties)
                {
                    _containers.Add(new Container(_instances[_instances.Count - 1].CategoryId, property.ElementId,
                        property.Name));
                }

                if (childProperties.Count == 0)
                {
                    _containers.Add(new Container(_instances[_instances.Count - 1].CategoryId, 0, null));
                }

                foreach (Property property in childProperties)
                {
                    _baseProperties.Add(new List<InsBaseProperty>());

                    _instances.Add(new Instance()
                    {
                        Name = property.Name,
                        Maker = _loggedIn.User.Id,
                        CategoryId = property.ElementId
                    });

                    foreach (BaseProperty bp in db.GetCategoryBaseProperties(
                                 _instances[_instances.Count - 1].CategoryId))
                    {
                        _baseProperties[_instances.Count - 1].Add(new InsBaseProperty()
                        {
                            Type = bp.Type,
                            InstanceId = bp.CategoryId,
                            Name = bp.Name,
                            Value = ""
                        });
                    }

                    node.Nodes.Add(_instances.Count - 1 + "." + property.Name);
                    MakeTree(node.Nodes[node.Nodes.Count - 1]);
                }
            }
        }

        public TreeView ShowTree(TreeView treeView)
        {
            _myTree = treeView;

            _myTree.Nodes.Clear();

            using (var db = new DbCtx())
            {
                _baseProperties.Add(new List<InsBaseProperty>());

                _instances.Add(new Instance()
                {
                    Name = _instanceName,
                    Maker = _loggedIn.User.Id,
                    CategoryId = db.GetCategory(_categoryName).CategoryId
                });

                foreach (BaseProperty property in
                         db.GetCategoryBaseProperties(db.GetCategory(_categoryName).CategoryId))
                {
                    _baseProperties[_instances.Count - 1].Add(new InsBaseProperty()
                    {
                        Type = property.Type,
                        InstanceId = property.CategoryId,
                        Name = property.Name,
                        Value = ""
                    });
                }
            }

            _myTree.Nodes.Add("0." + _instanceName);

            MakeTree(_myTree.Nodes[0]);

            _myTree.ExpandAll();

            return _myTree;
        }

        public void DataToShow(string selectedNodeText)
        {
            int id = int.Parse(selectedNodeText.Split('.')[0]);
            string name = selectedNodeText.Split('.')[1];
            currentIndex = id;
        }

        public ComboBox GetComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("");
            foreach (InsBaseProperty insBaseProperty in _baseProperties[currentIndex])
            {
                comboBox.Items.Add("(" + insBaseProperty.Type + ")." + insBaseProperty.Name);
            }

            comboBox.SelectedIndex = 0;
            return comboBox;
        }

        public bool Apply(string name, String value)
        {
            if (value == "")
            {
                return false;
            }

            string exactName;
            try
            {
                exactName = name.Split('.')[1];
            } catch (Exception e)
            {
                return false;
            }


            foreach (InsBaseProperty insBaseProperty in _baseProperties[currentIndex]
                         .Where(insBaseProperty => insBaseProperty.Name == exactName))
            {
                switch (insBaseProperty.Type)
                {
                    case "Bool" when (value == "true" || value == "True" || value == "False" || value == "false"):
                        insBaseProperty.Value = value;
                        return true;
                    case "String":
                        insBaseProperty.Value = value;
                        return true;
                }

                if (insBaseProperty.Type != "Int") continue;

                try
                {
                    insBaseProperty.Value = int.Parse(value).ToString();
                    return true;
                } catch (Exception e)
                {
                    // Do nothing
                }
            }

            return false;
        }

        public bool AllFilled()
        {
            return _baseProperties.SelectMany(insBaseProperties => insBaseProperties)
                .All(insBaseProperty => insBaseProperty.Value != "");
        }

        public bool MakeInstance()
        {
            if (!CaclTooStrong())
            {
                return false;
            }

            ReFill();

            return true;
        }

        private bool CaclTooStrong()
        {
            using (var db = new DbCtx())
            {
                foreach (List<InsBaseProperty> insBaseProperties in _baseProperties)
                {
                    foreach (InsBaseProperty bProp in insBaseProperties)
                    {
                        var limit = db.Limits.Single(l =>
                            l.CategoryId == bProp.InstanceId && l.BasePropertyName == bProp.Name);
                        var categoryName = db.GetCategory(bProp.InstanceId).Name;

                        if (limit.MeansStronger)
                        {
                            foreach (var instance in db.InstancesOfCategory(categoryName))
                            {
                                var limit1 = limit;
                                var properties = db.InsBaseProperties.Where(bp =>
                                        bp.InstanceId == instance.InstanceId && bp.Name == limit1.BasePropertyName)
                                    .Select(bp => bp.Value);

                                foreach (string property in properties)
                                {
                                    if (int.Parse(property) < int.Parse(bProp.Value))
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return true;
        }

        public String GetValue(int selectedIndex)
        {
            return selectedIndex == 0 ? "" : _baseProperties[currentIndex][selectedIndex - 1].Value;
        }

        private void ReFill()
        {
            foreach (Instance instance in _instances)
            {
                using (var db = new DbCtx())
                {
                    db.Instances.Add(new Instance()
                    {
                        CategoryId = instance.CategoryId,
                        Name = instance.Name,
                        Maker = instance.Maker
                    });

                    db.SaveChanges();
                    var value = db.Instances.OrderByDescending(i => i.InstanceId).Take(1).Single();
                    foreach (Container container in _containers)
                    {
                        if (container.CategoryId == value.CategoryId)
                        {
                            container.DbInstanceId = value.InstanceId;
                        } else if (container.InstanceId == value.CategoryId)
                        {
                            container.DbElementId = value.InstanceId;
                        }
                    }
                }
            }

            foreach (Container container in _containers)
            {
                using (var db = new DbCtx())
                {
                    if (container.DbElementId != 0)
                    {
                        db.InsProperties.Add(new InsProperty()
                        {
                            ElementId = container.DbElementId,
                            InstanceId = container.DbInstanceId,
                            Name = container.Name
                        });
                    }

                    db.SaveChanges();
                }
            }

            foreach (List<InsBaseProperty> insBaseProperties in _baseProperties)
            {
                if (insBaseProperties.Count == 0)
                {
                    continue;
                }

                var descriminator = insBaseProperties[0].InstanceId;
                var inBase = GetBaseId(descriminator);

                foreach (InsBaseProperty insBaseProperty in insBaseProperties)
                {
                    using (var db = new DbCtx())
                    {
                        db.InsBaseProperties.Add(new InsBaseProperty()
                        {
                            Type = insBaseProperty.Type,
                            Name = insBaseProperty.Name,
                            Value = insBaseProperty.Value,
                            InstanceId = inBase
                        });

                        db.SaveChanges();
                    }
                }
            }
        }

        private int GetBaseId(int descriminator)
        {
            foreach (Container container in _containers)
            {
                if (container.CategoryId == descriminator)
                {
                    return container.DbInstanceId;
                }

                if (container.InstanceId == descriminator)
                {
                    return container.DbElementId;
                }
            }

            return 0;
        }
    }

    public class Container
    {
        public Container(int categoryId, int instanceId, string name)
        {
            CategoryId = categoryId;
            InstanceId = instanceId;
            Name = name;
        }

        public int CategoryId { get; set; }
        public int InstanceId { get; set; }
        public int DbInstanceId { get; set; }
        public int DbElementId { get; set; }
        public String Name { get; set; }
    }
}