using System.ComponentModel;

namespace ArtifactManager.Interface.User
{
    partial class EditMyPassword
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
            this.labelOldPass = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelOldPass);
            this.panel1.Controls.Add(this.textBoxOldPass);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.labelNewPass);
            this.panel1.Controls.Add(this.textBoxNewPass2);
            this.panel1.Controls.Add(this.textBoxNewPass1);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // labelOldPass
            // 
            this.labelOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelOldPass.Location = new System.Drawing.Point(172, 129);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(133, 23);
            this.labelOldPass.TabIndex = 56;
            this.labelOldPass.Text = "Old Pass";
            this.labelOldPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxOldPass.Location = new System.Drawing.Point(311, 129);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(271, 28);
            this.textBoxOldPass.TabIndex = 55;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(449, 231);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(132, 36);
            this.buttonApply.TabIndex = 54;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheck.Location = new System.Drawing.Point(311, 230);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(132, 36);
            this.buttonCheck.TabIndex = 53;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelNewPass
            // 
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelNewPass.Location = new System.Drawing.Point(172, 166);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(133, 23);
            this.labelNewPass.TabIndex = 52;
            this.labelNewPass.Text = "New Pass";
            this.labelNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass2.Location = new System.Drawing.Point(311, 197);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(271, 28);
            this.textBoxNewPass2.TabIndex = 51;
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxNewPass1.Location = new System.Drawing.Point(311, 163);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.PasswordChar = '*';
            this.textBoxNewPass1.Size = new System.Drawing.Size(271, 28);
            this.textBoxNewPass1.TabIndex = 50;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonQuit.Location = new System.Drawing.Point(671, 388);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 50);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // EditMyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditMyPassword";
            this.Text = "EditMyPassword";
            this.Load += new System.EventHandler(this.EditMyPassword_Load);
            this.Resize += new System.EventHandler(this.EditMyPassword_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Label labelOldPass;

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.TextBox textBoxNewPass1;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}