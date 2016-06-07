using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerbRecon
{
    public static class Extensions
    {
        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString) {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark) {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        ///     Computes the distance between two strings.
        /// </summary>
        public static int LevenshteinDistance(this string source, string target)
        {
            int n = source.Length;
            int m = target.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0) {
                return m;
            }

            if (m == 0) {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++) {
            }

            for (int j = 0; j <= m; d[0, j] = j++) {
            }

            // Step 3
            for (int i = 1; i <= n; i++) {
                //Step 4
                for (int j = 1; j <= m; j++) {
                    // Step 5
                    int cost = (target[j - 1] == source[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        /// <summary>
        ///     Removes all instances of a char <paramref name="c"/> in the string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string RemoveChar(this string s, char c)
        {
            return s.Replace(c.ToString(), "");
        }

        public static void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Formats the information about the exception into a string. Contains information about the <see cref="Exception.HResult"/>, the type of the exception and the exception message.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string GetDetailedMessage(this Exception ex)
        {
            return $"Error code {ex.HResult}\nException {ex.GetType().Name}\n{ex.Message}";
        }

        /// <summary>
        ///     Returns only the first three version indicators, specification - http://semver.org/
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static string GetSemanticVersion(this Version v)
        {
            return $"{v.Major}.{v.Minor}.{v.MajorRevision}";
        }
    }
}
