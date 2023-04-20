using System.ComponentModel;

namespace ArtifactManager.Interface.User
{
    partial class AddInstance
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
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExistingAttribute = new System.Windows.Forms.ComboBox();
            this.labelExistingAttribute = new System.Windows.Forms.Label();
            this.buttonApplyAll = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSwitch);
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.textBoxValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxExistingAttribute);
            this.panel1.Controls.Add(this.labelExistingAttribute);
            this.panel1.Controls.Add(this.buttonApplyAll);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonSwitch.Location = new System.Drawing.Point(550, 89);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(117, 50);
            this.buttonSwitch.TabIndex = 53;
            this.buttonSwitch.Text = "Switch";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(25, 102);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(519, 335);
            this.treeView.TabIndex = 52;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(671, 89);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(117, 50);
            this.buttonApply.TabIndex = 51;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxValue.Location = new System.Drawing.Point(454, 55);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(334, 28);
            this.textBoxValue.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(353, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxExistingAttribute
            // 
            this.comboBoxExistingAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxExistingAttribute.FormattingEnabled = true;
            this.comboBoxExistingAttribute.Location = new System.Drawing.Point(454, 12);
            this.comboBoxExistingAttribute.Name = "comboBoxExistingAttribute";
            this.comboBoxExistingAttribute.Size = new System.Drawing.Size(334, 30);
            this.comboBoxExistingAttribute.TabIndex = 42;
            this.comboBoxExistingAttribute.SelectedIndexChanged += new System.EventHandler(this.comboBoxExistingAttribute_SelectedIndexChanged);
            // 
            // labelExistingAttribute
            // 
            this.labelExistingAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelExistingAttribute.Location = new System.Drawing.Point(353, 12);
            this.labelExistingAttribute.Name = "labelExistingAttribute";
            this.labelExistingAttribute.Size = new System.Drawing.Size(95, 30);
            this.labelExistingAttribute.TabIndex = 41;
            this.labelExistingAttribute.Text = "Attribute";
            this.labelExistingAttribute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonApplyAll
            // 
            this.buttonApplyAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApplyAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApplyAll.Location = new System.Drawing.Point(671, 332);
            this.buttonApplyAll.Name = "buttonApplyAll";
            this.buttonApplyAll.Size = new System.Drawing.Size(117, 50);
            this.buttonApplyAll.TabIndex = 28;
            this.buttonApplyAll.Text = "Apply";
            this.buttonApplyAll.UseVisualStyleBackColor = true;
            this.buttonApplyAll.Click += new System.EventHandler(this.buttonApplyAll_Click);
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
            // AddInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddInstance";
            this.Text = "AddInstance";
            this.Load += new System.EventHandler(this.AddInstance_Load);
            this.Resize += new System.EventHandler(this.AddInstance_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSwitch;

        private System.Windows.Forms.TreeView treeView;

        private System.Windows.Forms.Button buttonApplyAll;

        private System.Windows.Forms.ComboBox comboBoxExistingAttribute;
        private System.Windows.Forms.Label labelExistingAttribute;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValue;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}