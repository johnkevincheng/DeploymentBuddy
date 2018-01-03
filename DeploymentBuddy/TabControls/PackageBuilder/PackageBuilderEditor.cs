using System;
using System.Linq;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.PackageBuilder
{
    public partial class PackageBuilderEditor : Form
    {
        public PackageBuilderEditor()
        {
            InitializeComponent();
        }

        public PackageBuilderEditor(Entities.PackageBuilder packageBuilder)
            : this()
        {
            PackageBuilderData = packageBuilder;
        }

        protected Guid PackageBuilderId { get; set; }

        public Entities.PackageBuilder PackageBuilderData
        {
            get
            {
                var value = new Entities.PackageBuilder();

                value.Id = PackageBuilderId;
                value.PackageLabel = packageBuilderLabel.Text;

                value.PackageName = packageNameInput.Text;
                value.SourceFolder = selectedSourceFolder.Text;
                value.DestinationFolder = selectedDestinationFolder.Text;

                return value;
            }
            set
            {
                PackageBuilderId = value.Id;
                packageBuilderLabel.Text = value.PackageLabel;

                packageNameInput.Text = value.PackageName;
                selectedSourceFolder.Text = value.SourceFolder;
                selectedDestinationFolder.Text = value.DestinationFolder;
            }
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                if (sender == chooseSourceFolder)
                    selectedSourceFolder.Text = folderBrowserDialog1.SelectedPath;
                else if (sender == chooseDestinationFolder)
                    selectedDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (PackageBuilderId == null || PackageBuilderId == new Guid())
            {
                PackageBuilderId = Guid.NewGuid();
                Singleton.Instance.Settings.PackageBuilders.Add(PackageBuilderData);
            }
            else
            {
                var element = Singleton.Instance.Settings.PackageBuilders.First(p => p.Id == PackageBuilderId);
                if (element != null)
                {
                    element.PackageLabel = PackageBuilderData.PackageLabel;
                    element.PackageName = PackageBuilderData.PackageName;
                    element.SourceFolder = PackageBuilderData.SourceFolder;
                    element.DestinationFolder = PackageBuilderData.DestinationFolder;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
