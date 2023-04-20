using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public class DbUserBuilder
    {
        public List<Role> Roles { get; private set; }

        public List<Role> UserRoles { get; private set; }

        public string Nick { get; private set; }

        private Role _role;
        private String _password1;
        private String _password2;
        private User _user;

        public DbUserBuilder(String userNick)
        {
            FreshUserBuilder(userNick);
        }

        private void FreshUserBuilder(String userNick)
        {
            if (userNick == "") return;

            using (var db = new DbCtx())
            {
                UserRoles = db.GetUserRole(userNick);
                Roles = db.GetRolesWithoutUserRole(UserRoles[0]);
                Nick = userNick;

                _user = db.GetUser(userNick);
            }
        }

        public void Update(ComboBox comboBoxRoleName, TextBox textBoxNick, TextBox textBoxNewPass1,
            TextBox textBoxNewPass2)
        {
            if (comboBoxRoleName.Text == "") return;

            Nick = textBoxNick.Text;
            _password1 = textBoxNewPass1.Text;
            _password2 = textBoxNewPass2.Text;
            using (var db = new DbCtx())
            {
                _role = db.GetRole(comboBoxRoleName.Text);
            }
        }

        public bool IsAvailable(string roleName, string oldUserNick)
        {
            if (roleName == "")
            {
                MessageBox.Show(@"No Role selected", @"Select a role!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (Nick == "")
            {
                MessageBox.Show(@"Nick cant be empty!", @"DEFINE NICK", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            
            using (var db = new DbCtx())
            {
                if (db.UserNicks().Contains(Nick) && Nick != oldUserNick)
                {
                    MessageBox.Show(@"User already exists!", @"Change User Name!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (_password1 == "" || _password2 == "")
                {
                    MessageBox.Show(@"Passwords cant be empty!", @"Change User password!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                
                if (_password1 != _password2)
                {
                    MessageBox.Show(@"Passwords arent same!", @"Change User password!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
        }

        public bool CreateUser(string roleName)
        {
            var dialog = MessageBox.Show(@"Do you really want to create a user?", @"Proceed creation?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No)
            {
                return false;
            }

            if (!IsAvailable(roleName, ""))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                db.AddUser(Nick, new PassHash(_password1), _role.Name);
            }

            return true;
        }

        public bool UserCompare(string oldUserNick)
        {
            User oldUser;
            
            using (var db = new DbCtx())
            {
                oldUser = db.GetUser(oldUserNick);
            }

            User newUser = new User()
            {
                Nick = this.Nick,
                Password = new PassHash(this._password1, oldUser.Salt).Password,
                RoleId = this._role.RoleId
            };

            return DbObjectCompare.UserCompare(oldUser, newUser);
        }

        public void UpdateUser(string oldNick)
        {
            using (var db = new DbCtx())
            {
                db.UpdateUser(oldNick, Nick, new PassHash(_password1), _role.Name);
            }
        }

        public void DeleteUser(string nick)
        {
            using (var db = new DbCtx())
            {
                string rolePanelType = db.GetUserRole(nick)[0].RolePanelType;
                
                if (rolePanelType == DbGenerator.DefGodPass)
                {
                    MessageBox.Show(@"You cant delete God user!", @"NO PERMISSION", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                
                if (rolePanelType == DbGenerator.DefGuestPass)
                {
                    MessageBox.Show(@"You cant delete Guest user!", @"NO PERMISSION", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            using (var db = new DbCtx())
            {
                db.DeleteUser(nick);
            }
        }
    }
}