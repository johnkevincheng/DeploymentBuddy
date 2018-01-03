namespace DeploymentBuddy.TabControls.PackageBuilder
{
    partial class PackageBuilderEditor
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedSourceFolder = new System.Windows.Forms.TextBox();
            this.selectedDestinationFolder = new System.Windows.Forms.TextBox();
            this.packageNameInput = new System.Windows.Forms.TextBox();
            this.packageBuilderLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseDestinationFolder = new System.Windows.Forms.Button();
            this.chooseSourceFolder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // selectedSourceFolder
            // 
            this.selectedSourceFolder.Location = new System.Drawing.Point(177, 151);
            this.selectedSourceFolder.Margin = new System.Windows.Forms.Padding(4);
            this.selectedSourceFolder.Name = "selectedSourceFolder";
            this.selectedSourceFolder.Size = new System.Drawing.Size(360, 22);
            this.selectedSourceFolder.TabIndex = 0;
            // 
            // selectedDestinationFolder
            // 
            this.selectedDestinationFolder.Location = new System.Drawing.Point(177, 195);
            this.selectedDestinationFolder.Margin = new System.Windows.Forms.Padding(4);
            this.selectedDestinationFolder.Name = "selectedDestinationFolder";
            this.selectedDestinationFolder.Size = new System.Drawing.Size(360, 22);
            this.selectedDestinationFolder.TabIndex = 2;
            // 
            // packageNameInput
            // 
            this.packageNameInput.Location = new System.Drawing.Point(177, 105);
            this.packageNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.packageNameInput.Name = "packageNameInput";
            this.packageNameInput.Size = new System.Drawing.Size(260, 22);
            this.packageNameInput.TabIndex = 4;
            // 
            // packageBuilderLabel
            // 
            this.packageBuilderLabel.Location = new System.Drawing.Point(177, 70);
            this.packageBuilderLabel.Margin = new System.Windows.Forms.Padding(4);
            this.packageBuilderLabel.Name = "packageBuilderLabel";
            this.packageBuilderLabel.Size = new System.Drawing.Size(260, 22);
            this.packageBuilderLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Builder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Package Filename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Package Source Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Package Destination";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeploymentBuddy.IconResources.info32;
            this.pictureBox1.Location = new System.Drawing.Point(444, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Use the \"{0}\" placeholder to insert the selected project version.");
            // 
            // chooseDestinationFolder
            // 
            this.chooseDestinationFolder.Image = global::DeploymentBuddy.IconResources.folder24;
            this.chooseDestinationFolder.Location = new System.Drawing.Point(545, 188);
            this.chooseDestinationFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chooseDestinationFolder.Name = "chooseDestinationFolder";
            this.chooseDestinationFolder.Size = new System.Drawing.Size(40, 37);
            this.chooseDestinationFolder.TabIndex = 3;
            this.chooseDestinationFolder.UseVisualStyleBackColor = true;
            this.chooseDestinationFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // chooseSourceFolder
            // 
            this.chooseSourceFolder.Image = global::DeploymentBuddy.IconResources.folder24;
            this.chooseSourceFolder.Location = new System.Drawing.Point(545, 143);
            this.chooseSourceFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chooseSourceFolder.Name = "chooseSourceFolder";
            this.chooseSourceFolder.Size = new System.Drawing.Size(40, 37);
            this.chooseSourceFolder.TabIndex = 1;
            this.chooseSourceFolder.UseVisualStyleBackColor = true;
            this.chooseSourceFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Package Builder";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.cancelButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 55);
            this.toolStrip1.TabIndex = 13;
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
            // PackageBuilderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 252);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packageBuilderLabel);
            this.Controls.Add(this.packageNameInput);
            this.Controls.Add(this.chooseDestinationFolder);
            this.Controls.Add(this.selectedDestinationFolder);
            this.Controls.Add(this.chooseSourceFolder);
            this.Controls.Add(this.selectedSourceFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageBuilderEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Builder Editor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox selectedSourceFolder;
        private System.Windows.Forms.Button chooseSourceFolder;
        private System.Windows.Forms.Button chooseDestinationFolder;
        private System.Windows.Forms.TextBox selectedDestinationFolder;
        private System.Windows.Forms.TextBox packageNameInput;
        private System.Windows.Forms.TextBox packageBuilderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
    }
}