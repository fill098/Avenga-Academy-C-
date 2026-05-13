#region Task 1

/*
Task #1 - Searchable
Create an interface Searchable with a method:

bool Search(string word);
The method returns true if word appears in the object's content, false otherwise (case-insensitive).

Create two classes that implement Searchable:

Document - has a Title and a Content field (both string). Search looks inside Content.
WebPage - has a Url and an Html field (both string). Search looks inside Html, ignoring HTML tags (a simple Regex.Replace(html, "<.*?>", "") is enough).
In Program.cs, create one Document and one WebPage, call Search on each with a word that exists and one that doesn't, and print the results.
*/


using Class02.Homework.BaseEntity;
using Class02.Homework.Interface;
using Class02.Homework.Models;
using Class02.Homework.Models2;

Document doc = new Document("BMW", "BMW AG's automobiles are marketed under the BMW, Mini, and Rolls-Royce brands while its motorcycles are marketed under the BMW Motorrad brand.");

WebPage page = new WebPage("Headings", @"<!DOCTYPE html>\r\n<html>\r\n<body>\r\n\r\n<h1>This is heading 1</h1>\r\n<h2>This is heading 2</h2>\r\n<h3>This is heading 3</h3>\r\n<h4>This is heading 4</h4>\r\n<h5>This is heading 5</h5>\r\n<h6>This is heading 6</h6>\r\n\r\n</body>\r\n</html>\r\n\r\n");


bool docResult1 = doc.Search("Mini");

bool docResult2 = doc.Search("Kia");

bool pageResult1 = page.Search("heading");

bool pageResult2 = page.Search("<h1>");


Console.WriteLine(docResult1);

Console.WriteLine(docResult2);


Console.WriteLine(pageResult1);

Console.WriteLine(pageResult2);



#endregion

#region Task 2
/*
Task #2 - Shape interface
Create an interface Shape with one method:

double GetArea();
Create three classes that implement Shape:

Rectangle - fields Width, Height. Area = Width * Height.
Circle - field Radius. Area = π * Radius².
Triangle - fields Base, Height. Area = 0.5 * Base * Height.
In Program.cs, store all three in a Shape[] array and print each area in a loop.
*/


IShape[] shapes = new IShape[]
{
    new Rectangle (5,10),
    new Circle (7),
    new Triangle (8,14)
};



foreach (var shape in shapes)
{
    Console.WriteLine($"The area is {shape.GetArea()}");
}





#endregion


#region Task 3
/*
Task #3 - Shape abstract class
This task contrasts with Task 2. There you used an interface (a contract only). Here you use an abstract class so subclasses can share state and helper logic.

Create an abstract class Shape with two abstract methods:

abstract double CalculateArea();
abstract double CalculatePerimeter();
Create three subclasses:

Rectangle - fields Width, Height.
Circle - field Radius.
Triangle - fields SideA, SideB, SideC (use Heron's formula for area).
Add a non-abstract method DisplayInfo() in the base Shape class that prints the shape's area and perimeter - this shows why an abstract class is useful (shared behavior across subclasses).

In Program.cs, create one of each and call DisplayInfo() on them.
*/




Rectangle2 regtengle2 = new Rectangle2 (5,10);

Triangle2 triangle2 = new Triangle2 (5,10,7);

Circle2 circle2 = new Circle2(16);


Console.WriteLine(regtengle2.CalculateArea());
Console.WriteLine(regtengle2.CalculatePerimeter());
regtengle2.DisplayInfo();

Shape rectangle3 = new Rectangle2(15, 20);


Console.WriteLine(rectangle3.CalculateArea());
Console.WriteLine(rectangle3.CalculatePerimeter());
rectangle3.DisplayInfo();







#endregion