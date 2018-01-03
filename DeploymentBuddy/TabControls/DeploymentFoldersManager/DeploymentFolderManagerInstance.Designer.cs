namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    partial class DeploymentFolderManagerInstance
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
            this.managerLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.editDeploymentManagerButton = new System.Windows.Forms.Button();
            this.createBackupButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.foldersLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLabel.Location = new System.Drawing.Point(7, 5);
            this.managerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(128, 20);
            this.managerLabel.TabIndex = 5;
            this.managerLabel.Text = "Manager Label";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Deployment Folder Manager";
            // 
            // editDeploymentManagerButton
            // 
            this.editDeploymentManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editDeploymentManagerButton.Image = global::DeploymentBuddy.IconResources.edit24;
            this.editDeploymentManagerButton.Location = new System.Drawing.Point(215, 4);
            this.editDeploymentManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.editDeploymentManagerButton.Name = "editDeploymentManagerButton";
            this.editDeploymentManagerButton.Size = new System.Drawing.Size(40, 40);
            this.editDeploymentManagerButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.editDeploymentManagerButton, "Edit this Deployment Folder Manager.");
            this.editDeploymentManagerButton.UseVisualStyleBackColor = true;
            this.editDeploymentManagerButton.Click += new System.EventHandler(this.editDeploymentManagerButton_Click);
            // 
            // createBackupButton
            // 
            this.createBackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createBackupButton.Image = global::DeploymentBuddy.IconResources.package32;
            this.createBackupButton.Location = new System.Drawing.Point(263, 5);
            this.createBackupButton.Margin = new System.Windows.Forms.Padding(4);
            this.createBackupButton.Name = "createBackupButton";
            this.createBackupButton.Size = new System.Drawing.Size(40, 40);
            this.createBackupButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.createBackupButton, "Create a new backup package.");
            this.createBackupButton.UseVisualStyleBackColor = true;
            this.createBackupButton.Click += new System.EventHandler(this.createBackupButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 130);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 12);
            this.progressBar1.TabIndex = 8;
            // 
            // foldersLabel
            // 
            this.foldersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersLabel.Location = new System.Drawing.Point(4, 55);
            this.foldersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foldersLabel.Name = "foldersLabel";
            this.foldersLabel.Size = new System.Drawing.Size(299, 71);
            this.foldersLabel.TabIndex = 7;
            this.foldersLabel.Text = "Deployment Folder:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeploymentFolderManagerInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.editDeploymentManagerButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.foldersLabel);
            this.Controls.Add(this.createBackupButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeploymentFolderManagerInstance";
            this.Size = new System.Drawing.Size(307, 142);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button editDeploymentManagerButton;
        private System.Windows.Forms.Button createBackupButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label foldersLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
