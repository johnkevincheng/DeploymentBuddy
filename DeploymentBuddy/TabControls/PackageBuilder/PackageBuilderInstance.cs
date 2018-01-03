using Ionic.Zip;
using System;
using System.IO;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.PackageBuilder
{
    public partial class PackageBuilderInstance : UserControl
    {
        public PackageBuilderInstance(Entities.PackageBuilder packageBuilder)
        {
            InitializeComponent();

            PackageBuilderData = packageBuilder;
            ProjectVersion = Singleton.Instance.Settings.SelectedProjectVersion;

            Dashboard.MyProjectVersionChangedEvent += Dashboard_MyProjectVersionChangedEvent;
        }

        protected String DestinationFilePath
        {
            get
            {
                var fileName = String.Format(PackageBuilderData.PackageName, ProjectVersion) + ".zip";
                return Path.Combine(PackageBuilderData.DestinationFolder, fileName);
            }
        }

        protected String ProjectVersion { get; set; }

        private Entities.PackageBuilder _packageBuilderData;
        protected Entities.PackageBuilder PackageBuilderData
        {
            get
            {
                return _packageBuilderData;
            }
            set
            {
                _packageBuilderData = value;

                packageLabel.Text = value.PackageLabel;
                UpdateFoldersDisplay();
            }
        }

        private void Dashboard_MyProjectVersionChangedEvent(object sender, ApplicationEvents.ProjectVersionChangedArg args)
        {
            ProjectVersion = args.NewProjectVersion;
            UpdateFoldersDisplay();
        }

        private void UpdateFoldersDisplay()
        {
            foldersLabel.Text = $"Source Folder:\n{PackageBuilderData.SourceFolder}\nDestination:\n{DestinationFilePath}";
            toolTip1.SetToolTip(foldersLabel, foldersLabel.Text);
        }

        private void createPackageButton_Click(object sender, EventArgs e)
        {
            createPackageButton.Enabled = false;
            editPackageBuilderButton.Enabled = false;
            
            var results = Utilities.PackageFolder(PackageBuilderData.SourceFolder, DestinationFilePath, zipProgress);

            if (!results.Success)
                errorProvider1.SetError(packageLabel, results.Message);

            createPackageButton.Enabled = true;
            editPackageBuilderButton.Enabled = true;
        }

        private void editPackageBuilderButton_Click(object sender, EventArgs e)
        {
            using (var f = new PackageBuilderEditor(PackageBuilderData))
            {
                var dialogResult = f.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                    this.PackageBuilderData = f.PackageBuilderData;
            }
        }
        
        private void zipProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
                progressBar1.Value = e.EntriesSaved * 100 / e.EntriesTotal;
        }
    }
}
