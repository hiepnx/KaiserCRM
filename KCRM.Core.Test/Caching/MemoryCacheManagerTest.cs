using System;
using KCRM.Core.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KCRM.Core.Test.Caching
{
    [TestClass]
    public class MemoryCacheManagerTest
    {
        [TestMethod]
        public void can_get_and_set_object()
        {
            MemoryCacheManager mc = new MemoryCacheManager();
            mc.Set("key1", 20, 60);
            int val = mc.Get<int>("key1");
            Assert.AreEqual(20, val);
        }
        [TestMethod]
        public void can_check_if_set()
        {
            MemoryCacheManager mc = new MemoryCacheManager();
            mc.Set("key1", 20, 60);
            Assert.AreEqual(true, mc.IsSet("key1"));
        }
    }
}
