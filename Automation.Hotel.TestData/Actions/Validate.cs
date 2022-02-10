using System;
using Automation.Hotel.TestData.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class ValidateAction : SeleniumHelper
  {
    public void ElementVisibility(string selector, bool isVisible)
    {
      try
      {
        bool isDisplayed = Driver.FindElement(By.CssSelector(selector)).Displayed;

        Assert.AreEqual(isVisible, isDisplayed, $"The Visibility of {selector}");
      }
      catch (Exception e)
      {
        throw;
      }
    }
  }
}
