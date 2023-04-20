using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;
using ArtifactManager.Interface.Admin;
using ArtifactManager.Interface.User;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class LoginView
    {
        public static ListBox ChangesLoad(int changesNum, ListBox listBoxChanges)
        {
            listBoxChanges.Items.Clear();

            using (var db = new DbCtx())
            {
                var changes = db.LastFewModified(changesNum);

                foreach (Modified modified in changes)
                {
                    listBoxChanges.Items.Add(modified.ToString());
                }
            }

            return listBoxChanges;
        }

        public static ComboBox ExistingInstancesCategories(ComboBox comboBoxCategory)
        {
            comboBoxCategory.Items.Clear();

            using (var db = new DbCtx())
            {
                foreach (string categoryName in db.CategoryNamesOfExistingInstances())
                {
                    comboBoxCategory.Items.Add(categoryName);
                }
            }

            return comboBoxCategory;
        }

        public static ComboBox Nicks(ComboBox comboBoxNick)
        {
            comboBoxNick.Items.Clear();

            using (var db = new DbCtx())
            {
                foreach (var userNick in db.UserNicks())
                {
                    comboBoxNick.Items.Add(userNick);
                }
            }

            comboBoxNick.SelectedIndex = 0;

            return comboBoxNick;
        }

        public static Label AccInfo(string nick, Label labelAccInfo)
        {
            labelAccInfo.Text = "";

            using (var db = new DbCtx())
            {
                var user = db.GetUser(nick);
                var userRole = db.UserRole(user.RoleId);

                const String beforeNickname = "Account login - ";
                const string space = ":\n\n";

                labelAccInfo.Text = beforeNickname + user.Nick + space + userRole;
            }

            return labelAccInfo;
        }

        public static List<Instance> Instances(string categoryName, int instancesNum)
        {
            using (var db = new DbCtx())
            {
                return SortInstance.SortedInstancesOfCategory(db.InstancesOfCategory(categoryName), instancesNum);
            }
        }

        public static ListBox InstancesShow(List<Instance> instances, ListBox listBoxInstances)
        {
            listBoxInstances.Items.Clear();
            
            foreach (Instance instance in instances)
            {
                listBoxInstances.Items.Add(instance);
            }

            return listBoxInstances;
        }

        public static Label InstanceInfo(List<Instance> instance, Label labelInstanceInfo)
        {
            labelInstanceInfo.Text = "";

            if (instance.Count != 0)
            {
                labelInstanceInfo.Text = CatInsInfo.LoginCategoryInfo(instance[0].CategoryId);
            }
            
            return labelInstanceInfo;
        }
        
        public static Label InstanceInfo(String categoryName, String instanceName, Label labelInstanceInfo)
        {
            labelInstanceInfo.Text = "";

            if (instanceName != "")
            {
                labelInstanceInfo.Text = CatInsInfo.InstanceInfo(categoryName, instanceName);
            }
            
            return labelInstanceInfo;
        }

        public static void PerformLogin(Login login, string nick)
        {
            LoggedIn loggedIn = new LoggedIn(nick);

            switch (loggedIn.Role.RolePanelType)
            {
                case DbGenerator.DefAdminPass:
                    new AdminPanel(login, new LoggedAdmin(nick)).Show();
                    break;
                case DbGenerator.DefGuestPass:
                    new GuestPanel(login, loggedIn).Show();
                    break;
                default:
                    new UserPanel(login, loggedIn).Show();
                    break;
            }
        }
    }
}