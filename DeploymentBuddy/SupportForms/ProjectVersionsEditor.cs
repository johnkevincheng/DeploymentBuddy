using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeploymentBuddy.SupportForms
{
    public partial class ProjectVersionsEditor : Form
    {
        public ProjectVersionsEditor(List<String> projectVersions)
        {
            InitializeComponent();

            projectVersionsInput.Text = String.Join(Environment.NewLine, projectVersions);
        }

        public List<String> ProjectVersionsData { get; set; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ProjectVersionsData = projectVersionsInput.Text.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList<String>();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
