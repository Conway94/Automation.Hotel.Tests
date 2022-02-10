namespace Shared
{
  public static partial class Elements
  {
    public const string Booking_Page = "body";

    public const string Website_Header = "body > div.container";
    
    public const string Bookings_Container = "#bookings";

    public const string FirstName_String = "//h3[contains (text(),'Firstname')]";
    public const string FirstName_TextBox = "#firstname";

    public const string Surname_String = "//h3[contains (text(),'Surname')]";
    public const string Surname_TextBox = "#lastname";

    public const string Price_String = "//h3[contains (text(),'Price')]";
    public const string Price_TextBox = "#totalprice";

    public const string Deposit_String = "//h3[contains (text(),'Deposit')]";
    public const string Deposit_DrownDown = "#depositpaid";
    public const string Deposit_DrownDown_true = "##depositpaid > option:nth-child(1)";
    public const string Deposit_DrownDown_false = "##depositpaid > option:nth-child(2)";

    public const string CheckIn_String = "//h3[contains (text(),'Check-in')]";
    public const string CheckIn_TextBox = "#checkin";
    public const string CheckIn_Calender = "#ui-datepicker-div > div";

    public const string CheckOut_String = "//h3[contains (text(),'Check-out')]";
    public const string CheckOut_TextBox = "#checkout";
    public const string CheckOut_Calender = "#ui-datepicker-div > div";

    public const string Save_Button = "input[value=' Save ']";
    public const string Delete_Button = "input[value='Delete']";
  }
}
