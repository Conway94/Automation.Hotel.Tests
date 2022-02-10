using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using Shared;
using System.Threading.Tasks;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class Price : SetupHelper
  {
    [TestCase("Price", TestName = "Valid Price String")]
    public void PriceString(string price)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.Price_String, price);
    }

    [TestCase(TestName = "Valid Empty Price Field ")]
    public void PriceField()
    {
      Website.Actions.Text.ValidateTextSelector(Elements.Price_TextBox, string.Empty);
    }
  }
}
