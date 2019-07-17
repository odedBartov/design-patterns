using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy;
using Strategy.Strategies;

namespace StrategyTest
{
    [TestClass]
    public class StrategyTest
    {
        Eagle eagle;
        Cat cat;
        CanNotFly canNotFly;
        CanFly canFly;

        [TestInitialize]
        public void Init()
        {
            eagle = new Eagle();
            cat = new Cat();
            canFly = new CanFly();
            canNotFly = new CanNotFly();
        }

        [TestMethod]
        public void CanFlyTryToFly_ShouldSucceed()
        {
            string result = eagle.TryTFly();
            Assert.AreEqual(canFly.Fly(), result);
        }

        [TestMethod]
        public void CantFlyTryToFly_ShouldFails()
        {
            string result = cat.TryTFly();
            Assert.AreEqual(canNotFly.Fly(), result);
        }

        [TestMethod]
        public void ChangeFlyAbility_ShouldReturnTheOposite()
        {
            eagle.SetFlyable(canNotFly);
            cat.SetFlyable(canFly);

            string eagleResult = eagle.TryTFly();
            string catResult = cat.TryTFly();

            Assert.AreEqual(canNotFly.Fly(), eagleResult);
            Assert.AreEqual(canFly.Fly(), catResult);
        }
    }
}
