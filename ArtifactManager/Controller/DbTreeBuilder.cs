using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public static class DbTreeBuilder
    {
        private static TreeView _myTree;
        private static List<Category> _categories;

        private static void BuildTree(TreeNode node)
        {
            var nodeName = node.Text;
            using (var db = new DbCtx())
            {
                List<String> childNames = db.GetSubCategoriesNames(nodeName);
                foreach (String categoryName in childNames)
                {
                    node.Nodes.Add(categoryName);
                    if (node.Nodes.Count - 1 >= 0)
                    {
                        BuildTree(node.Nodes[node.Nodes.Count - 1]);
                    }
                }
            }
        }

        public static TreeView MakeTree(TreeView treeView)
        {
            _myTree = treeView;

            _myTree.Nodes.Clear();

            _myTree.Nodes.Add(DbGenerator.RootCategory);

            BuildTree(_myTree.Nodes[0]);

            _myTree.ExpandAll();

            return _myTree;
        }
        
        public static List<Category> MakeChildCategories(int categoryId)
        {
            _categories = new List<Category>();

            using (var db = new DbCtx())
            {
                BuildChildCategories(db.GetCategory(categoryId).Name);
            }

            return _categories;
        }
        
        public static List<Category> MakeChildCategories(String categoryName)
        {
            _categories = new List<Category>();

            using (var db = new DbCtx())
            {
                BuildChildCategories(categoryName);
            }

            return _categories;
        }
        
        public static List<Category> MakeParentCategories(string categoryName)
        {
            _categories = new List<Category>();

            BuildParentCategories(categoryName);
            
            return _categories;
        }
        
        private static void BuildChildCategories(String categoryName)
        {
            using (var db = new DbCtx())
            {
                List<String> childNames = db.GetSubCategoriesNames(categoryName);
                foreach (String subCategoryName in childNames)
                {
                    if (childNames.Count - 1 >= 0)
                    {
                        BuildChildCategories(subCategoryName);
                    }
                    _categories.Add(db.GetCategory(subCategoryName));
                }
            }
        }
        
        private static void BuildParentCategories(String categoryName)
        {
            using (var db = new DbCtx())
            {
                Category category = db.GetParentCategory(categoryName);

                if (category != null)
                {
                    BuildParentCategories(category.Name);
                    _categories.Add(category);
                }
            }
        }
    }
}