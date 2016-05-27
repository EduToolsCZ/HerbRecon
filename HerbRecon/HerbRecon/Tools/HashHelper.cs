using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HerbRecon.Tools
{
    public static class HashHelper
    {
        private static readonly MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
        /// <summary>
        /// Converts byte array to a hexadecimal string in the 0a format
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static string BytesToHexaString(byte[] bytes)
        {
            return bytes == null ? null : BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        /// <summary>
        /// Compares two hashes, retuns true if they are same
        /// </summary>
        /// <param name="hash1"></param>
        /// <param name="hash2"></param>
        /// <returns></returns>
        private static bool AreHashesSame(byte[] hash1, byte[] hash2)
        {
            return hash1.Length == hash2.Length && hash1.SequenceEqual(hash2);
        }

        /// <summary>
        /// Compares two files with hash. Returns true if they are same
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns></returns>
        public static bool AreFilesSame(string path1, string path2)
        {
            if(!(File.Exists(path1) && File.Exists(path2))) throw new FileNotFoundException("Specified path does not exist");
            return AreHashesSame(ComputeMd5FromFileInBytes(path1), ComputeMd5FromFileInBytes(path2));
        }

        public static string ComputeMd5FromBytes(byte[] bytes)
        {
            return BytesToHexaString(Md5.ComputeHash(bytes));
        }

        /// <summary>
        /// Computes hash from a string, returns the 0a form.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="utf8"></param>
        /// <returns></returns>
        public static string ComputeMd5FromString(string s, bool utf8 = false)
        {
            var encoding = utf8 ? Encoding.UTF8 : Encoding.ASCII;
            return ComputeMd5FromBytes(encoding.GetBytes(s));
        }

        /// <summary>
        /// Computes hash of a file with a performance-friendly method
        /// </summary>
        /// <param name="path">The path of the file</param>
        /// <returns></returns>
        public static string ComputeMd5FromFile(string path)
        {
            return BytesToHexaString(ComputeMd5FromFileInBytes(path));
        }

        /// <summary>
        /// Computes hash of a file with a performance-friendly method
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static byte[] ComputeMd5FromFileInBytes(string path)
        {
            if (!File.Exists(path)) return null;
            byte[] md5;
            using (var fs = new FileStream(path, FileMode.Open)) {
                md5 = Md5.ComputeHash(fs);
            }
            return md5;
        }
    }
}
