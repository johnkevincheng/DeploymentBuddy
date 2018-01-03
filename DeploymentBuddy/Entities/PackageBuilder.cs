using System;

namespace DeploymentBuddy.Entities
{
    public class PackageBuilder
    {
        public Guid Id { get; set; }

        public String PackageLabel { get; set; }

        public String PackageName { get; set; }

        public String SourceFolder { get; set; }

        public String DestinationFolder { get; set; }
    }
}
