using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace UITestMobile
{

    public enum Area
    {
        AutoMoto,
        Electronic,
        Tools,
        Sport,
        Work
    }

    public enum Section
    {
        Disks,
        Wheels,
        Fluids
    }

    public static class AppSteps
    {
        public static void PassInternalInstruction()
        {
            while (!AppInitializer.GetApp().Query(c => c.Id("nextView"))[0].Text.Equals("Перейти в каталог"))
            {
                AppInitializer.GetApp().Tap(c => c.Id("nextView"));
            }
            AppInitializer.GetApp().Tap(c => c.Id("nextView"));
        }

        public static void GoToArea(Area area)
        {
            switch (area)
            {
                case Area.AutoMoto:
                    {
                        AppInitializer.GetApp().Tap(c=>c.Text("Авто и мото"));
                        break;
                    }
                case Area.Electronic:
                    {
                        AppInitializer.GetApp().Tap(c => c.Text("Электроника"));
                        break;
                    }
                case Area.Sport:
                    {
                        AppInitializer.GetApp().Tap(c => c.Text("Красота и спорт"));
                        break;
                    }
            }
        }

        public static void GoToSection(Section section)
        {
            switch (section)
            {
                case Section.Disks:
                    {
                        AppInitializer.GetApp().Tap(c => c.Text("Диски"));
                        break;
                    }
                case Section.Wheels:
                    {
                        AppInitializer.GetApp().Tap(c => c.Text("Шины"));
                        break;
                    }
            }
        }

        public static bool IsElementWithTextPresent(string elementText)
        {
            return AppInitializer.GetApp().Query(c => c.Text(elementText))[0].Enabled;
    }
}
}
