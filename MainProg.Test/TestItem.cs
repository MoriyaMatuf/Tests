using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace MainProg.Test
{[TestFixture]
    public class TestItem
    {
        [Test]
        [Category ("UNitTest-check Action") ]
        public void TestPlus()
        {
            Items items = new Items();

            int ret=items.Plus(5,4);
            Assert.AreEqual(9, ret);
        }

        [Test]
        public void TestMinus()
        {
            Items items = new Items();

            int ret = items.Minus(5, 4);
            Assert.AreEqual(1, ret);
        }


    }
}
