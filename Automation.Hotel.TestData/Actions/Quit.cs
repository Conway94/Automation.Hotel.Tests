using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class QuitAction : SeleniumHelper
  {
    public void Execute()
    {
      Driver.Quit();
    }
  }
}
