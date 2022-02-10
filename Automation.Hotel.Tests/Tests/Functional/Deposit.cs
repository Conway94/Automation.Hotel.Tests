using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using Shared;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class Deposit : SetupHelper
  {
    [TestCase("Deposit", TestName = "Valid Deposit String")]
    public void DepositString(string deposit)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.Deposit_String, deposit);
    }

   
  }
}
