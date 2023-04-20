using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditMyProfile = new System.Windows.Forms.Button();
            this.buttonEditPermission = new System.Windows.Forms.Button();
            this.buttonEditRole = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonNewPermission = new System.Windows.Forms.Button();
            this.buttonNewRole = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonQuit.Location = new System.Drawing.Point(671, 388);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 50);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditMyProfile);
            this.panel1.Controls.Add(this.buttonEditPermission);
            this.panel1.Controls.Add(this.buttonEditRole);
            this.panel1.Controls.Add(this.buttonEditUser);
            this.panel1.Controls.Add(this.buttonNewPermission);
            this.panel1.Controls.Add(this.buttonNewRole);
            this.panel1.Controls.Add(this.buttonNewUser);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // buttonEditMyProfile
            // 
            this.buttonEditMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditMyProfile.Location = new System.Drawing.Point(12, 264);
            this.buttonEditMyProfile.Name = "buttonEditMyProfile";
            this.buttonEditMyProfile.Size = new System.Drawing.Size(139, 36);
            this.buttonEditMyProfile.TabIndex = 10;
            this.buttonEditMyProfile.Text = "Edit My Profile";
            this.buttonEditMyProfile.UseVisualStyleBackColor = true;
            this.buttonEditMyProfile.Click += new System.EventHandler(this.buttonEditMyProfile_Click);
            // 
            // buttonEditPermission
            // 
            this.buttonEditPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditPermission.Location = new System.Drawing.Point(12, 222);
            this.buttonEditPermission.Name = "buttonEditPermission";
            this.buttonEditPermission.Size = new System.Drawing.Size(139, 36);
            this.buttonEditPermission.TabIndex = 9;
            this.buttonEditPermission.Text = "Edit Permission";
            this.buttonEditPermission.UseVisualStyleBackColor = true;
            this.buttonEditPermission.Click += new System.EventHandler(this.buttonEditPermission_Click);
            // 
            // buttonEditRole
            // 
            this.buttonEditRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditRole.Location = new System.Drawing.Point(12, 180);
            this.buttonEditRole.Name = "buttonEditRole";
            this.buttonEditRole.Size = new System.Drawing.Size(139, 36);
            this.buttonEditRole.TabIndex = 8;
            this.buttonEditRole.Text = "Edit Role";
            this.buttonEditRole.UseVisualStyleBackColor = true;
            this.buttonEditRole.Click += new System.EventHandler(this.buttonEditRole_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditUser.Location = new System.Drawing.Point(12, 138);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(139, 36);
            this.buttonEditUser.TabIndex = 7;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonNewPermission
            // 
            this.buttonNewPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonNewPermission.Location = new System.Drawing.Point(12, 96);
            this.buttonNewPermission.Name = "buttonNewPermission";
            this.buttonNewPermission.Size = new System.Drawing.Size(139, 36);
            this.buttonNewPermission.TabIndex = 6;
            this.buttonNewPermission.Text = "New Permission";
            this.buttonNewPermission.UseVisualStyleBackColor = true;
            this.buttonNewPermission.Click += new System.EventHandler(this.buttonNewPermission_Click);
            // 
            // buttonNewRole
            // 
            this.buttonNewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonNewRole.Location = new System.Drawing.Point(12, 54);
            this.buttonNewRole.Name = "buttonNewRole";
            this.buttonNewRole.Size = new System.Drawing.Size(139, 36);
            this.buttonNewRole.TabIndex = 5;
            this.buttonNewRole.Text = "New Role";
            this.buttonNewRole.UseVisualStyleBackColor = true;
            this.buttonNewRole.Click += new System.EventHandler(this.buttonNewRole_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonNewUser.Location = new System.Drawing.Point(12, 12);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(139, 36);
            this.buttonNewUser.TabIndex = 4;
            this.buttonNewUser.Text = "New User";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.Resize += new System.EventHandler(this.AdminPanel_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonEditMyProfile;

        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonNewRole;
        private System.Windows.Forms.Button buttonNewPermission;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonEditRole;
        private System.Windows.Forms.Button buttonEditPermission;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button buttonQuit;

        #endregion

    }
}