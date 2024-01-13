namespace WindowsFormsApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVechicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentelRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentelRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentelRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechicleListingToolStripMenuItem,
            this.manageRentelRecordToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVechicleListingToolStripMenuItem
            // 
            this.manageVechicleListingToolStripMenuItem.Name = "manageVechicleListingToolStripMenuItem";
            this.manageVechicleListingToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.manageVechicleListingToolStripMenuItem.Text = "Manage Vechicle Listing";
            this.manageVechicleListingToolStripMenuItem.Click += new System.EventHandler(this.manageVechicleListingToolStripMenuItem_Click);
            // 
            // manageRentelRecordToolStripMenuItem
            // 
            this.manageRentelRecordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentelRecordToolStripMenuItem,
            this.viewArchieveToolStripMenuItem,
            this.editRentelRecordToolStripMenuItem});
            this.manageRentelRecordToolStripMenuItem.Name = "manageRentelRecordToolStripMenuItem";
            this.manageRentelRecordToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.manageRentelRecordToolStripMenuItem.Text = "Manage Rental Record";
            // 
            // addRentelRecordToolStripMenuItem
            // 
            this.addRentelRecordToolStripMenuItem.Name = "addRentelRecordToolStripMenuItem";
            this.addRentelRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.addRentelRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentelRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentelRecordToolStripMenuItem_Click);
            // 
            // viewArchieveToolStripMenuItem
            // 
            this.viewArchieveToolStripMenuItem.Name = "viewArchieveToolStripMenuItem";
            this.viewArchieveToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.viewArchieveToolStripMenuItem.Text = "View Archive";
            this.viewArchieveToolStripMenuItem.Click += new System.EventHandler(this.viewArchieveToolStripMenuItem_Click);
            // 
            // editRentelRecordToolStripMenuItem
            // 
            this.editRentelRecordToolStripMenuItem.Name = "editRentelRecordToolStripMenuItem";
            this.editRentelRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.editRentelRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 715);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Car Rental Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVechicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentelRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}