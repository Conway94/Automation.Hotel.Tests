using System;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Shared;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class SaveButton : SetupHelper
  {
    [TestCase(TestName = "Valid Record Submit")]
    public void Valid_Save()
    {
      //Arrange
      var preSaveRecord = int.Parse(Website.Actions.Attribute.GetValue(Elements.Bookings_Container, "childElementCount"));
      Website.Actions.Text.InsertTextSelector(Elements.FirstName_TextBox, Defaults.FirstName);
      Website.Actions.Text.InsertTextSelector(Elements.Surname_TextBox, Defaults.Surname);
      Website.Actions.Text.InsertTextSelector(Elements.Price_TextBox, Defaults.Price);
      Website.Actions.Text.InsertTextSelector(Elements.CheckIn_TextBox, Defaults.CheckIn);
      Website.Actions.Text.InsertTextSelector(Elements.CheckOut_TextBox, Defaults.CheckOut);

      //Act
      Website.Actions.Click.ElementSelector(Elements.Save_Button);
      Wait.Until(driver => int.Parse(driver.FindElement(By.CssSelector(Elements.Bookings_Container)).GetAttribute("childElementCount")) == preSaveRecord + 1);
      var postSaveRecord = int.Parse(Website.Actions.Attribute.GetValue(Elements.Bookings_Container, "childElementCount"));

      //Assert
      Assert.Greater(postSaveRecord, preSaveRecord);
    }
  }
}
