using System;
using Automation.Hotel.TestData.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.Hotel.TestData.Actions
{
  public class TextAction : SeleniumHelper
  {
    /// <summary>
    /// Attempts to insert specified text into a specified element.
    /// </summary>
    /// <param name="cssSelector">Represents the selector element derived from the p.o.m.</param>
    /// <param name="inputText">The specified text value to be inserted into the element.</param>
    public void InsertTextSelector(string cssSelector, string inputText)
    {
      try
      {
        IWebElement field = Driver.FindElement(By.CssSelector(cssSelector));
        field.Click();
        field.SendKeys(inputText);
        field.SendKeys(Keys.Enter);
        Console.WriteLine($"Successfully Inserted Text '{inputText}' into {cssSelector} field");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Insert Text '{inputText}' into {cssSelector} field was unsuccessful");
        throw;
      }
    }

    /// <summary>
    /// Attempts to insert specified text into a specified element.
    /// </summary>
    /// <param name="xpath">Represents the xpath element derived from the p.o.m.</param>
    /// <param name="inputText">The specified text value to be inserted into the element.</param>
    public void InsertTextXpath(string xpath, string inputText)
    {
      try
      {
        IWebElement field = Driver.FindElement(By.XPath(xpath));
        field.Click();
        field.SendKeys(inputText);
        field.SendKeys(Keys.Enter);
        Console.WriteLine($"Successfully Inserted Text '{inputText}' into {xpath} field");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Insert Text '{inputText}' into {xpath} field was unsuccessful");
        throw;
      }
    }

    /// <summary>
    /// Attempts to validate specified text against the actual element text.
    /// </summary>
    /// <param name="selector">Represents the selector element derived from the p.o.m.</param>
    /// <param name="text">The specified text value to be validated against the webpage element value.</param>
    public void ValidateTextSelector(string selector, string text)
    {
      IWebElement element = null;
      try
      {
        element = Driver.FindElement(By.CssSelector(selector));
        Assert.AreEqual(element.Text, text);
        Console.WriteLine($"Successfully Validated Expected Text : '{text}' Is Equal to Actual Text : {element.Text}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Validation Unsuccessful Expected Text : '{text}' Is Not Equal to Actual Text : {element.Text}");
        throw;
      }
    }

    /// <summary>
    /// Attempts to validate specified text against the actual element text.
    /// </summary>
    /// <param name="selector">Represents the selector element derived from the p.o.m.</param>
    /// <param name="text">The specified text value to be validated against the webpage element value.</param>
    public void ValidateTextXpath(string xpath, string text)
    {
      IWebElement element = null;
      try
      {
        element = Driver.FindElement(By.XPath(xpath));
        Assert.AreEqual(element.Text, text);
        Console.WriteLine($"Successfully Validated Expected Text : '{text}' Is Equal to Actual Text : {element.Text}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Validation Unsuccessful Expected Text : '{text}' Is Not Equal to Actual Text : {element.Text}");
        throw;
      }
    }

    /// <summary>
    /// Attempts to clear text of specified element.
    /// </summary>
    /// <param name="selector">Represents the selector element derived from the p.o.m.</param>
    public void ClearText(string selector)
    {
      
      try
      {
        IWebElement field = Driver.FindElement(By.CssSelector(selector));
        field.Clear();
        Assert.That(field.Text == string.Empty, $"Clear Text on Element {selector}");
      }
      catch (Exception e)
      {
        throw;
      }
    }
  }
}
