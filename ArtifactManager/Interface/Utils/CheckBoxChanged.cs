using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Interface.Utils
{
    public static class CheckBoxChanged
    {
        public static CheckBox CheckPreviousState(bool dontChange, CheckBox checkBox)
        {
            if (dontChange) return checkBox;

            checkBox.Checked = !checkBox.Checked;

            return checkBox;
        }

        public static CheckBox AdminProfileEdited(string nick, string roleName, string roleDescription, string oldPass,
            string newPass1, string newPass2, LoggedAdmin admin, CheckBox checkBox)
        {
            checkBox.Checked = admin.IsMyDataChanged(nick, roleName, roleDescription, oldPass, newPass1, newPass2);

            return checkBox;
        }

        public static CheckBox PermissionEdited(Permission permission1, ComboBox comboBoxPermission,
            List<Permission> permissions, CheckBox checkBox)
        {
            Permission permission2 = permissions[comboBoxPermission.SelectedIndex];

            checkBox.Checked = !DbObjectCompare.PermissionCompare(permission1, permission2);

            return checkBox;
        }
    }
}