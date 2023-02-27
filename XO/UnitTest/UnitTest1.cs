using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using XO;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void SizeTest()
        {
            Form1 size = new Form1();
            int resulTest = 3;

            Assert.AreEqual("3x3",size.BoardTest(resulTest));

        }
        [TestMethod()]
        public void SizeTest2()
        {
            Form2 size2 = new Form2();
            int resulTest = 4;

            Assert.AreEqual("4x4", size2.BoardTest(resulTest));

        }
        [TestMethod()]
        public void SizeTest3()
        {
            _5x5 size3 = new _5x5();
            int resulTest = 5;

            Assert.AreEqual("5x5", size3.BoardTest(resulTest));

        }
        [TestMethod()]
        public void WhoWinTest()
        {
            _5x5 whowin = new _5x5();
            string whowins = "Current Move: Player 2";

            Assert.AreEqual("X", whowin.WhoWin(whowins));
        }
        [TestMethod()]
        public void WhoWinTestO()
        {
            _5x5 whowin2 = new _5x5();
            string whowins = "Current Move: Player 1";

            Assert.AreEqual("O", whowin2.WhoWinO(whowins));
        }
        [TestMethod()]
        public void CheckWin4x4()
        {
            Form2 check = new Form2();
            string win = "X";

            Assert.AreEqual("true", check.Check(win));
        }
        [TestMethod()]
        public void CheckWin5x5()
        {
            _5x5 check1 = new _5x5();
            string win = "X";

            Assert.AreEqual("true", check1.Check(win));
        }
    }
}
