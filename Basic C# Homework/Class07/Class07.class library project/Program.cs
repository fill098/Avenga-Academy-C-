

#region Testing the Console App

using Class07.class_library_project_.Models;
using EnumRole;

SalesPerson filip = new SalesPerson("Filip", "Mihajlovski");
SalesPerson igor = new SalesPerson("Igor", "Minushev");
SalesPerson stefan = new SalesPerson("Stefan", "Dimovski");

filip.AddSuccessRevenue(1000);
igor.AddSuccessRevenue(3500);
stefan.AddSuccessRevenue(6000);

Console.WriteLine("=========Info Sales Employees========");

filip.PrintInfo();
igor.PrintInfo(); 
stefan.PrintInfo();

Console.WriteLine("========= Info Menager ========");


Manager martin = new Manager("Martin","Mihajlovski", Role.Manager, 1000);
Manager david = new Manager("David","Stojanovski", Role.Manager, 1500);
Manager marko = new Manager("Marko","velkovski", Role.Manager, 2000);


martin.AddBonus(500);
david.AddBonus(1000);
marko.AddBonus(1500);

martin.PrintInfo();
david.PrintInfo(); 
marko.PrintInfo();







#endregion
