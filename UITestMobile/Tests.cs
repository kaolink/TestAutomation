using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using static System.Net.Mime.MediaTypeNames;

namespace UITestMobile
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            AppInitializer.GetInstance(platform);
        }

        [TearDown]
        public static void AfterEachTest()
        {
            AppInitializer.CloseApp();
        }

        [Test]
        public void CheckInstructionAppearance()
        {
            AppSteps.PassInternalInstruction();
            Assert.IsTrue(AppSteps.IsElementWithTextPresent("Электроника"), "Element 'Электроника' is not enabled");
        }

        [Test]
        public void OpenCarWheelsSection()
        {
            AppSteps.PassInternalInstruction();
            AppSteps.GoToArea(Area.AutoMoto);
            AppSteps.GoToSection(Section.Wheels);
            Assert.IsTrue(AppSteps.IsElementWithTextPresent("Автомобильные шины"),"Car wheels page is not opened");
        }
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   