using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using Shared;
using System.Threading.Tasks;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class CheckOut : SetupHelper
  {
    [TestCase("Check-out", TestName = "Valid CheckIn String")]
    public void CheckOutString(string checkOut)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.CheckOut_String, checkOut);
    }

    [TestCase(TestName = "Valid Empty CheckOut Field ")]
    public void CheckOutField()
    {
      Website.Actions.Text.ValidateTextSelector(Elements.CheckOut_TextBox, string.Empty);
    }
  }
}
