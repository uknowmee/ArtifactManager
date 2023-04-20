using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class NewUser
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxRoleName = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.labelAccountNick = new System.Windows.Forms.Label();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.comboBoxRoleName);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.labelNewPass);
            this.panel1.Controls.Add(this.labelRoleName);
            this.panel1.Controls.Add(this.labelAccountNick);
            this.panel1.Controls.Add(this.textBoxNewPass2);
            this.panel1.Controls.Add(this.textBoxNewPass1);
            this.panel1.Controls.Add(this.textBoxNick);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonClear.Location = new System.Drawing.Point(441, 249);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 36);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxRoleName
            // 
            this.comboBoxRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxRoleName.FormattingEnabled = true;
            this.comboBoxRoleName.Location = new System.Drawing.Point(303, 112);
            this.comboBoxRoleName.Name = "comboBoxRoleName";
            this.comboBoxRoleName.Size = new System.Drawing.Size(269, 30);
            this.comboBoxRoleName.TabIndex = 35;
            this.comboBoxRoleName.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoleName_SelectedIndexChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(303, 249);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(132, 36);
            this.buttonApply.TabIndex = 34;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheck.Location = new System.Drawing.Point(164, 249);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(134, 36);
            this.buttonCheck.TabIndex = 33;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelNewPass
            // 
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelNewPass.Location = new System.Drawing.Point(165, 184);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(133, 23);
            this.labelNewPass.TabIndex = 32;
            this.labelNewPass.Text = "New Pass";
            this.labelNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoleName
            // 
            this.labelRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelRoleName.Location = new System.Drawing.Point(165, 113);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(133, 23);
            this.labelRoleName.TabIndex = 29;
            this.labelRoleName.Text = "Role Name";
            this.labelRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccountNick
            // 
            this.labelAccountNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAccountNick.Location = new System.Drawing.Point(164, 150);
            this.labelAccountNick.Name = "labelAccountNick";
            this.labelAccountNick.Size = new System.Drawing.Size(133, 23);
            this.labelAccountNick.TabIndex = 28;
            this.labelAccountNick.Text = "Account Nick";
            this.labelAccountNick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass2.Location = new System.Drawing.Point(303, 215);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(269, 28);
            this.textBoxNewPass2.TabIndex = 27;
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass1.Location = new System.Drawing.Point(303, 181);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.PasswordChar = '*';
            this.textBoxNewPass1.Size = new System.Drawing.Size(269, 28);
            this.textBoxNewPass1.TabIndex = 26;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNick.Location = new System.Drawing.Point(303, 147);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(269, 28);
            this.textBoxNick.TabIndex = 22;
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
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.Resize += new System.EventHandler(this.NewUser_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Label labelAccountNick;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.ComboBox comboBoxRoleName;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}