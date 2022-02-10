using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class WaitAction : SeleniumHelper
  {
    public void ForElement(string selector)
    {
      Driver.FindElement(By.CssSelector(selector));
    }
  }
}
