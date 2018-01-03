namespace DeploymentBuddy
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.packageBuilder1 = new DeploymentBuddy.TabControls.PackageBuilder.PackageBuilder();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deploymentFoldersManager1 = new DeploymentBuddy.TabControls.DeploymentFoldersManager.DeploymentFoldersManager();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.projectVersionsConfigureButton = new System.Windows.Forms.ToolStripButton();
            this.projectVersionSelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.packageBuilder1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(715, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Package Builder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // packageBuilder1
            // 
            this.packageBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageBuilder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageBuilder1.Location = new System.Drawing.Point(4, 4);
            this.packageBuilder1.Margin = new System.Windows.Forms.Padding(5);
            this.packageBuilder1.Name = "packageBuilder1";
            this.packageBuilder1.Size = new System.Drawing.Size(707, 334);
            this.packageBuilder1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deploymentFoldersManager1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(715, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deployment Folders Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deploymentFoldersManager1
            // 
            this.deploymentFoldersManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deploymentFoldersManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deploymentFoldersManager1.Location = new System.Drawing.Point(4, 4);
            this.deploymentFoldersManager1.Margin = new System.Windows.Forms.Padding(4);
            this.deploymentFoldersManager1.Name = "deploymentFoldersManager1";
            this.deploymentFoldersManager1.Size = new System.Drawing.Size(707, 334);
            this.deploymentFoldersManager1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectVersionsConfigureButton,
            this.projectVersionSelector,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // projectVersionsConfigureButton
            // 
            this.projectVersionsConfigureButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.projectVersionsConfigureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectVersionsConfigureButton.Image = global::DeploymentBuddy.IconResources.settings24;
            this.projectVersionsConfigureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.projectVersionsConfigureButton.Name = "projectVersionsConfigureButton";
            this.projectVersionsConfigureButton.Size = new System.Drawing.Size(23, 22);
            this.projectVersionsConfigureButton.Text = "toolStripButton1";
            this.projectVersionsConfigureButton.Click += new System.EventHandler(this.projectVersionsConfigureButton_Click);
            // 
            // projectVersionSelector
            // 
            this.projectVersionSelector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.projectVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectVersionSelector.Name = "projectVersionSelector";
            this.projectVersionSelector.Size = new System.Drawing.Size(121, 25);
            this.projectVersionSelector.SelectedIndexChanged += new System.EventHandler(this.projectVersionSelector_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Project Version";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 414);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Deployment Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private TabControls.PackageBuilder.PackageBuilder packageBuilder1;
        private TabControls.DeploymentFoldersManager.DeploymentFoldersManager deploymentFoldersManager1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton projectVersionsConfigureButton;
        private System.Windows.Forms.ToolStripComboBox projectVersionSelector;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

