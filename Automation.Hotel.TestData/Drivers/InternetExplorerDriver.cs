using System;
using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Automation.Hotel.TestData.Drivers
{
  public class InternetExplorerDriver : SeleniumHelper
  { 
    private static InternetExplorerDriverService InternetExplorerDriverService;

    public InternetExplorerDriver()
    {
      InternetExplorerDriverService = InternetExplorerDriverService.CreateDefaultService();
      InternetExplorerDriverService.HideCommandPromptWindow = true;
      Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
      Driver = new OpenQA.Selenium.IE.InternetExplorerDriver(InternetExplorerDriverService);
      Driver.Manage().Window.Maximize();
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }
  }
}
