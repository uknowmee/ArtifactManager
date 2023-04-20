using System.ComponentModel;

namespace ArtifactManager.Interface.User
{
    partial class CategoryTree
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
            this.textBoxCategoryInstanceName = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeViewCategory);
            this.panel1.Controls.Add(this.textBoxCategoryInstanceName);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // textBoxCategoryInstanceName
            // 
            this.textBoxCategoryInstanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxCategoryInstanceName.Location = new System.Drawing.Point(526, 12);
            this.textBoxCategoryInstanceName.Name = "textBoxCategoryInstanceName";
            this.textBoxCategoryInstanceName.Size = new System.Drawing.Size(262, 28);
            this.textBoxCategoryInstanceName.TabIndex = 7;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(671, 332);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(117, 50);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Visible = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
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
            // treeViewCategory
            // 
            this.treeViewCategory.Location = new System.Drawing.Point(12, 48);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.Size = new System.Drawing.Size(653, 389);
            this.treeViewCategory.TabIndex = 8;
            // 
            // CategoryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryTree";
            this.Text = "CategoryTree";
            this.Load += new System.EventHandler(this.CategoryTree_Load);
            this.Resize += new System.EventHandler(this.CategoryTree_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView treeViewCategory;

        private System.Windows.Forms.TextBox textBoxCategoryInstanceName;

        private System.Windows.Forms.Button buttonApply;

        private System.Windows.Forms.Button buttonQuit;

        private System.Windows.Forms.Panel panel1;

        #endregion

    }
}