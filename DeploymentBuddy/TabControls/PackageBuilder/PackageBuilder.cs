using System;
using System.Linq;
using System.Windows.Forms;

namespace DeploymentBuddy.TabControls.PackageBuilder
{
    public partial class PackageBuilder : UserControl
    {
        public PackageBuilder()
        {
            InitializeComponent();
        }

        private void PackageBuilder_Load(object sender, EventArgs e)
        {
            packageBuildersList.Controls.Clear();
            foreach (var packageBuilder in Singleton.Instance.Settings.PackageBuilders.OrderBy(p => p.PackageLabel))
                packageBuildersList.Controls.Add(new PackageBuilderInstance(packageBuilder));
        }

        private void newPackageBuilder_Click(object sender, EventArgs e)
        {
            var f = new PackageBuilderEditor();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Entities.PackageBuilder data = f.PackageBuilderData;

                packageBuildersList.Controls.Add(new PackageBuilderInstance(data));
            }
        }
    }
}
