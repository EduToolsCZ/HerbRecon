using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerbReconListMaker.Tests
{
    [TestClass]
    public class WikipediaApiUtilTests
    {
        [TestMethod]
        public void SearchTest()
        {
            var result = WikipediaApiUtil.Search("Sedmikraska");
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual("Sedmikráska chudobka", result[0].Title);
        }

        [TestMethod]
        public void GetPageContentInJsonTest()
        {
            var result = WikipediaApiUtil.GetPageContentInJson("Sedmikráska chudobka");
            var title = result["query"]["pages"]["306625"]["title"].ToString();
            Assert.AreEqual("Sedmikráska chudobka", title);
        }
    }
}