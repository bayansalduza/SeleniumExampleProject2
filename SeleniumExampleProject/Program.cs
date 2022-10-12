using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using SeleniumExampleProject;
using log4net.Config;
using log4net;
using System.Reflection;
using Log4NetSample.LogUtility;

var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("Log4net.config"));
var _logger = new Logger();

ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
chromeDriverService.HideCommandPromptWindow = true;

IWebDriver webDriver = new ChromeDriver(chromeDriverService);
webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("WebSiteURL"));
_logger.Info("Website opening");

WebDriverExtensions driverExtensions = new WebDriverExtensions(webDriver);

driverExtensions.SendIdKeys("k-cssa", "7");
driverExtensions.SendIdKeys("k-gkta", "12");
driverExtensions.SendIdKeys("k-gtta", "15");
driverExtensions.SendIdKeys("k-ektcs", "10");
driverExtensions.SendIdKeys("k-ettcs", "6");
driverExtensions.SendIdKeys("k-buim", "5000");
driverExtensions.SendIdKeys("k-ggp", "300");
driverExtensions.SendClassClick(".btn-blue");
Thread.Sleep(1500);
_logger.Info("First page filled");

driverExtensions.SendIdKeys("c-ama", "150");
driverExtensions.SendIdKeys("c-cso", "5");
driverExtensions.SendIdKeys("c-csop", "144");
driverExtensions.SendIdKeys("c-ok", "25");
driverExtensions.SendIdKeys("c-csao", "80");
driverExtensions.SendClassClick(".btn-blue");
Thread.Sleep(1500);
_logger.Info("Second page filled");

driverExtensions.SendIdKeys("y-aya", "90");
driverExtensions.SendIdKeys("y-myo", "65");
driverExtensions.SendIdKeys("y-op", "900");
driverExtensions.SendIdKeys("y-ok", "10");
driverExtensions.SendIdKeys("y-oa", "5");
driverExtensions.SendClassClick(".fayda-calculate");
Thread.Sleep(5000);
_logger.Info("The third page is filled and calculating.");

Console.WriteLine(webDriver.FindElement(By.Id("sgpf-number")).Text.Split(' ')[1]);






