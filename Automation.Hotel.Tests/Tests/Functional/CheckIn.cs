using System.Data;
using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using OpenQA.Selenium;
using Shared;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class CheckIn : SetupHelper
  {
    [TestCase("Check-in", TestName = "Valid CheckIn String")]
    public void CheckInString(string checkIn)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.CheckIn_String, checkIn);
    }

    [TestCase(TestName = "Valid Empty CheckIn Field ")]
    public void CheckInField()
    {
      Website.Actions.Text.ValidateTextSelector(Elements.CheckIn_TextBox, string.Empty);
    }
  }
}
