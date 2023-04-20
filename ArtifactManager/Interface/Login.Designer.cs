using System.ComponentModel;

namespace ArtifactManager.Interface
{
    partial class Login
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
            this.listBoxChanges = new System.Windows.Forms.ListBox();
            this.listBoxInstances = new System.Windows.Forms.ListBox();
            this.buttonChangesMore = new System.Windows.Forms.Button();
            this.buttonChangesLess = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelAccInfo = new System.Windows.Forms.Label();
            this.comboBoxNick = new System.Windows.Forms.ComboBox();
            this.buttonInstancesLess = new System.Windows.Forms.Button();
            this.buttonInstancesMore = new System.Windows.Forms.Button();
            this.labelInstanceInfo = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInstance = new System.Windows.Forms.Label();
            this.labelChanges = new System.Windows.Forms.Label();
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
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // listBoxChanges
            // 
            this.listBoxChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.listBoxChanges.FormattingEnabled = true;
            this.listBoxChanges.ItemHeight = 22;
            this.listBoxChanges.Location = new System.Drawing.Point(13, 84);
            this.listBoxChanges.Name = "listBoxChanges";
            this.listBoxChanges.Size = new System.Drawing.Size(203, 290);
            this.listBoxChanges.TabIndex = 3;
            // 
            // listBoxInstances
            // 
            this.listBoxInstances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.listBoxInstances.FormattingEnabled = true;
            this.listBoxInstances.ItemHeight = 22;
            this.listBoxInstances.Location = new System.Drawing.Point(225, 84);
            this.listBoxInstances.Name = "listBoxInstances";
            this.listBoxInstances.Size = new System.Drawing.Size(208, 290);
            this.listBoxInstances.TabIndex = 4;
            // 
            // buttonChangesMore
            // 
            this.buttonChangesMore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangesMore.Location = new System.Drawing.Point(126, 55);
            this.buttonChangesMore.Name = "buttonChangesMore";
            this.buttonChangesMore.Size = new System.Drawing.Size(75, 23);
            this.buttonChangesMore.TabIndex = 5;
            this.buttonChangesMore.Text = "More";
            this.buttonChangesMore.UseVisualStyleBackColor = true;
            this.buttonChangesMore.Click += new System.EventHandler(this.buttonChangesMore_Click);
            // 
            // buttonChangesLess
            // 
            this.buttonChangesLess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangesLess.Location = new System.Drawing.Point(45, 55);
            this.buttonChangesLess.Name = "buttonChangesLess";
            this.buttonChangesLess.Size = new System.Drawing.Size(75, 23);
            this.buttonChangesLess.TabIndex = 6;
            this.buttonChangesLess.Text = "Less";
            this.buttonChangesLess.UseVisualStyleBackColor = true;
            this.buttonChangesLess.Click += new System.EventHandler(this.buttonChangesLess_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxPass.Location = new System.Drawing.Point(534, 103);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(147, 34);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonLogin.Location = new System.Drawing.Point(552, 143);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(116, 50);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelAccInfo
            // 
            this.labelAccInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAccInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAccInfo.Location = new System.Drawing.Point(617, 196);
            this.labelAccInfo.Name = "labelAccInfo";
            this.labelAccInfo.Size = new System.Drawing.Size(171, 180);
            this.labelAccInfo.TabIndex = 10;
            // 
            // comboBoxNick
            // 
            this.comboBoxNick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxNick.FormattingEnabled = true;
            this.comboBoxNick.Location = new System.Drawing.Point(510, 47);
            this.comboBoxNick.Name = "comboBoxNick";
            this.comboBoxNick.Size = new System.Drawing.Size(195, 50);
            this.comboBoxNick.TabIndex = 11;
            this.comboBoxNick.SelectedIndexChanged += new System.EventHandler(this.comboBoxNick_SelectedIndexChanged);
            // 
            // buttonInstancesLess
            // 
            this.buttonInstancesLess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInstancesLess.Location = new System.Drawing.Point(260, 55);
            this.buttonInstancesLess.Name = "buttonInstancesLess";
            this.buttonInstancesLess.Size = new System.Drawing.Size(75, 23);
            this.buttonInstancesLess.TabIndex = 12;
            this.buttonInstancesLess.Text = "Less";
            this.buttonInstancesLess.UseVisualStyleBackColor = true;
            this.buttonInstancesLess.Click += new System.EventHandler(this.buttonInstancesLess_Click);
            // 
            // buttonInstancesMore
            // 
            this.buttonInstancesMore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInstancesMore.Location = new System.Drawing.Point(341, 55);
            this.buttonInstancesMore.Name = "buttonInstancesMore";
            this.buttonInstancesMore.Size = new System.Drawing.Size(75, 23);
            this.buttonInstancesMore.TabIndex = 13;
            this.buttonInstancesMore.Text = "More";
            this.buttonInstancesMore.UseVisualStyleBackColor = true;
            this.buttonInstancesMore.Click += new System.EventHandler(this.buttonInstancesMore_Click);
            // 
            // labelInstanceInfo
            // 
            this.labelInstanceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInstanceInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInstanceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelInstanceInfo.Location = new System.Drawing.Point(440, 196);
            this.labelInstanceInfo.Name = "labelInstanceInfo";
            this.labelInstanceInfo.Size = new System.Drawing.Size(171, 180);
            this.labelInstanceInfo.TabIndex = 14;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(260, 10);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(156, 39);
            this.comboBoxCategory.TabIndex = 15;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelInstance);
            this.panel1.Controls.Add(this.labelChanges);
            this.panel1.Controls.Add(this.listBoxInstances);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.labelInstanceInfo);
            this.panel1.Controls.Add(this.buttonInstancesMore);
            this.panel1.Controls.Add(this.comboBoxNick);
            this.panel1.Controls.Add(this.listBoxChanges);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.buttonChangesLess);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonInstancesLess);
            this.panel1.Controls.Add(this.labelAccInfo);
            this.panel1.Controls.Add(this.buttonChangesMore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 16;
            // 
            // labelInstance
            // 
            this.labelInstance.Location = new System.Drawing.Point(225, 55);
            this.labelInstance.Name = "labelInstance";
            this.labelInstance.Size = new System.Drawing.Size(26, 22);
            this.labelInstance.TabIndex = 17;
            this.labelInstance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChanges
            // 
            this.labelChanges.Location = new System.Drawing.Point(13, 55);
            this.labelChanges.Name = "labelChanges";
            this.labelChanges.Size = new System.Drawing.Size(26, 22);
            this.labelChanges.TabIndex = 16;
            this.labelChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelChanges;
        private System.Windows.Forms.Label labelInstance;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ComboBox comboBoxCategory;

        private System.Windows.Forms.Label labelInstanceInfo;

        private System.Windows.Forms.ComboBox comboBoxNick;
        private System.Windows.Forms.Button buttonInstancesLess;
        private System.Windows.Forms.Button buttonInstancesMore;

        private System.Windows.Forms.Button buttonChangesMore;
        private System.Windows.Forms.Button buttonChangesLess;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelAccInfo;

        private System.Windows.Forms.ListBox listBoxChanges;
        private System.Windows.Forms.ListBox listBoxInstances;

        private System.Windows.Forms.Button buttonQuit;

        #endregion

    }
}