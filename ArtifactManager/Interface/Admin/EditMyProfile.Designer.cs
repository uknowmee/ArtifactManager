using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class EditMyProfile
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
            this.checkBoxSaved = new System.Windows.Forms.CheckBox();
            this.checkBoxChanged = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.labelAccountNick = new System.Windows.Forms.Label();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSaved);
            this.panel1.Controls.Add(this.checkBoxChanged);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.labelNewPass);
            this.panel1.Controls.Add(this.labelOldPass);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelRoleName);
            this.panel1.Controls.Add(this.labelAccountNick);
            this.panel1.Controls.Add(this.textBoxNewPass2);
            this.panel1.Controls.Add(this.textBoxNewPass1);
            this.panel1.Controls.Add(this.textBoxOldPass);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxRoleName);
            this.panel1.Controls.Add(this.textBoxNick);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSaved
            // 
            this.checkBoxSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxSaved.Location = new System.Drawing.Point(704, 253);
            this.checkBoxSaved.Name = "checkBoxSaved";
            this.checkBoxSaved.Size = new System.Drawing.Size(85, 36);
            this.checkBoxSaved.TabIndex = 21;
            this.checkBoxSaved.Text = "Saved";
            this.checkBoxSaved.UseVisualStyleBackColor = true;
            this.checkBoxSaved.Click += new System.EventHandler(this.checkBoxSaved_Click);
            // 
            // checkBoxChanged
            // 
            this.checkBoxChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxChanged.Location = new System.Drawing.Point(704, 211);
            this.checkBoxChanged.Name = "checkBoxChanged";
            this.checkBoxChanged.Size = new System.Drawing.Size(85, 36);
            this.checkBoxChanged.TabIndex = 20;
            this.checkBoxChanged.Text = "Changed";
            this.checkBoxChanged.UseVisualStyleBackColor = true;
            this.checkBoxChanged.Click += new System.EventHandler(this.checkBoxChanged_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(625, 253);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(73, 36);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheck.Location = new System.Drawing.Point(625, 211);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(71, 36);
            this.buttonCheck.TabIndex = 16;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelNewPass
            // 
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelNewPass.Location = new System.Drawing.Point(338, 139);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(109, 23);
            this.labelNewPass.TabIndex = 15;
            this.labelNewPass.Text = "New Pass";
            this.labelNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOldPass
            // 
            this.labelOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelOldPass.Location = new System.Drawing.Point(338, 98);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(109, 23);
            this.labelOldPass.TabIndex = 14;
            this.labelOldPass.Text = "Old Pass";
            this.labelOldPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelDescription.Location = new System.Drawing.Point(13, 178);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(133, 23);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoleName
            // 
            this.labelRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelRoleName.Location = new System.Drawing.Point(13, 138);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(133, 23);
            this.labelRoleName.TabIndex = 12;
            this.labelRoleName.Text = "Role Name";
            this.labelRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccountNick
            // 
            this.labelAccountNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAccountNick.Location = new System.Drawing.Point(13, 98);
            this.labelAccountNick.Name = "labelAccountNick";
            this.labelAccountNick.Size = new System.Drawing.Size(133, 23);
            this.labelAccountNick.TabIndex = 11;
            this.labelAccountNick.Text = "Account Nick";
            this.labelAccountNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass2.Location = new System.Drawing.Point(624, 133);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(165, 28);
            this.textBoxNewPass2.TabIndex = 10;
            this.textBoxNewPass2.TextChanged += new System.EventHandler(this.textBoxNewPass2_TextChanged);
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass1.Location = new System.Drawing.Point(453, 134);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.PasswordChar = '*';
            this.textBoxNewPass1.Size = new System.Drawing.Size(165, 28);
            this.textBoxNewPass1.TabIndex = 9;
            this.textBoxNewPass1.TextChanged += new System.EventHandler(this.textBoxNewPass1_TextChanged);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxOldPass.Location = new System.Drawing.Point(453, 95);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(165, 28);
            this.textBoxOldPass.TabIndex = 8;
            this.textBoxOldPass.TextChanged += new System.EventHandler(this.textBoxOldPass_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxDescription.Location = new System.Drawing.Point(152, 165);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(466, 124);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxRoleName.Location = new System.Drawing.Point(152, 133);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(165, 28);
            this.textBoxRoleName.TabIndex = 6;
            this.textBoxRoleName.TextChanged += new System.EventHandler(this.textBoxRoleName_TextChanged);
            // 
            // textBoxNick
            // 
            this.textBoxNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNick.Location = new System.Drawing.Point(152, 93);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(165, 28);
            this.textBoxNick.TabIndex = 5;
            this.textBoxNick.TextChanged += new System.EventHandler(this.textBoxNick_TextChanged);
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
            // EditMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditMyProfile";
            this.Text = "EditMyProfile";
            this.Load += new System.EventHandler(this.EditMyProfile_Load);
            this.Resize += new System.EventHandler(this.EditMyProfile_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBoxSaved;

        private System.Windows.Forms.CheckBox checkBoxChanged;

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonApply;

        private System.Windows.Forms.Label labelAccountNick;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewPass;

        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.TextBox textBoxNewPass2;

        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.TextBox textBoxDescription;

        private System.Windows.Forms.TextBox textBoxNick;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}