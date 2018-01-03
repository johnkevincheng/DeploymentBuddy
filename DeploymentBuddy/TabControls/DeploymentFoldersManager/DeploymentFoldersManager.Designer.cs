namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    partial class DeploymentFoldersManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deploymentFolderManagersList = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newPackageBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identify deployment folders and perform maintenance on them.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deployment Folders Manager";
            // 
            // packageBuildersList
            // 
            this.deploymentFolderManagersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deploymentFolderManagersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deploymentFolderManagersList.Location = new System.Drawing.Point(4, 62);
            this.deploymentFolderManagersList.Margin = new System.Windows.Forms.Padding(5);
            this.deploymentFolderManagersList.Name = "packageBuildersList";
            this.deploymentFolderManagersList.Size = new System.Drawing.Size(590, 282);
            this.deploymentFolderManagersList.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Deployment Folder Manager";
            // 
            // newPackageBuilder
            // 
            this.newPackageBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPackageBuilder.Image = global::DeploymentBuddy.IconResources.add32;
            this.newPackageBuilder.Location = new System.Drawing.Point(544, 5);
            this.newPackageBuilder.Margin = new System.Windows.Forms.Padding(5);
            this.newPackageBuilder.Name = "newPackageBuilder";
            this.newPackageBuilder.Size = new System.Drawing.Size(50, 50);
            this.newPackageBuilder.TabIndex = 6;
            this.toolTip1.SetToolTip(this.newPackageBuilder, "Add a New Deployment Folder Manager.");
            this.newPackageBuilder.UseVisualStyleBackColor = true;
            this.newPackageBuilder.Click += new System.EventHandler(this.newPackageBuilder_Click);
            // 
            // DeploymentFoldersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPackageBuilder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deploymentFolderManagersList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeploymentFoldersManager";
            this.Size = new System.Drawing.Size(601, 349);
            this.Load += new System.EventHandler(this.DeploymentFoldersManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newPackageBuilder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel deploymentFolderManagersList;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
