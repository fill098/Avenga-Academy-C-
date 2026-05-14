#region Working with Dates

using System.Globalization;

DateTime date = new DateTime();
Console.WriteLine(date);


DateTime custumDate = new DateTime(1993, 08, 27, 11, 23, 55);
Console.WriteLine(custumDate);

string stringDateFirst = "15.12.2013";
string stringDateSecond = "15/12/2015";
string stringDateThird = "15/12/15";
string stringDateFourh = "dec.15.15";
string stringDateFifth = "15-12-15";

DateTime stringDate =  DateTime.Parse(stringDateFirst);

Console.WriteLine(stringDate);

DateTime today = DateTime.Now;
Console.WriteLine(today);

Console.WriteLine(today.AddDays(2));
Console.WriteLine(today.AddDays(-2));

Console.WriteLine(today.Day);
Console.WriteLine(today.Date);
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.Month);
string dateFormat1 = today.ToString("MM/dd/yyyy");
string dateFormat2 = today.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-US"));

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(dateFormat1);
Console.WriteLine(dateFormat2);


string dateFormat3 = string.Format("Today is {0: MM/dd/yy}, {0:dddd}", today);

Console.WriteLine(dateFormat3);



#endregion