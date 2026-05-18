using Class04.Extesion_Methods.Helpers;
using Class04.Generics_and_Extension_Methods.Domain.Data;
using Class04.Generics_and_Extension_Methods.Domain.Interfaces;
using Class04.Generics_and_Extension_Methods.Domain.Models;
using Class04.Generics_and_Extension_Methods.Helpers;

List<int> integers = new List<int>() { 1, 3, 4, 5, 6, 7 };

List<string> strings = ["str", "str1", "str3"];

List<bool> bools = new List<bool>() { true, true, false, false };




NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();

nonGenericListHelper.PrintStrings(strings);

nonGenericListHelper.PrintInfoForStrings(strings);

nonGenericListHelper.PrintIntegers(integers);

nonGenericListHelper.PrintBooleans(bools);




GenericListHelper genericListHelper = new GenericListHelper();

GenericListHelper.PrintItemsInfo(strings);

genericListHelper.PrintItems<string>(strings);



#region Generic Classess


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================ Generic Classes ================\n");
Console.ResetColor();

GenericDb<Order> OrdersDb = new GenericDb<Order>();
GenericDb<Product> ProductsDb = new GenericDb<Product>();

// Inserting data
OrdersDb.Insert(new Order { Id = 1, Address = "Bob St.", Recever = "Bob" });
OrdersDb.Insert(new Order { Id = 2, Address = "John St.", Recever = "John" });
OrdersDb.Insert(new Order { Id = 3, Address = "Jane St.", Recever = "Jane" });

ProductsDb.Insert(new Product { Id = 1, Title = "Mouse", Description = "Wireless mouse" });
ProductsDb.Insert(new Product { Id = 2, Title = "USB", Description = "64MB" });

// Printing data
OrdersDb.PrintAll();
ProductsDb.PrintAll();

integers.PrintListInfo();

string bobLong = "Bob Bobski";

string bobShort = bobLong.Truncate(3);

Console.WriteLine(bobShort);

Console.WriteLine("Bob Bobsky".Truncate(5));


string johnShor = "John Geta";
Console.WriteLine(johnShor.Truncate(4));

Console.WriteLine(johnShor.Quoute());


Product product = new Product
{
    Id = 1,
    Description = "Product Descripton",
    Title = "Product Titile"
};

product.GetInfo();






#endregion




