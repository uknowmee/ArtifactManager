using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class EditRoleView
    {
        public static ComboBox ShowRoleNames(ComboBox cmbOldRoleName)
        {
            cmbOldRoleName.Items.Clear();

            using (var db = new DbCtx())
            {
                foreach (Role role in db.GetRoles())
                {
                    if (role.RolePanelType != DbGenerator.DefAdminPass &&
                        role.RolePanelType != DbGenerator.DefGuestPass)
                    {
                        cmbOldRoleName.Items.Add(role.Name);
                    }
                }
            }

            return cmbOldRoleName;
        }
    }
}