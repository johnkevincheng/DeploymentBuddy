using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.DeploymentFoldersManager
{
    public partial class DeploymentFoldersManager : UserControl
    {
        public DeploymentFoldersManager()
        {
            InitializeComponent();
        }

        private void DeploymentFoldersManager_Load(object sender, EventArgs e)
        {
            deploymentFolderManagersList.Controls.Clear();
            foreach (var folderManager in Singleton.Instance.Settings.DeploymentFolderManagers.OrderBy(p => p.FolderManagerLabel))
                deploymentFolderManagersList.Controls.Add(new DeploymentFolderManagerInstance(folderManager));
        }

        private void newPackageBuilder_Click(object sender, EventArgs e)
        {
            var f = new DeploymentFolderManagerEditor();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Entities.DeploymentFolderManager data = f.FolderManagerData;

                deploymentFolderManagersList.Controls.Add(new DeploymentFolderManagerInstance(data));
            }
        }
    }
}
