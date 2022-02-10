using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class AttributeAction : SeleniumHelper
  {
    public string GetValue(string selector, string attribute)
    {
     return Driver.FindElement(By.CssSelector(selector)).GetAttribute(attribute);
    }
  }
}
