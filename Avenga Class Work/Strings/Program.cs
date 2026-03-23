#region String


string fName = "Filip";
string Lname = "Mihajlovski";


string hello1 = "Hello " + fName;

string hello2 = string.Format("Hello there {0} {1}", fName, Lname);
Console.WriteLine(hello2);

string hello3 = $"Hello there again {fName} {Lname}";
Console.WriteLine(hello3);

string message = "Check your c:\\drive";
Console.WriteLine(message);

string fairElectionsMessage = "We will have a \"fair\" elections";
Console.WriteLine(fairElectionsMessage);

string newLineMassage = "The \\n sign means new line in c#";

string folderPath = "C:\\User\\Filip\\Avenga Acedemy\\C#Basic";
Console.WriteLine(folderPath);

string folderPathNew = @"C:\Users\Filip\Avenga Academy\C#Basic";
Console.WriteLine(folderPathNew);

string avendaFlderName = "AvengaProjects";
string username = "filipmihajlovski";


string pathTofolder = $@"C:\User\{username}\{avendaFlderName}";
Console.WriteLine(pathTofolder);



#endregion

#region String Formating

string myPercentigString = string.Format("This is {0:P}", 0.5);

Console.WriteLine(myPercentigString);


Console.OutputEncoding = System.Text.Encoding.UTF8;
string myCurrencyValue = string.Format("It will cost me {0:C}", 125.45);
Console.WriteLine(myCurrencyValue);

string myStringNumber = string.Format("{0:N}", 190);
Console.WriteLine(myStringNumber);


string cardNumber = string.Format("{0:####-####-####-####}", 1234554477882233);
Console.WriteLine(cardNumber);

string phoneNumber = string.Format("{0:0##/###-###}", 071380806);
Console.WriteLine(phoneNumber);

string myCustimAllindString1 = string.Format("| {0,10} | {1,10} |", "ID", "Order");
string myCustimAllindString2 = string.Format("| {0,10} | {1,10} |", 25, "Samsung Galasy s25");
Console.WriteLine(myCustimAllindString1);
Console.WriteLine(myCustimAllindString2);



#endregion


#region String Methods

string msg = "     We are learninig C# amd it is fun and esay. Okey maybe just FUN.   ";
Console.WriteLine(msg.Length);

Console.WriteLine(msg.Trim().Length); 

string lower = msg.ToLower();
string upper = msg.ToUpper();

Console.WriteLine(lower);
Console.WriteLine(upper);

string[] spittedString = msg.Split('.');
Console.WriteLine("this is the start");
Console.WriteLine(spittedString[0]);
Console.WriteLine(spittedString[1]);
Console.WriteLine(spittedString[2]);

bool doseStringStarsWith = msg.Trim().StartsWith("W");
Console.WriteLine(doseStringStarsWith);

int indexOfString = msg.IndexOf("FUN");
Console.WriteLine(indexOfString);


int nonExixtingString = msg.IndexOf("filip");
Console.WriteLine(nonExixtingString);

string substring = msg.Substring(0,15);
Console.WriteLine(substring);


char[] toChar = msg.ToCharArray();
Console.WriteLine(toChar.Length);

Console.WriteLine(string.Join("-", toChar));


#endregion