using Ionic.Zip;
using System;
using System.IO;

namespace DeploymentBuddy
{
    /// <summary>
    /// Provides various utility functions.
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Package the target folder into a zip file.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="packageFilePath"></param>
        /// <param name="zipProgress"></param>
        /// <returns></returns>
        public static (Boolean Success, Exception Exception, String Message) PackageFolder(String sourceFolder, String packageFilePath, EventHandler<SaveProgressEventArgs> zipProgress)
        {
            try
            {
                if (File.Exists(packageFilePath))
                    File.Delete(packageFilePath);
            }
            catch (Exception ex)
            {
                //errorProvider1.SetError(managerLabel, $"Encountered an exception while deleting existing package:\n\n{ex.Message}");
                return (false, ex, $"Encountered an exception while deleting existing package:\n\n{ex.Message}");
            }

            using (var zip = new ZipFile())
            {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                if (zipProgress != null) zip.SaveProgress += zipProgress;
                zip.AddDirectory(sourceFolder);

                try
                {
                    zip.Save(packageFilePath);
                }
                catch (Exception ex)
                {
                    //errorProvider1.SetError(managerLabel, $"Encountered an exception while creating the package:\n\n{ex.Message}");
                    return (false, ex, $"Encountered an exception while creating the package:\n\n{ex.Message}");
                }
            }

            return (true, null, String.Empty);
        }

        /// <summary>
        /// Package the target folder into a zip file.
        /// </summary>
        /// <param name="sourceFolder"></param>
        /// <param name="packageFilePath"></param>
        /// <returns></returns>
        public static (Boolean Success, Exception Exception, String Message) PackageFolder(String sourceFolder, String packageFilePath)
        {
            return PackageFolder(sourceFolder, packageFilePath, null);
        }
    }
}
