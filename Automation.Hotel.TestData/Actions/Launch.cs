using Automation.Hotel.TestData.Drivers;
using Automation.Hotel.TestData.Helper;

namespace Automation.Hotel.TestData.Actions
{
  public class LaunchAction : SeleniumHelper
  {
    /// <summary>
    /// Launches a new instance of Chrome and navigates to the specified url.
    /// </summary>
    /// <param name="url">The address of the website.</param>
    public void Chrome(string url)
    {
      new ChromeDriverHelper();
      Driver.Navigate().GoToUrl(url);
    }

    /// <summary>
    /// Launches a new instance of Internet Explorer and navigates to the specified url.
    /// </summary>
    /// <param name="url">The address of the website.</param>
    public void InternetExplorer(string url)
    {
      new InternetExplorerDriver();
      Driver.Navigate().GoToUrl(url);
    }


  }
}
