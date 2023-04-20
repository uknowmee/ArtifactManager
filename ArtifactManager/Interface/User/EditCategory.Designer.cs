using System.ComponentModel;

namespace ArtifactManager.Interface.User
{
    partial class EditCategory
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonDeleteAttribute = new System.Windows.Forms.Button();
            this.buttonDeleteElement = new System.Windows.Forms.Button();
            this.checkBoxMeansStronger = new System.Windows.Forms.CheckBox();
            this.comboBoxAttributeType = new System.Windows.Forms.ComboBox();
            this.textBoxAttributeName = new System.Windows.Forms.TextBox();
            this.comboBoxExistingAttribute = new System.Windows.Forms.ComboBox();
            this.labelExistingAttribute = new System.Windows.Forms.Label();
            this.labelAttributeType = new System.Windows.Forms.Label();
            this.labelAttributeName = new System.Windows.Forms.Label();
            this.comboBoxExistingElement = new System.Windows.Forms.ComboBox();
            this.labelExisting = new System.Windows.Forms.Label();
            this.comboBoxElementType = new System.Windows.Forms.ComboBox();
            this.textBoxElementName = new System.Windows.Forms.TextBox();
            this.labelElementType = new System.Windows.Forms.Label();
            this.labelElementName = new System.Windows.Forms.Label();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.buttonNewElement = new System.Windows.Forms.Button();
            this.buttonNewAttribute = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonDeleteCategory);
            this.panel1.Controls.Add(this.buttonDeleteAttribute);
            this.panel1.Controls.Add(this.buttonDeleteElement);
            this.panel1.Controls.Add(this.checkBoxMeansStronger);
            this.panel1.Controls.Add(this.comboBoxAttributeType);
            this.panel1.Controls.Add(this.textBoxAttributeName);
            this.panel1.Controls.Add(this.comboBoxExistingAttribute);
            this.panel1.Controls.Add(this.labelExistingAttribute);
            this.panel1.Controls.Add(this.labelAttributeType);
            this.panel1.Controls.Add(this.labelAttributeName);
            this.panel1.Controls.Add(this.comboBoxExistingElement);
            this.panel1.Controls.Add(this.labelExisting);
            this.panel1.Controls.Add(this.comboBoxElementType);
            this.panel1.Controls.Add(this.textBoxElementName);
            this.panel1.Controls.Add(this.labelElementType);
            this.panel1.Controls.Add(this.labelElementName);
            this.panel1.Controls.Add(this.comboBoxCategoryName);
            this.panel1.Controls.Add(this.buttonNewElement);
            this.panel1.Controls.Add(this.buttonNewAttribute);
            this.panel1.Controls.Add(this.textBoxCategoryName);
            this.panel1.Controls.Add(this.labelCategoryName);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(671, 68);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(117, 50);
            this.buttonApply.TabIndex = 37;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(671, 12);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(117, 50);
            this.buttonDeleteCategory.TabIndex = 36;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonDeleteAttribute
            // 
            this.buttonDeleteAttribute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDeleteAttribute.Location = new System.Drawing.Point(300, 257);
            this.buttonDeleteAttribute.Name = "buttonDeleteAttribute";
            this.buttonDeleteAttribute.Size = new System.Drawing.Size(117, 50);
            this.buttonDeleteAttribute.TabIndex = 35;
            this.buttonDeleteAttribute.Text = "Delete";
            this.buttonDeleteAttribute.UseVisualStyleBackColor = true;
            this.buttonDeleteAttribute.Click += new System.EventHandler(this.buttonDeleteAttribute_Click);
            // 
            // buttonDeleteElement
            // 
            this.buttonDeleteElement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonDeleteElement.Location = new System.Drawing.Point(671, 257);
            this.buttonDeleteElement.Name = "buttonDeleteElement";
            this.buttonDeleteElement.Size = new System.Drawing.Size(117, 50);
            this.buttonDeleteElement.TabIndex = 34;
            this.buttonDeleteElement.Text = "Delete";
            this.buttonDeleteElement.UseVisualStyleBackColor = true;
            this.buttonDeleteElement.Click += new System.EventHandler(this.buttonDeleteElement_Click);
            // 
            // checkBoxMeansStronger
            // 
            this.checkBoxMeansStronger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.checkBoxMeansStronger.Location = new System.Drawing.Point(12, 257);
            this.checkBoxMeansStronger.Name = "checkBoxMeansStronger";
            this.checkBoxMeansStronger.Size = new System.Drawing.Size(405, 38);
            this.checkBoxMeansStronger.TabIndex = 32;
            this.checkBoxMeansStronger.Text = "Should New Instance Be Weaker?";
            this.checkBoxMeansStronger.UseVisualStyleBackColor = true;
            // 
            // comboBoxAttributeType
            // 
            this.comboBoxAttributeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxAttributeType.FormattingEnabled = true;
            this.comboBoxAttributeType.Location = new System.Drawing.Point(186, 214);
            this.comboBoxAttributeType.Name = "comboBoxAttributeType";
            this.comboBoxAttributeType.Size = new System.Drawing.Size(231, 30);
            this.comboBoxAttributeType.TabIndex = 25;
            // 
            // textBoxAttributeName
            // 
            this.textBoxAttributeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxAttributeName.Location = new System.Drawing.Point(186, 171);
            this.textBoxAttributeName.Name = "textBoxAttributeName";
            this.textBoxAttributeName.Size = new System.Drawing.Size(231, 28);
            this.textBoxAttributeName.TabIndex = 24;
            // 
            // comboBoxExistingAttribute
            // 
            this.comboBoxExistingAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxExistingAttribute.FormattingEnabled = true;
            this.comboBoxExistingAttribute.Location = new System.Drawing.Point(186, 128);
            this.comboBoxExistingAttribute.Name = "comboBoxExistingAttribute";
            this.comboBoxExistingAttribute.Size = new System.Drawing.Size(231, 30);
            this.comboBoxExistingAttribute.TabIndex = 23;
            this.comboBoxExistingAttribute.SelectedIndexChanged += new System.EventHandler(this.comboBoxExistingAttribute_SelectedIndexChanged);
            // 
            // labelExistingAttribute
            // 
            this.labelExistingAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelExistingAttribute.Location = new System.Drawing.Point(78, 121);
            this.labelExistingAttribute.Name = "labelExistingAttribute";
            this.labelExistingAttribute.Size = new System.Drawing.Size(95, 43);
            this.labelExistingAttribute.TabIndex = 22;
            this.labelExistingAttribute.Text = "Existing";
            this.labelExistingAttribute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAttributeType
            // 
            this.labelAttributeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAttributeType.Location = new System.Drawing.Point(78, 207);
            this.labelAttributeType.Name = "labelAttributeType";
            this.labelAttributeType.Size = new System.Drawing.Size(95, 43);
            this.labelAttributeType.TabIndex = 19;
            this.labelAttributeType.Text = "Type";
            this.labelAttributeType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAttributeName
            // 
            this.labelAttributeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelAttributeName.Location = new System.Drawing.Point(78, 164);
            this.labelAttributeName.Name = "labelAttributeName";
            this.labelAttributeName.Size = new System.Drawing.Size(95, 43);
            this.labelAttributeName.TabIndex = 18;
            this.labelAttributeName.Text = "Name";
            this.labelAttributeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxExistingElement
            // 
            this.comboBoxExistingElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxExistingElement.FormattingEnabled = true;
            this.comboBoxExistingElement.Location = new System.Drawing.Point(557, 128);
            this.comboBoxExistingElement.Name = "comboBoxExistingElement";
            this.comboBoxExistingElement.Size = new System.Drawing.Size(231, 30);
            this.comboBoxExistingElement.TabIndex = 17;
            this.comboBoxExistingElement.SelectedIndexChanged += new System.EventHandler(this.comboBoxExistingElement_SelectedIndexChanged);
            // 
            // labelExisting
            // 
            this.labelExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelExisting.Location = new System.Drawing.Point(449, 121);
            this.labelExisting.Name = "labelExisting";
            this.labelExisting.Size = new System.Drawing.Size(95, 43);
            this.labelExisting.TabIndex = 16;
            this.labelExisting.Text = "Existing";
            this.labelExisting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxElementType
            // 
            this.comboBoxElementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxElementType.FormattingEnabled = true;
            this.comboBoxElementType.Location = new System.Drawing.Point(557, 214);
            this.comboBoxElementType.Name = "comboBoxElementType";
            this.comboBoxElementType.Size = new System.Drawing.Size(231, 30);
            this.comboBoxElementType.TabIndex = 15;
            // 
            // textBoxElementName
            // 
            this.textBoxElementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxElementName.Location = new System.Drawing.Point(557, 171);
            this.textBoxElementName.Name = "textBoxElementName";
            this.textBoxElementName.Size = new System.Drawing.Size(231, 28);
            this.textBoxElementName.TabIndex = 14;
            // 
            // labelElementType
            // 
            this.labelElementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelElementType.Location = new System.Drawing.Point(449, 207);
            this.labelElementType.Name = "labelElementType";
            this.labelElementType.Size = new System.Drawing.Size(95, 43);
            this.labelElementType.TabIndex = 13;
            this.labelElementType.Text = "Type";
            this.labelElementType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelElementName
            // 
            this.labelElementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelElementName.Location = new System.Drawing.Point(449, 164);
            this.labelElementName.Name = "labelElementName";
            this.labelElementName.Size = new System.Drawing.Size(95, 43);
            this.labelElementName.TabIndex = 12;
            this.labelElementName.Text = "Name";
            this.labelElementName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(432, 16);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(233, 30);
            this.comboBoxCategoryName.TabIndex = 11;
            this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
            // 
            // buttonNewElement
            // 
            this.buttonNewElement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonNewElement.Location = new System.Drawing.Point(432, 68);
            this.buttonNewElement.Name = "buttonNewElement";
            this.buttonNewElement.Size = new System.Drawing.Size(233, 50);
            this.buttonNewElement.TabIndex = 10;
            this.buttonNewElement.Text = "New Element";
            this.buttonNewElement.UseVisualStyleBackColor = true;
            this.buttonNewElement.Click += new System.EventHandler(this.buttonNewElement_Click);
            // 
            // buttonNewAttribute
            // 
            this.buttonNewAttribute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonNewAttribute.Location = new System.Drawing.Point(186, 68);
            this.buttonNewAttribute.Name = "buttonNewAttribute";
            this.buttonNewAttribute.Size = new System.Drawing.Size(240, 50);
            this.buttonNewAttribute.TabIndex = 9;
            this.buttonNewAttribute.Text = "New Attribute";
            this.buttonNewAttribute.UseVisualStyleBackColor = true;
            this.buttonNewAttribute.Click += new System.EventHandler(this.buttonNewAttribute_Click);
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxCategoryName.Location = new System.Drawing.Point(186, 16);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(240, 28);
            this.textBoxCategoryName.TabIndex = 6;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelCategoryName.Location = new System.Drawing.Point(12, 9);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(158, 43);
            this.labelCategoryName.TabIndex = 5;
            this.labelCategoryName.Text = "CategoryName";
            this.labelCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            this.Resize += new System.EventHandler(this.EditCategory_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonApply;

        private System.Windows.Forms.Button buttonDeleteAttribute;

        private System.Windows.Forms.Button buttonDeleteCategory;

        private System.Windows.Forms.Button buttonDeleteElement;

        private System.Windows.Forms.CheckBox checkBoxMeansStronger;

        private System.Windows.Forms.ComboBox comboBoxExistingAttribute;
        private System.Windows.Forms.TextBox textBoxAttributeName;

        private System.Windows.Forms.ComboBox comboBoxElementType;
        private System.Windows.Forms.Label labelElementName;
        private System.Windows.Forms.Label labelElementType;
        private System.Windows.Forms.TextBox textBoxElementName;
        private System.Windows.Forms.Label labelExisting;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Label labelExistingAttribute;
        private System.Windows.Forms.ComboBox comboBoxExistingElement;
        private System.Windows.Forms.Label labelAttributeType;
        private System.Windows.Forms.Label labelAttributeName;

        private System.Windows.Forms.ComboBox comboBoxAttributeType;

        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonNewAttribute;
        private System.Windows.Forms.Button buttonNewElement;

        private System.Windows.Forms.Label labelCategoryName;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}