using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures.Logic
{
    public class AppSettings
    {
        private const string k_AppSettingsPath = @".\AppSettings.xml";

        public bool RememberUser { get; set; }

        public DateTime LastLoginTime { get; set; } 

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
            LastLoginTime = DateTime.MinValue;
        }

        public void SaveToFile()
        {
            string appSettingsPath = k_AppSettingsPath;

            try
            {
                using (Stream stream = new FileStream(appSettingsPath, FileMode.Create))
                {
                    XmlSerializer xmlSerialize = new XmlSerializer(this.GetType());
                    xmlSerialize.Serialize(stream, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save app settings: {ex.Message}");
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings;

            try
            {
                string appSettingsPath = k_AppSettingsPath;

                using (Stream stream = new FileStream(appSettingsPath, FileMode.Open))
                {
                    XmlSerializer xmlSerialize = new XmlSerializer(typeof(AppSettings));

                    appSettings = xmlSerialize.Deserialize(stream) as AppSettings;
                }
            }
            catch
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }
    }
}
