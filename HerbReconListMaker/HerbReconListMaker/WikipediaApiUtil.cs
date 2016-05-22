using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace HerbReconListMaker
{
    /// <summary>
    ///     Used to make Wikipedia API requests
    /// </summary>
    public static class WikipediaApiUtil
    {
        private const string UserAgent =
            @"HerbReconListMaker/1.0 (https://www.github.io/StudentToolsGroup/HerbRecon) NetFramework/4.5";

        /// <summary>
        ///     Edits the <paramref name="wr"/> UserAgent to be the application one and sets the method of the HTTP request to GET.
        /// </summary>
        /// <param name="wr"></param>
        private static void SetupRequestForWikipediaGet(HttpWebRequest wr)
        {
            wr.Method = "GET";
            wr.UserAgent = UserAgent;
        }

        /// <summary>
        ///     Returns the response of the GET request for the <paramref name="url" />, can <paramref name="followRedirects" />.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="followRedirects"></param>
        /// <returns></returns>
        private static string WikipediaGetRequest(string url, bool followRedirects = true)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            SetupRequestForWikipediaGet(request);
            var response = request.GetResponse();
            while (followRedirects && response.Headers["Location"] != null) {
                request = (HttpWebRequest)WebRequest.Create(response.Headers["Location"]);
                SetupRequestForWikipediaGet(request);
                response = request.GetResponse();
            }
            var sr = new StreamReader(response.GetResponseStream());
            var contents = sr.ReadToEnd();
            response.Dispose();
            sr.Dispose();
            return contents;
        }

        /// <summary>
        ///     Returns the Wikipedia page content
        /// </summary>
        /// <param name="title">The exact title of the page</param>
        /// <returns></returns>
        private static string GetContentUrl(string title)
        {
            return
                $"https://cs.wikipedia.org/w/api.php?action=query&titles={title}&prop=revisions|images&rvprop=content&rvsection=0&format=json";
        }

        /// <summary>
        ///     Returns url of a search query
        /// </summary>
        /// <param name="term">The term to search for on Wikipedia</param>
        /// <returns></returns>
        private static string GetSearchUrl(string term)
        {
            return
                $"https://cs.wikipedia.org/w/api.php?format=json&action=opensearch&search={term}&limit=10&format=json";
        }

        /// <summary>
        ///     Returns max. 10 titles of Wikipedia pages found when searching for the <paramref name="searchTerm" />
        /// </summary>
        /// <param name="searchTerm">The term to search for on Wikipedia</param>
        /// <returns></returns>
        public static WikipediaPageInfo[] Search(string searchTerm)
        {
            var url = GetSearchUrl(searchTerm);
            var array = JArray.Parse(WikipediaGetRequest(url));
            var length = array[1].Value<JArray>().Count;
            if (length == 0) return null;
            var pages = new WikipediaPageInfo[length];
            for (int i = 0; i < length; i++) {
                pages[i] = new WikipediaPageInfo()
                {
                    Title = array[1][i].Value<string>(),
                    Summary = array[2][i].Value<string>(),
                    Url = array[3][i].Value<string>()
                };
            }
            return pages;
        }

        /// <summary>
        ///     Gets the taxobox and images in JSON from the Wikipedia page identified with <paramref name="title"/>.
        /// </summary>
        /// <param name="title">The title of the page</param>
        /// <returns></returns>
        public static JObject GetPageContentInJson(string title)
        {
            return JObject.Parse(WikipediaGetRequest(GetContentUrl(title)));
        }
    }

    /// <summary>
    ///     Represents a Wikipedia page basic information
    /// </summary>
    public class WikipediaPageInfo
    {
        /// <summary>
        ///     The title of the page, i.e. the name
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///     The whole URL to the page
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Summary of the article, used in Google for example.
        /// </summary>
        public string Summary { get; set; }
    }
}