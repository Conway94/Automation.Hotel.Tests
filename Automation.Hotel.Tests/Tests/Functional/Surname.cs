using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using Shared;
using System.Threading.Tasks;

namespace Automation.Hotel.Tests.Tests.Functional
{
  [TestFixture]
  public class Surname : SetupHelper
  {
    [TestCase("Surname",TestName = "Valid Surname String")]
    public void SurnameString(string surname)
    {
      Website.Actions.Text.ValidateTextXpath(Elements.Surname_String, surname);
    }

    [TestCase(TestName = "Valid Empty Surname Field ")]
    public void SurnameField()
    {
      Website.Actions.Text.ValidateTextSelector(Elements.Surname_TextBox, string.Empty);
    }
  }
}
