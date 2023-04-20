using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class NewUserView
    {
        public static ComboBox GetRoleNames(ComboBox comboBoxRoleName)
        {
            comboBoxRoleName.Items.Clear();

            using (var db = new DbCtx())
            {
                foreach (Role role in db.GetRolesNoAdminGuestGod())
                {
                    if (role.RolePanelType != DbGenerator.DefGodPass)
                    {
                        comboBoxRoleName.Items.Add(role.Name);
                    }
                }
            }
            
            return comboBoxRoleName;
        }
    }
}