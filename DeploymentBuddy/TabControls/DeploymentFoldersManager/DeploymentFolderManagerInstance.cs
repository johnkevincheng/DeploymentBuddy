using Ionic.Zip;
using System;
using System.IO;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    public partial class DeploymentFolderManagerInstance : UserControl
    {
        public DeploymentFolderManagerInstance(Entities.DeploymentFolderManager folderManager)
        {
            InitializeComponent();

            DeploymentFolderManagerData = folderManager;
        }

        protected String DestinationFilePath
        {
            get
            {
                var dir = new DirectoryInfo(DeploymentFolderManagerData.DeploymentFolder);
                var targetFilename = $"{dir.Name}.{DateTime.UtcNow.ToString("yyyyMMdd")}.zip";
                var targetFolder = dir.Parent.FullName;

                return Path.Combine(targetFolder, targetFilename);
            }
        }

        private Entities.DeploymentFolderManager _deploymentFolderManagerData;
        protected Entities.DeploymentFolderManager DeploymentFolderManagerData
        {
            get
            {
                return _deploymentFolderManagerData;
            }
            set
            {
                _deploymentFolderManagerData = value;

                managerLabel.Text = value.FolderManagerLabel;

                foldersLabel.Text = $"Deployment Folder:\n{value.DeploymentFolder}\nTarget Backup File:\n{DestinationFilePath}";
                toolTip1.SetToolTip(foldersLabel, foldersLabel.Text);
            }
        }

        private void editDeploymentManagerButton_Click(object sender, EventArgs e)
        {
            using (var f = new DeploymentFolderManagerEditor(DeploymentFolderManagerData))
            {
                var dialogResult = f.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                    this.DeploymentFolderManagerData = f.FolderManagerData;
            }
        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {
            createBackupButton.Enabled = false;
            editDeploymentManagerButton.Enabled = false;

            var results = Utilities.PackageFolder(DeploymentFolderManagerData.DeploymentFolder, DestinationFilePath, zipProgress);

            if (!results.Success)
                errorProvider1.SetError(managerLabel, results.Message);

            createBackupButton.Enabled = true;
            editDeploymentManagerButton.Enabled = true;
        }

        private void zipProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
                progressBar1.Value = e.EntriesSaved * 100 / e.EntriesTotal;
        }
    }
}
