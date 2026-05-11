// See https://aka.ms/new-console-template for more information
using Class03.Static_Classes;
using Class03.Static_Classes.Enum;
using Class03.Static_Classes.Helpers;
using Class03.Static_Classes.Models;



Console.WriteLine("Hello, World!");

//ConsoleHelper consoleHelper = new ConsoleHelper();  // Cannot create an instance from *static* class

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("===== Welcome to Order Managment System =====");
//Console.ResetColor();

ConsoleHelper.WirteInColor("===== Welcome to Order Managment System =====", ConsoleColor.Blue);

Console.WriteLine(OrdersStaticDB.Users.Count);

bool isRunninig = true;
while (isRunninig)
{
    ConsoleHelper.WirteInColor("===== Welcome to Order Managment System =====\", ConsoleColor.Blue");
    Console.WriteLine("\nPlese choose an option:");
    Console.WriteLine("1) List all orders");
    Console.WriteLine("2) Create order for users");
    Console.WriteLine("3) Exits");

    string choice = Console.ReadLine();

    object OrderStaticDb = null;
    switch (choice)
    {
        case "1":
            ConsoleHelper.WirteInColor("\nList of Users: ", ConsoleColor.Magenta);
            break;
        case "2":
            ConsoleHelper.WirteInColor("\n Enter User Id:", ConsoleColor.Yellow);
            string userId = Console.ReadLine();

            ConsoleHelper.WirteInColor("\n Enter Order Title:", ConsoleColor.Yellow);

            string title = Console.ReadLine();

            ConsoleHelper.WirteInColor("\n Enter Order Description:", ConsoleColor.Yellow);


            string discripton = Console.ReadLine();

            Order newOrder = new Order
            {
                Title = title,
                Description = discripton,
                Status = OrderStatus.Processing
            };


            OrdersStaticDB.InsertOrder(newOrder, Convert.ToInt32(userId));
            break;
        case "3":
            ConsoleHelper.WirteInColor("\nGoodbye", ConsoleColor.DarkBlue);
            isRunninig = false;
            break;
        default:
            ConsoleHelper.WirteError("\nInvalid choice. Try again");

            break;
    }

}



Console.ReadLine();



