using System;
using Automation.Hotel.TestData.Helper;
using Automation.Hotel.TestData.Interface;
using Automation.Hotel.Tests.Setup;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Shared;

namespace Automation.Hotel.Tests.Setup
{
  public class SetupHelper : SeleniumHelper
  {
    public Website Website = new Website();
  }
}

[SetUpFixture]
public class SetupFixture : SetupHelper
{
  [OneTimeSetUp]
  public void OneTimeSetup()
  {
    Website.Actions.Launch.Chrome(Defaults.HotelUrl);
  }

  [OneTimeTearDown]
  public void OneTimeTearDown()
  {
    Website.Actions.Quit.Execute();
  }
}