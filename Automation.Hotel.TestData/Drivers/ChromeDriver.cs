using OpenQA.Selenium.Chrome;
using System;
using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium.Support.UI;

namespace Automation.Hotel.TestData.Drivers
{
  public class ChromeDriverHelper : SeleniumHelper
  {
    private const string DisableInfoBars = "--disable-infobars";
    private static ChromeDriverService ChromeDriverService;

    public ChromeDriverHelper()
    {
      ChromeDriverService = ChromeDriverService.CreateDefaultService();
      ChromeDriverService.HideCommandPromptWindow = true;
      var chromeOptions = new ChromeOptions();
      chromeOptions.AddArguments(DisableInfoBars);
      Driver = new ChromeDriver(ChromeDriverService, chromeOptions);
      Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
      Driver.Manage().Window.Maximize();
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }
  }
}
