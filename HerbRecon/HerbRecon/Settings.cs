using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HerbRecon
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Settings
    {
        private const string SettingsPath = @"..\settings\settings.json";
        private const string SettingsDirectory = @"..\settings";

        [JsonProperty(PropertyName = "updateHerbList")]
        public bool UpdateHerbList { get; set; }

        /// <summary>
        ///     Default settings, used when there is not any previous save of the settings
        /// </summary>
        public static Settings Default => new Settings
        {
            UpdateHerbList = true
        };

        /// <summary>
        ///     Private constructor, beacuse settings can't be a constructable object
        /// </summary>
        private Settings() { }

        /// <summary>
        ///     Loads settings from the json file, or creates and returns the default settings
        /// </summary>
        /// <returns></returns>
        public static Settings Load()
        {
            if (File.Exists(SettingsPath))
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsPath));
            Default.Save();
            return Default;
        }
        /// <summary>
        ///     Saves the current settings to the json file
        /// </summary>
        public void Save()
        {
            if (!Directory.Exists(SettingsDirectory)) Directory.CreateDirectory(SettingsDirectory);
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(SettingsPath, json);
        }
    }
}
