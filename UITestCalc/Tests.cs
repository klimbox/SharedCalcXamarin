using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestCalc
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;
        private ICalcScreen cs;

        public Tests(Platform platform)
        {
            this.platform = platform;
            if (platform == Platform.Android)
            {
                cs = new CalcScreen();
            }
            else
            {
                //db = new IosAuthScreen();
            }

            app = AppInitializer.StartApp(platform);
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            app = AppInitializer.StartApp(platform);
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app.Tap(cs.btnClean);
        }

        [Test]
        public void SimpleBtn0Test()
        {
            app.Tap(cs.btn0);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("0", s);
        }

        [Test]
        public void SimpleBtn1Test()
        {
            app.Tap(cs.btn1);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("1", s);
        }

        [Test]
        public void SimpleBtn2Test()
        {
            app.Tap(cs.btn2);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("2", s);
        }

        [Test]
        public void SimpleBtn3Test()
        {
            app.Tap(cs.btn3);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("3", s);
        }

        [Test]
        public void SimpleBtn4Test()
        {
            app.Tap(cs.btn4);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("4", s);
        }

        [Test]
        public void SimpleBtn5Test()
        {
            app.Tap(cs.btn5);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("5", s);
        }

        [Test]
        public void SimpleBtn6Test()
        {
            app.Tap(cs.btn6);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("6", s);
        }

        [Test]
        public void SimpleBtn7Test()
        {
            app.Tap(cs.btn7);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("7", s);
        }

        [Test]
        public void SimpleBtn8Test()
        {
            app.Tap(cs.btn8);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("8", s);
        }

        [Test]
        public void SimpleBtn9Test()
        {
            app.Tap(cs.btn9);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("9", s);
        }

        [Test]
        public void SimpleBtnAddTest()
        {
            app.Tap(cs.btnAdd);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual(" + ", s);
        }

        [Test]
        public void SimpleBtnSubTest()
        {
            app.Tap(cs.btnSub);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual(" - ", s);
        }

        [Test]
        public void SimpleBtnMulTest()
        {
            app.Tap(cs.btnMul);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual(" * ", s);
        }

        [Test]
        public void SimpleBtnDivTest()
        {
            app.Tap(cs.btnDiv);
            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual(" / ", s);
        }

        [Test]
        public void RealJob5Add5Test()
        {
            app.Tap(cs.btn5);
            app.Tap(cs.btnAdd);
            app.Tap(cs.btn5);
            app.Tap(cs.btnCount);

            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("10", s);
        }

        [Test]
        public void RealJob7Sub5Test()
        {
            app.Tap(cs.btn7);
            app.Tap(cs.btnSub);
            app.Tap(cs.btn5);
            app.Tap(cs.btnCount);

            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("2", s);
        }

        [Test]
        public void RealJob5Mul5Test()
        {
            app.Tap(cs.btn5);
            app.Tap(cs.btnMul);
            app.Tap(cs.btn5);
            app.Tap(cs.btnCount);

            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("25", s);
        }

        [Test]
        public void RealJob10Div5Test()
        {
            app.Tap(cs.btn1);
            app.Tap(cs.btn0);
            app.Tap(cs.btnDiv);
            app.Tap(cs.btn5);
            app.Tap(cs.btnCount);

            AppResult res = app.Query(cs.Screen)[0];
            string s = res.Text;
            Assert.AreEqual("2", s);
        }
    }
}

