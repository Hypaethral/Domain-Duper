using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping;

namespace WebScrapingTests
{
    [TestClass]
    public class TestWebWorker
    {
        [TestMethod]
        public void TestSearchTags()
        {
            var sourceInput = "<blah><meta content=\"noodp\" name=\"robots\"></blah>";
            var tagInput = "meta";
            var expectedTags = "<meta content=\"noodp\" name=\"robots\">";

            var actualTags = WebScraping.WebWorker.searchTags(sourceInput, tagInput).Trim();

            Assert.AreEqual(expectedTags, actualTags);
        }

        [TestMethod]
        public void TestScriptTag()
        {
            var sourceInput = "<div><script><meta content=\"noodp\" name=\"robots\">var=\"hello world\"</script><div></div></div>";
            var tagInput = "script";
            var expectedTags = "<script><meta content=\"noodp\" name=\"robots\">var=\"hello world\"</script>";

            var actualTags = WebScraping.WebWorker.searchTags(sourceInput, tagInput).Trim();

            Assert.AreEqual(expectedTags, actualTags);
        }
    }
}
