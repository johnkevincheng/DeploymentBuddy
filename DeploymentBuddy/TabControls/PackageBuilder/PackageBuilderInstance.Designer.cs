namespace DeploymentBuddy.TabControls.PackageBuilder
{
    partial class PackageBuilderInstance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.packageLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editPackageBuilderButton = new System.Windows.Forms.Button();
            this.createPackageButton = new System.Windows.Forms.Button();
            this.foldersLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // packageLabel
            // 
            this.packageLabel.AutoSize = true;
            this.packageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageLabel.Location = new System.Drawing.Point(5, 5);
            this.packageLabel.Name = "packageLabel";
            this.packageLabel.Size = new System.Drawing.Size(127, 20);
            this.packageLabel.TabIndex = 0;
            this.packageLabel.Text = "Package Label";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Package Builder";
            // 
            // editPackageBuilderButton
            // 
            this.editPackageBuilderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPackageBuilderButton.Image = global::DeploymentBuddy.IconResources.edit24;
            this.editPackageBuilderButton.Location = new System.Drawing.Point(208, 3);
            this.editPackageBuilderButton.Name = "editPackageBuilderButton";
            this.editPackageBuilderButton.Size = new System.Drawing.Size(40, 40);
            this.editPackageBuilderButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.editPackageBuilderButton, "Edit this Deployment Package.");
            this.editPackageBuilderButton.UseVisualStyleBackColor = true;
            this.editPackageBuilderButton.Click += new System.EventHandler(this.editPackageBuilderButton_Click);
            // 
            // createPackageButton
            // 
            this.createPackageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPackageButton.Image = global::DeploymentBuddy.IconResources.package32;
            this.createPackageButton.Location = new System.Drawing.Point(254, 3);
            this.createPackageButton.Name = "createPackageButton";
            this.createPackageButton.Size = new System.Drawing.Size(40, 40);
            this.createPackageButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.createPackageButton, "Create a new Deployment Package.");
            this.createPackageButton.UseVisualStyleBackColor = true;
            this.createPackageButton.Click += new System.EventHandler(this.createPackageButton_Click);
            // 
            // foldersLabel
            // 
            this.foldersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersLabel.Location = new System.Drawing.Point(3, 46);
            this.foldersLabel.Name = "foldersLabel";
            this.foldersLabel.Size = new System.Drawing.Size(291, 80);
            this.foldersLabel.TabIndex = 2;
            this.foldersLabel.Text = "Source Folder:\r\nDestination File:";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PackageBuilderInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.editPackageBuilderButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.foldersLabel);
            this.Controls.Add(this.createPackageButton);
            this.Controls.Add(this.packageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackageBuilderInstance";
            this.Size = new System.Drawing.Size(297, 139);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packageLabel;
        private System.Windows.Forms.Button createPackageButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label foldersLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button editPackageBuilderButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
