using DeploymentBuddy.ApplicationEvents;
using DeploymentBuddy.SupportForms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace DeploymentBuddy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            RefreshProjectVersionSelector();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settingsFileLocation = ConfigurationManager.AppSettings["settingsFileLocation"];
            Singleton.Instance.Save(settingsFileLocation);
        }

        private void projectVersionsConfigureButton_Click(object sender, EventArgs e)
        {
            using (var f = new ProjectVersionsEditor(Singleton.Instance.Settings.ProjectVersions))
            {
                var dialogResult = f.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    Singleton.Instance.Settings.ProjectVersions = f.ProjectVersionsData;

                    RefreshProjectVersionSelector();
                }
            }
        }

        private void RefreshProjectVersionSelector()
        {
            projectVersionSelector.Items.Clear();
            projectVersionSelector.Items.AddRange(Singleton.Instance.Settings.ProjectVersions.ToArray());

            if (Singleton.Instance.Settings.SelectedProjectVersion != null && projectVersionSelector.Items.Contains(Singleton.Instance.Settings.SelectedProjectVersion))
                projectVersionSelector.SelectedItem = Singleton.Instance.Settings.SelectedProjectVersion;
        }



        public delegate void ProjectVersionChangedDelegate(object sender, ProjectVersionChangedArg args);

        public static event ProjectVersionChangedDelegate MyProjectVersionChangedEvent;

        private void projectVersionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Singleton.Instance.Settings.SelectedProjectVersion = projectVersionSelector.SelectedItem.ToString();

            MyProjectVersionChangedEvent?.Invoke(this, new ProjectVersionChangedArg(projectVersionSelector.SelectedItem.ToString()));
        }
    }
}
