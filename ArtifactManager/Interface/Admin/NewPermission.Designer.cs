using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class NewPermission
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
            this.buttonSavePermission = new System.Windows.Forms.Button();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.checkBoxKillInstance = new System.Windows.Forms.CheckBox();
            this.checkBoxMakeInstance = new System.Windows.Forms.CheckBox();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.checkBoxAdd = new System.Windows.Forms.CheckBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSavePermission);
            this.panel1.Controls.Add(this.buttonCheckAvailability);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.checkBoxKillInstance);
            this.panel1.Controls.Add(this.checkBoxMakeInstance);
            this.panel1.Controls.Add(this.checkBoxEdit);
            this.panel1.Controls.Add(this.checkBoxDelete);
            this.panel1.Controls.Add(this.comboBoxCategories);
            this.panel1.Controls.Add(this.checkBoxAdd);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonSavePermission
            // 
            this.buttonSavePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonSavePermission.Location = new System.Drawing.Point(12, 320);
            this.buttonSavePermission.Name = "buttonSavePermission";
            this.buttonSavePermission.Size = new System.Drawing.Size(167, 50);
            this.buttonSavePermission.TabIndex = 27;
            this.buttonSavePermission.Text = "Save Permission";
            this.buttonSavePermission.UseVisualStyleBackColor = true;
            this.buttonSavePermission.Click += new System.EventHandler(this.buttonSavePermission_Click);
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheckAvailability.Location = new System.Drawing.Point(12, 264);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(167, 50);
            this.buttonCheckAvailability.TabIndex = 26;
            this.buttonCheckAvailability.Text = "Check Availability";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            this.buttonCheckAvailability.Click += new System.EventHandler(this.buttonCheckAvailability_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelCategory.Location = new System.Drawing.Point(12, 9);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(167, 37);
            this.labelCategory.TabIndex = 25;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxKillInstance
            // 
            this.checkBoxKillInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxKillInstance.Location = new System.Drawing.Point(12, 221);
            this.checkBoxKillInstance.Name = "checkBoxKillInstance";
            this.checkBoxKillInstance.Size = new System.Drawing.Size(167, 37);
            this.checkBoxKillInstance.TabIndex = 24;
            this.checkBoxKillInstance.Text = "Kill Instance";
            this.checkBoxKillInstance.UseVisualStyleBackColor = true;
            // 
            // checkBoxMakeInstance
            // 
            this.checkBoxMakeInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxMakeInstance.Location = new System.Drawing.Point(12, 178);
            this.checkBoxMakeInstance.Name = "checkBoxMakeInstance";
            this.checkBoxMakeInstance.Size = new System.Drawing.Size(167, 37);
            this.checkBoxMakeInstance.TabIndex = 23;
            this.checkBoxMakeInstance.Text = "Make Instance";
            this.checkBoxMakeInstance.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxEdit.Location = new System.Drawing.Point(12, 135);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(167, 37);
            this.checkBoxEdit.TabIndex = 22;
            this.checkBoxEdit.Text = "Edit";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxDelete.Location = new System.Drawing.Point(12, 92);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(167, 37);
            this.checkBoxDelete.TabIndex = 21;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(185, 9);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(198, 37);
            this.comboBoxCategories.TabIndex = 20;
            // 
            // checkBoxAdd
            // 
            this.checkBoxAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxAdd.Location = new System.Drawing.Point(12, 49);
            this.checkBoxAdd.Name = "checkBoxAdd";
            this.checkBoxAdd.Size = new System.Drawing.Size(167, 37);
            this.checkBoxAdd.TabIndex = 19;
            this.checkBoxAdd.Text = "Add";
            this.checkBoxAdd.UseVisualStyleBackColor = false;
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
            // NewPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "NewPermission";
            this.Text = "NewPermission";
            this.Load += new System.EventHandler(this.NewPermission_Load);
            this.Resize += new System.EventHandler(this.NewPermission_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSavePermission;

        private System.Windows.Forms.Button buttonCheckAvailability;

        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.CheckBox checkBoxMakeInstance;
        private System.Windows.Forms.CheckBox checkBoxKillInstance;
        private System.Windows.Forms.Label labelCategory;

        private System.Windows.Forms.CheckBox checkBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxCategories;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}