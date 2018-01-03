namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    partial class DeploymentFolderManagerEditor
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deploymentManagerLabel = new System.Windows.Forms.TextBox();
            this.chooseTargetFolder = new System.Windows.Forms.Button();
            this.selectedTargetFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.cancelButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 55);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::DeploymentBuddy.IconResources.save48;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(52, 52);
            this.saveButton.Text = "toolStripButton1";
            this.saveButton.ToolTipText = "Save the current Package Builder instance.";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelButton.Image = global::DeploymentBuddy.IconResources.cancel48;
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(52, 52);
            this.cancelButton.Text = "toolStripButton2";
            this.cancelButton.ToolTipText = "Cancel any changes to this Package Builder instance.";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Package Source Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Builder Name";
            // 
            // deploymentManagerLabel
            // 
            this.deploymentManagerLabel.Location = new System.Drawing.Point(179, 79);
            this.deploymentManagerLabel.Margin = new System.Windows.Forms.Padding(4);
            this.deploymentManagerLabel.Name = "deploymentManagerLabel";
            this.deploymentManagerLabel.Size = new System.Drawing.Size(260, 22);
            this.deploymentManagerLabel.TabIndex = 17;
            // 
            // chooseTargetFolder
            // 
            this.chooseTargetFolder.Image = global::DeploymentBuddy.IconResources.folder24;
            this.chooseTargetFolder.Location = new System.Drawing.Point(547, 110);
            this.chooseTargetFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chooseTargetFolder.Name = "chooseTargetFolder";
            this.chooseTargetFolder.Size = new System.Drawing.Size(40, 37);
            this.chooseTargetFolder.TabIndex = 16;
            this.chooseTargetFolder.UseVisualStyleBackColor = true;
            this.chooseTargetFolder.Click += new System.EventHandler(this.chooseTargetFolder_Click);
            // 
            // selectedTargetFolder
            // 
            this.selectedTargetFolder.Location = new System.Drawing.Point(179, 118);
            this.selectedTargetFolder.Margin = new System.Windows.Forms.Padding(4);
            this.selectedTargetFolder.Name = "selectedTargetFolder";
            this.selectedTargetFolder.Size = new System.Drawing.Size(360, 22);
            this.selectedTargetFolder.TabIndex = 15;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Package Builder";
            // 
            // DeploymentFolderManagerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deploymentManagerLabel);
            this.Controls.Add(this.chooseTargetFolder);
            this.Controls.Add(this.selectedTargetFolder);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeploymentFolderManagerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deployment Folder Manager Editor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deploymentManagerLabel;
        private System.Windows.Forms.Button chooseTargetFolder;
        private System.Windows.Forms.TextBox selectedTargetFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}