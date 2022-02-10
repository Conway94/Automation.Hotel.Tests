using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using OpenQA.Selenium;
using Shared;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class FirstName : SetupHelper
  {
    [SetUp]
    public void Setup()
    {
      Website.Actions.Text.ClearText(Elements.FirstName_TextBox);
    }

    [TestCase("Firstname", TestName = "Valid FirstName String")]
    public void Valid_FirstName_ValidateString(string firstName)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.FirstName_String, firstName);
    }

    [TestCase(TestName = "Valid Empty Firstname Field ")]
    public void Valid_FirstName_ValidateField()
    {
      Website.Actions.Text.ValidateTextSelector(Elements.FirstName_TextBox, string.Empty);
    }
  }
}
