using System;
using Automation.Hotel.TestData.Helper;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class ClickAction : SeleniumHelper
  {
    /// <summary>
    /// Attempts to simulate a click event on a specified selector element.
    /// </summary>
    /// <param name="cssSelector">Represents the selector element derived from the p.o.m.</param>
    public void ElementSelector(string cssSelector)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.CssSelector(cssSelector));
        button.Click();
        Console.WriteLine($"Successfully Clicked {cssSelector}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {cssSelector} was unsuccessful");
        Console.WriteLine(e);
        throw;
      }
    }
  }
}