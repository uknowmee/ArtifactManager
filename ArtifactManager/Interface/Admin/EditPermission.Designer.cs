using System.ComponentModel;

namespace ArtifactManager.Interface.Admin
{
    partial class EditPermission
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.checkBoxSaved = new System.Windows.Forms.CheckBox();
            this.checkBoxChanged = new System.Windows.Forms.CheckBox();
            this.buttonSavePermission = new System.Windows.Forms.Button();
            this.buttonCheckAvailability = new System.Windows.Forms.Button();
            this.labelPermission = new System.Windows.Forms.Label();
            this.checkBoxKillInstance = new System.Windows.Forms.CheckBox();
            this.checkBoxMakeInstance = new System.Windows.Forms.CheckBox();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.comboBoxPermissions = new System.Windows.Forms.ComboBox();
            this.checkBoxAdd = new System.Windows.Forms.CheckBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonDeletePermission = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDeletePermission);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.checkBoxSaved);
            this.panel1.Controls.Add(this.checkBoxChanged);
            this.panel1.Controls.Add(this.buttonSavePermission);
            this.panel1.Controls.Add(this.buttonCheckAvailability);
            this.panel1.Controls.Add(this.labelPermission);
            this.panel1.Controls.Add(this.checkBoxKillInstance);
            this.panel1.Controls.Add(this.checkBoxMakeInstance);
            this.panel1.Controls.Add(this.checkBoxEdit);
            this.panel1.Controls.Add(this.checkBoxDelete);
            this.panel1.Controls.Add(this.comboBoxPermissions);
            this.panel1.Controls.Add(this.checkBoxAdd);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 16;
            this.comboBoxCategory.Location = new System.Drawing.Point(185, 58);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(251, 24);
            this.comboBoxCategory.TabIndex = 42;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelCategory.Location = new System.Drawing.Point(12, 49);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(167, 37);
            this.labelCategory.TabIndex = 41;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSaved
            // 
            this.checkBoxSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxSaved.Location = new System.Drawing.Point(185, 348);
            this.checkBoxSaved.Name = "checkBoxSaved";
            this.checkBoxSaved.Size = new System.Drawing.Size(127, 37);
            this.checkBoxSaved.TabIndex = 40;
            this.checkBoxSaved.Text = "Saved";
            this.checkBoxSaved.UseVisualStyleBackColor = true;
            this.checkBoxSaved.Click += new System.EventHandler(this.checkBoxSaved_Click);
            // 
            // checkBoxChanged
            // 
            this.checkBoxChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxChanged.Location = new System.Drawing.Point(185, 305);
            this.checkBoxChanged.Name = "checkBoxChanged";
            this.checkBoxChanged.Size = new System.Drawing.Size(127, 37);
            this.checkBoxChanged.TabIndex = 39;
            this.checkBoxChanged.Text = "Changed";
            this.checkBoxChanged.UseVisualStyleBackColor = true;
            this.checkBoxChanged.Click += new System.EventHandler(this.checkBoxChanged_Click);
            // 
            // buttonSavePermission
            // 
            this.buttonSavePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonSavePermission.Location = new System.Drawing.Point(12, 347);
            this.buttonSavePermission.Name = "buttonSavePermission";
            this.buttonSavePermission.Size = new System.Drawing.Size(167, 37);
            this.buttonSavePermission.TabIndex = 36;
            this.buttonSavePermission.Text = "Save Permission";
            this.buttonSavePermission.UseVisualStyleBackColor = true;
            this.buttonSavePermission.Click += new System.EventHandler(this.buttonSavePermission_Click);
            // 
            // buttonCheckAvailability
            // 
            this.buttonCheckAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCheckAvailability.Location = new System.Drawing.Point(12, 304);
            this.buttonCheckAvailability.Name = "buttonCheckAvailability";
            this.buttonCheckAvailability.Size = new System.Drawing.Size(167, 37);
            this.buttonCheckAvailability.TabIndex = 35;
            this.buttonCheckAvailability.Text = "Check Availability";
            this.buttonCheckAvailability.UseVisualStyleBackColor = true;
            this.buttonCheckAvailability.Click += new System.EventHandler(this.buttonCheckAvailability_Click);
            // 
            // labelPermission
            // 
            this.labelPermission.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelPermission.Location = new System.Drawing.Point(12, 9);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(167, 37);
            this.labelPermission.TabIndex = 34;
            this.labelPermission.Text = "Permission";
            this.labelPermission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxKillInstance
            // 
            this.checkBoxKillInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxKillInstance.Location = new System.Drawing.Point(12, 261);
            this.checkBoxKillInstance.Name = "checkBoxKillInstance";
            this.checkBoxKillInstance.Size = new System.Drawing.Size(167, 37);
            this.checkBoxKillInstance.TabIndex = 33;
            this.checkBoxKillInstance.Text = "Kill Instance";
            this.checkBoxKillInstance.UseVisualStyleBackColor = true;
            this.checkBoxKillInstance.Click += new System.EventHandler(this.checkBoxKillInstance_Click);
            // 
            // checkBoxMakeInstance
            // 
            this.checkBoxMakeInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxMakeInstance.Location = new System.Drawing.Point(12, 218);
            this.checkBoxMakeInstance.Name = "checkBoxMakeInstance";
            this.checkBoxMakeInstance.Size = new System.Drawing.Size(167, 37);
            this.checkBoxMakeInstance.TabIndex = 32;
            this.checkBoxMakeInstance.Text = "Make Instance";
            this.checkBoxMakeInstance.UseVisualStyleBackColor = true;
            this.checkBoxMakeInstance.Click += new System.EventHandler(this.checkBoxMakeInstance_Click);
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxEdit.Location = new System.Drawing.Point(12, 175);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(167, 37);
            this.checkBoxEdit.TabIndex = 31;
            this.checkBoxEdit.Text = "Edit";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.Click += new System.EventHandler(this.checkBoxEdit_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxDelete.Location = new System.Drawing.Point(12, 132);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(167, 37);
            this.checkBoxDelete.TabIndex = 30;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.Click += new System.EventHandler(this.checkBoxDelete_Click);
            // 
            // comboBoxPermissions
            // 
            this.comboBoxPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxPermissions.FormattingEnabled = true;
            this.comboBoxPermissions.ItemHeight = 16;
            this.comboBoxPermissions.Location = new System.Drawing.Point(185, 18);
            this.comboBoxPermissions.Name = "comboBoxPermissions";
            this.comboBoxPermissions.Size = new System.Drawing.Size(603, 24);
            this.comboBoxPermissions.TabIndex = 29;
            this.comboBoxPermissions.SelectedIndexChanged += new System.EventHandler(this.comboBoxPermissions_SelectedIndexChanged);
            // 
            // checkBoxAdd
            // 
            this.checkBoxAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxAdd.Location = new System.Drawing.Point(12, 89);
            this.checkBoxAdd.Name = "checkBoxAdd";
            this.checkBoxAdd.Size = new System.Drawing.Size(167, 37);
            this.checkBoxAdd.TabIndex = 28;
            this.checkBoxAdd.Text = "Add";
            this.checkBoxAdd.UseVisualStyleBackColor = false;
            this.checkBoxAdd.Click += new System.EventHandler(this.checkBoxAdd_Click);
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
            // buttonDeletePermission
            // 
            this.buttonDeletePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDeletePermission.Location = new System.Drawing.Point(12, 390);
            this.buttonDeletePermission.Name = "buttonDeletePermission";
            this.buttonDeletePermission.Size = new System.Drawing.Size(167, 37);
            this.buttonDeletePermission.TabIndex = 43;
            this.buttonDeletePermission.Text = "Delete Permission";
            this.buttonDeletePermission.UseVisualStyleBackColor = true;
            this.buttonDeletePermission.Click += new System.EventHandler(this.buttonDeletePermission_Click);
            // 
            // EditPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditPermission";
            this.Text = "EditPermission";
            this.Load += new System.EventHandler(this.EditPermission_Load);
            this.Resize += new System.EventHandler(this.EditPermission_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonDeletePermission;

        private System.Windows.Forms.Label labelPermission;
        private System.Windows.Forms.ComboBox comboBoxCategory;

        private System.Windows.Forms.CheckBox checkBoxSaved;
        private System.Windows.Forms.CheckBox checkBoxChanged;

        private System.Windows.Forms.Button buttonSavePermission;
        private System.Windows.Forms.Button buttonCheckAvailability;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.CheckBox checkBoxKillInstance;
        private System.Windows.Forms.CheckBox checkBoxMakeInstance;
        private System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.ComboBox comboBoxPermissions;
        private System.Windows.Forms.CheckBox checkBoxAdd;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}