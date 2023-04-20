using System.ComponentModel;

namespace ArtifactManager.Interface.User
{
    partial class UserPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditMyPassword = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddInstance = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonInstances = new System.Windows.Forms.Button();
            this.buttonCategoryTree = new System.Windows.Forms.Button();
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
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditMyPassword);
            this.panel1.Controls.Add(this.buttonEditCategory);
            this.panel1.Controls.Add(this.buttonAddCategory);
            this.panel1.Controls.Add(this.buttonAddInstance);
            this.panel1.Controls.Add(this.buttonCategories);
            this.panel1.Controls.Add(this.buttonInstances);
            this.panel1.Controls.Add(this.buttonCategoryTree);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // buttonEditMyPassword
            // 
            this.buttonEditMyPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditMyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditMyPassword.Location = new System.Drawing.Point(12, 292);
            this.buttonEditMyPassword.Name = "buttonEditMyPassword";
            this.buttonEditMyPassword.Size = new System.Drawing.Size(216, 50);
            this.buttonEditMyPassword.TabIndex = 13;
            this.buttonEditMyPassword.Text = "Edit My Password";
            this.buttonEditMyPassword.UseVisualStyleBackColor = true;
            this.buttonEditMyPassword.Click += new System.EventHandler(this.buttonEditMyPassword_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonEditCategory.Location = new System.Drawing.Point(12, 236);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(216, 50);
            this.buttonEditCategory.TabIndex = 12;
            this.buttonEditCategory.Text = "Edit Category";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonAddCategory.Location = new System.Drawing.Point(12, 180);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(216, 50);
            this.buttonAddCategory.TabIndex = 11;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddInstance
            // 
            this.buttonAddInstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonAddInstance.Location = new System.Drawing.Point(12, 124);
            this.buttonAddInstance.Name = "buttonAddInstance";
            this.buttonAddInstance.Size = new System.Drawing.Size(216, 50);
            this.buttonAddInstance.TabIndex = 10;
            this.buttonAddInstance.Text = "Add Instance";
            this.buttonAddInstance.UseVisualStyleBackColor = true;
            this.buttonAddInstance.Click += new System.EventHandler(this.buttonAddInstance_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCategories.Location = new System.Drawing.Point(12, 12);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(216, 50);
            this.buttonCategories.TabIndex = 9;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonInstances
            // 
            this.buttonInstances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonInstances.Location = new System.Drawing.Point(12, 68);
            this.buttonInstances.Name = "buttonInstances";
            this.buttonInstances.Size = new System.Drawing.Size(216, 50);
            this.buttonInstances.TabIndex = 8;
            this.buttonInstances.Text = "Instances";
            this.buttonInstances.UseVisualStyleBackColor = true;
            this.buttonInstances.Click += new System.EventHandler(this.buttonInstances_Click);
            // 
            // buttonCategoryTree
            // 
            this.buttonCategoryTree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCategoryTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonCategoryTree.Location = new System.Drawing.Point(572, 12);
            this.buttonCategoryTree.Name = "buttonCategoryTree";
            this.buttonCategoryTree.Size = new System.Drawing.Size(216, 50);
            this.buttonCategoryTree.TabIndex = 7;
            this.buttonCategoryTree.Text = "Category Tree";
            this.buttonCategoryTree.UseVisualStyleBackColor = true;
            this.buttonCategoryTree.Click += new System.EventHandler(this.buttonCategoryTree_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.Resize += new System.EventHandler(this.UserPanel_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonEditMyPassword;

        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonInstances;
        private System.Windows.Forms.Button buttonCategoryTree;
        private System.Windows.Forms.Button buttonAddInstance;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonEditCategory;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button buttonQuit;

        #endregion

    }
}