using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace DragAndDrop.Driver
{
    internal class WebDriver
    {
        public static OpenQA.Selenium.IWebDriver? Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://demoqa.com/droppable");
        }


        public static void CleanUp()
        {
            Instance?.Quit();
        }
    }
}
