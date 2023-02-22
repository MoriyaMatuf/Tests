using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace MainProg.Test
{
    [TestFixture]
    public class TestItem
    {
        [Test]
        //name test->
        [Category("UNitTest-check Action")]
        //לשחק מי לפני מי בסדר הטסטים
        [Order(1)]
        //פונקצייה שתרוץ בתחילת הקוד בדרך כלל משמשת לאיתחול db
        [SetUp]
        public void TestPlus()
        {
            Items items = new Items();

            int ret = items.Plus(5, 4);
            //value בודק את ה
            Assert.AreEqual(9, ret, "the result is good");
            //בודק את הרפרנס אותו דבר
            Assert.AreSame(ret, ret);
        }
        //  לא יבצע תטסט הזה לבינתיים 
        [Test, Ignore("i am not finish")]
        public void TestMinus()
        {
            Items items = new Items();

            int ret = items.Minus(5, 4);
            Assert.AreEqual(1, ret);
            //אם בטווח
            //Assert.That(ret, Is.InRange(1 - 0));
            //גדול מ
            //Assert.That(ret, Is.AtLeast(-1));
            //קטן /=
            //Assert.That(ret, Is.AtMost(100));
        }


    }
}
