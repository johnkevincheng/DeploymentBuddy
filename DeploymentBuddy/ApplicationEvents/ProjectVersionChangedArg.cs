using System;

namespace DeploymentBuddy.ApplicationEvents
{
    public class ProjectVersionChangedArg : EventArgs
    {
        public ProjectVersionChangedArg(String newProjectVersion)
        {
            this.NewProjectVersion = newProjectVersion;
        }

        public String NewProjectVersion { get; set; }
    }
}
