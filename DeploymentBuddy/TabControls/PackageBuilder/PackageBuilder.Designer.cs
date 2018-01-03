namespace DeploymentBuddy.TabControls.PackageBuilder
{
    partial class PackageBuilder
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
            this.packageBuildersList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newPackageBuilder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packageBuildersList
            // 
            this.packageBuildersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageBuildersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.packageBuildersList.Location = new System.Drawing.Point(4, 62);
            this.packageBuildersList.Margin = new System.Windows.Forms.Padding(4);
            this.packageBuildersList.Name = "packageBuildersList";
            this.packageBuildersList.Size = new System.Drawing.Size(658, 301);
            this.packageBuildersList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Builder";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Package Builder";
            // 
            // newPackageBuilder
            // 
            this.newPackageBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newPackageBuilder.Image = global::DeploymentBuddy.IconResources.add32;
            this.newPackageBuilder.Location = new System.Drawing.Point(610, 6);
            this.newPackageBuilder.Margin = new System.Windows.Forms.Padding(4);
            this.newPackageBuilder.Name = "newPackageBuilder";
            this.newPackageBuilder.Size = new System.Drawing.Size(50, 50);
            this.newPackageBuilder.TabIndex = 2;
            this.toolTip1.SetToolTip(this.newPackageBuilder, "Add a New Package Builder.");
            this.newPackageBuilder.UseVisualStyleBackColor = true;
            this.newPackageBuilder.Click += new System.EventHandler(this.newPackageBuilder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identify package sources and where to move the package file.";
            // 
            // PackageBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPackageBuilder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packageBuildersList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackageBuilder";
            this.Size = new System.Drawing.Size(667, 367);
            this.Load += new System.EventHandler(this.PackageBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel packageBuildersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newPackageBuilder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}
