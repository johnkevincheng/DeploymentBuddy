using DeploymentBuddy.Entities;
using System;
using System.IO;

namespace DeploymentBuddy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {

        }

        /// <summary>
        /// Save the settings file.
        /// </summary>
        /// <param name="fileLocation">The file path where the settings file shall be saved in.</param>
        public void Save(String fileLocation)
        {
            try
            {
                var xml = Serializers.SerializeXml(Instance.Settings);
                File.WriteAllText(fileLocation, xml);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Load the settings file.
        /// </summary>
        /// <param name="fileLocation">The file path where the settings file shall be loaded from.</param>
        public void Load(String fileLocation)
        {
            try
            {
                var fileContents = File.ReadAllText(fileLocation);
                Instance.Settings = Serializers.DeserializeXml<ApplicationConfigurations>(fileContents);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Gets or sets the application settings.
        /// </summary>
        public ApplicationConfigurations Settings { get; set; } = new ApplicationConfigurations();
    }
}
