using System;
using KCRM.Core.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KCRM.Core.Test.Caching
{
    [TestClass]
    public class PerRequestCacheManagerTest
    {
        [TestMethod]
        public void can_get_set_data()
        {
            PerRequestCacheManager pcm = new PerRequestCacheManager(new Fakes.FakeHttpContext().ConvertToHttpContextBase());
            pcm.Set("test1",30,60);
            Assert.AreEqual(pcm.Get<int>("test1"),30);
        }
        

    }
}
