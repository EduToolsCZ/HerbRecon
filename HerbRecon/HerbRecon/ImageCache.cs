using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HerbRecon.Tools;

namespace HerbRecon
{
    public class ImageCache
    {
        /// <summary>
        ///     The path to the directory where all the images are stored
        /// </summary>
        private const string CachePath = @"..\data\images";

        /// <summary>
        ///     Downloads all needed images from the <see cref="HerbListManager.HerbDatabase"/> to the cache. Use <see cref="GetImage"/> to retrieve an image
        /// </summary>
        /// <returns></returns>
        public static async Task RefreshCache()
        {
            var urls = HerbListManager.HerbDatabase.Herbs.Where(h => h.ImageUrls != null).SelectMany(h => h.ImageUrls).ToArray();
            if (!Directory.Exists(CachePath)) Directory.CreateDirectory(CachePath);
            using (var wc = new WebClient()) {
                foreach (var url in urls) {
                    var hash = HashHelper.ComputeMd5FromString(url);
                    var filename = Path.Combine(CachePath, hash + ".png");
                    if (!File.Exists(filename)) {
                        await wc.DownloadFileTaskAsync(url, filename);
                    }
                }
            }
        }

        /// <summary>
        ///     Retrieves an image from the specified url, uses the cahce if available, otherwise downloads it
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<Image> GetImage(string url)
        {
            var hash = HashHelper.ComputeMd5FromString(url);
            var filename = Path.Combine(CachePath, hash + ".png");
            if (!Directory.Exists(CachePath)) Directory.CreateDirectory(CachePath);
            using (var wc = new WebClient()) {
                if (!File.Exists(filename)) {
                    await wc.DownloadFileTaskAsync(url, filename);
                }
            }
            return Image.FromFile(filename);
        }
    }
}
