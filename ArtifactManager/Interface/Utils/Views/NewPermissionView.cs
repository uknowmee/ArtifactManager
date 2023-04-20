using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class NewPermissionView
    {

        public static ComboBox CategoriesToPermissionMake(ComboBox comboBoxCategories)
        {
            using (var db = new DbCtx())
            {
                comboBoxCategories.Items.Clear();

                comboBoxCategories.Items.Add("All");

                foreach (Category category in db.GetCategories())
                {
                    comboBoxCategories.Items.Add(category.Name);
                }

                comboBoxCategories.SelectedIndex = 0;
                
                return comboBoxCategories;
            }
        }

        public static bool IsPermissionValid(LoggedAdmin loggedIn, bool add, bool delete, bool edit, bool make,
            bool kill, string categoryName)
        {
            if (!loggedIn.IsNewPermissionValid(add, delete, edit, make, kill, categoryName))
            {
                MessageBox.Show(@"Specified Permission Already exists!", @"INFO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show(@"You can create specified permission!", @"INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }
    }
}