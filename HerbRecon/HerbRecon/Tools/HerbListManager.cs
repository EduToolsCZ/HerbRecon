using System.IO;
using System.Net;
using System.Threading.Tasks;
using HerbLib;
using Newtonsoft.Json;

namespace HerbRecon.Tools
{
    /// <summary>
    ///     Allows you to update your local herb database
    /// </summary>
    public static class HerbListManager
    {
        private const string HerbsJsonUrl = @"http://sorashi.xf.cz/projects/herbrecon/herbs/herbs.json";
        private const string HerbsMd5Url = @"http://sorashi.xf.cz/projects/herbrecon/herbs/md5.txt";


        private const string HerbDataFolder = @"..\data";

        public static HerbCollection HerbDatabase;
        private static readonly string HerbFilePath = Path.Combine(HerbDataFolder, "herbs.json");

        private static async Task<string> GetRequestAsync(string url)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            using (var response = await request.GetResponseAsync())
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        ///     Checks if there is an update available for the herb list
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> UpdateAvailableAsync()
        {
            if (!File.Exists(HerbFilePath)) return true;
            var remoteMd5 = (await GetRequestAsync(HerbsMd5Url)).Trim();
            var localMd5 = HashHelper.ComputeMd5FromFile(HerbFilePath);
            if (remoteMd5 == localMd5) return false;
            return true;
        }

        /// <summary>
        ///     Checks for update and updates if so
        /// </summary>
        /// <returns></returns>
        public static async Task UpdateAsync()
        {
            if (!await UpdateAvailableAsync())
            {
                HerbDatabase = JsonConvert.DeserializeObject<HerbCollection>(File.ReadAllText(HerbFilePath));
            }
            var json = await GetRequestAsync(HerbsJsonUrl);
            if (!Directory.Exists(HerbDataFolder)) Directory.CreateDirectory(HerbDataFolder);
            File.WriteAllText(HerbFilePath, json);
            LoadFromTheFile();
        }

        /// <summary>
        ///     Loads the <see cref="HerbDatabase"/> from the json file; does not check if it already exits and therefore throws exceptions
        /// </summary>
        public static void LoadFromTheFile()
        {
            var json = File.ReadAllText(HerbFilePath);
            HerbDatabase = JsonConvert.DeserializeObject<HerbCollection>(json);
        }

        /// <summary>
        ///     Checks if the herbs.json file exists and returns true if it does
        /// </summary>
        /// <returns></returns>
        public static bool FileExists()
        {
            return File.Exists(HerbFilePath);
        }
    }
}