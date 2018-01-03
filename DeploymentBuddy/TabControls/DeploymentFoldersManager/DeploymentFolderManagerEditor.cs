using System;
using System.Linq;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    public partial class DeploymentFolderManagerEditor : Form
    {
        public DeploymentFolderManagerEditor()
        {
            InitializeComponent();
        }

        public DeploymentFolderManagerEditor(Entities.DeploymentFolderManager folderManager)
            : this()
        {
            FolderManagerData = folderManager;
        }

        protected Guid FolderManagerId { get; set; }

        public Entities.DeploymentFolderManager FolderManagerData
        {
            get
            {
                var value = new Entities.DeploymentFolderManager();

                value.Id = FolderManagerId;
                value.FolderManagerLabel = deploymentManagerLabel.Text;
                value.DeploymentFolder = selectedTargetFolder.Text;

                return value;
            }
            set
            {
                FolderManagerId = value.Id;
                deploymentManagerLabel.Text = value.FolderManagerLabel;
                selectedTargetFolder.Text = value.DeploymentFolder;
            }
        }

        private void chooseTargetFolder_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                selectedTargetFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FolderManagerId == null || FolderManagerId == new Guid())
            {
                FolderManagerId = Guid.NewGuid();
                Singleton.Instance.Settings.DeploymentFolderManagers.Add(FolderManagerData);
            }
            else
            {
                var element = Singleton.Instance.Settings.DeploymentFolderManagers.First(p => p.Id == FolderManagerId);
                if (element != null)
                {
                    element.FolderManagerLabel = FolderManagerData.FolderManagerLabel;
                    element.DeploymentFolder = FolderManagerData.DeploymentFolder;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
