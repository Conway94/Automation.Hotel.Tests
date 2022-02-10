using System;
using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class SelectAction : SeleniumHelper
  {
    /// <summary>
    /// Attempts to opens the drop down element and select the specified value within.
    /// </summary>
    /// <param name="selector">Represents the css selector element derived from the p.o.m</param>
    /// <param name="selectValue">Represents the value to be selected from the drop down element.</param>
    public void DropDowns(string selector, string selectValue)
    {
      try
      {
        IWebElement element = Driver.FindElement(By.CssSelector(selector));
        element.Click();
        element.SendKeys(selectValue);
        element.SendKeys(Keys.Enter);
        Console.WriteLine($"Successfully Selected {selectValue} from {selector}");
      }
      catch (Exception)
      {
        Console.WriteLine($"Attempt to Select {selectValue} from {selector} was unsuccessful");
        throw;
      }
    }
  }
}
