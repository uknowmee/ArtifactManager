using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class NewRole
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSaveRole = new System.Windows.Forms.Button();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.buttonDeletePermission = new System.Windows.Forms.Button();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.comboBoxAddPermissions = new System.Windows.Forms.ComboBox();
            this.comboBoxDeletePermission = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonSaveRole);
            this.panel1.Controls.Add(this.buttonCheckAvailability);
            this.panel1.Controls.Add(this.buttonDeletePermission);
            this.panel1.Controls.Add(this.buttonAddPermission);
            this.panel1.Controls.Add(this.comboBoxAddPermissions);
            this.panel1.Controls.Add(this.comboBoxDeletePermission);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.labelRoleName);
            this.panel1.Controls.Add(this.textBoxRoleName);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonReset.Location = new System.Drawing.Point(671, 238);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 50);
            this.buttonReset.TabIndex = 41;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSaveRole
            // 
            this.buttonSaveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonSaveRole.Location = new System.Drawing.Point(12, 251);
            this.buttonSaveRole.Name = "buttonSaveRole";
            this.buttonSaveRole.Size = new System.Drawing.Size(167, 37);
            this.buttonSaveRole.TabIndex = 40;
            this.buttonSaveRole.Text = "Save Role";
            this.buttonSaveRole.UseVisualStyleBackColor = true;
            this.buttonSaveRole.Click += new System.EventHandler(this.buttonSaveRole_Click);
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheckAvailability.Location = new System.Drawing.Point(12, 208);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(167, 37);
            this.buttonCheckAvailability.TabIndex = 39;
            this.buttonCheckAvailability.Text = "Check Availability";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            this.buttonCheckAvailability.Click += new System.EventHandler(this.buttonCheckAvailability_Click);
            // 
            // buttonDeletePermission
            // 
            this.buttonDeletePermission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeletePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDeletePermission.Location = new System.Drawing.Point(12, 57);
            this.buttonDeletePermission.Name = "buttonDeletePermission";
            this.buttonDeletePermission.Size = new System.Drawing.Size(167, 43);
            this.buttonDeletePermission.TabIndex = 38;
            this.buttonDeletePermission.Text = "Delete Permission";
            this.buttonDeletePermission.UseVisualStyleBackColor = true;
            this.buttonDeletePermission.Click += new System.EventHandler(this.buttonDeletePermission_Click);
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonAddPermission.Location = new System.Drawing.Point(12, 12);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(167, 44);
            this.buttonAddPermission.TabIndex = 37;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // comboBoxAddPermissions
            // 
            this.comboBoxAddPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxAddPermissions.FormattingEnabled = true;
            this.comboBoxAddPermissions.ItemHeight = 16;
            this.comboBoxAddPermissions.Location = new System.Drawing.Point(185, 26);
            this.comboBoxAddPermissions.Name = "comboBoxAddPermissions";
            this.comboBoxAddPermissions.Size = new System.Drawing.Size(603, 24);
            this.comboBoxAddPermissions.TabIndex = 35;
            // 
            // comboBoxDeletePermission
            // 
            this.comboBoxDeletePermission.FormattingEnabled = true;
            this.comboBoxDeletePermission.Location = new System.Drawing.Point(185, 68);
            this.comboBoxDeletePermission.Name = "comboBoxDeletePermission";
            this.comboBoxDeletePermission.Size = new System.Drawing.Size(603, 24);
            this.comboBoxDeletePermission.TabIndex = 17;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelDescription.Location = new System.Drawing.Point(12, 162);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(167, 23);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxDescription.Location = new System.Drawing.Point(185, 164);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(466, 124);
            this.textBoxDescription.TabIndex = 15;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelRoleName
            // 
            this.labelRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelRoleName.Location = new System.Drawing.Point(12, 122);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(167, 23);
            this.labelRoleName.TabIndex = 14;
            this.labelRoleName.Text = "Role Name";
            this.labelRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxRoleName.Location = new System.Drawing.Point(185, 119);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(165, 28);
            this.textBoxRoleName.TabIndex = 13;
            this.textBoxRoleName.TextChanged += new System.EventHandler(this.textBoxRoleName_TextChanged);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonQuit.Location = new System.Drawing.Point(671, 388);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 50);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // NewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NewRole";
            this.Text = "NewRole";
            this.Load += new System.EventHandler(this.NewRole_Load);
            this.Resize += new System.EventHandler(this.NewRole_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSaveRole;
        private System.Windows.Forms.Button buttonCheckAvailability;
        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Button buttonDeletePermission;

        private System.Windows.Forms.ComboBox comboBoxAddPermissions;
        private System.Windows.Forms.Button buttonAddPermission;

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxDeletePermission;

        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.TextBox textBoxRoleName;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}