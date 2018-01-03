using System;
using System.Collections.Generic;

namespace DeploymentBuddy.Entities
{
    [Serializable]
    public class ApplicationConfigurations
    {
        public List<String> ProjectVersions { get; set; } = new List<String>();

        public String SelectedProjectVersion { get; set; } = String.Empty;

        public List<PackageBuilder> PackageBuilders { get; set; } = new List<PackageBuilder>();

        public List<DeploymentFolderManager> DeploymentFolderManagers { get; set; } = new List<DeploymentFolderManager>();
    }
}
