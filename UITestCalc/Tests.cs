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

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Simple()
        {
            app.Tap(cs.btn0);
            //app.Query(cs.Screen.)
            //app.Query(c => c.Id("tbScreen").Text);
        }
    }
}

