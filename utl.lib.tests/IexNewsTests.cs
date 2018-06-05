using iex.lib;
using iex.lib.DataProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace utl.lib.tests
{
    [TestClass]
    public class IexNewsTests
    {
        [TestMethod]
        public void GetNews()
        {
            var sut = new IEXDataProvider();
            var news = sut.GetNews("TWTR");
            Assert.IsNotNull(news);
        }
    }
}