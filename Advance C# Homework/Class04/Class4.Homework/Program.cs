
#region Task 1
/*
Task 1
Create class PrintInConsole that will have multiple methods to print in console: Print(), PrintCollection().
Make these methods to be valid for more than one type and use them accordingly with different types.
*/


using Class4.Homework.BaseEntity;
using Class4.Homework.Helpers;
using Class4.Homework.Models;
using Class4.Homework.PintHelpers;

PrintInConsole printer = new PrintInConsole();




printer.Print("Filip");
printer.Print(345);
printer.Print(true);
printer.Print('+');
printer.Print(2.908);


List<string> listString = new List<string>() {"Filip","Marko","Angela" };
List<int> listInt = new List<int>() { 1, 2, 3, 4, 5 };
List<bool> listBool = new List<bool>() { true, false, true };
List<double> listDouble = new List<double>() { 1.5, 2.8, 3.14 };

printer.PrintInCollection(listString);
printer.PrintInCollection(listInt);
printer.PrintInCollection(listBool);
printer.PrintInCollection(listDouble);






#endregion

#region Task2
/*
Task 2
Create a class Vehicle that has one method DisplayInfo().
Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method.
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo()

// in console we should display
// Im a car and i drive on 4 wheels :)
// Im a motorbike and i drive on 2 wheels :)
// Im a boat and i do not have wheels :(
// Im a plane i have couple of wheels :)
*/

Car car = new Car();
MotorBike motorBike = new MotorBike();
Boat boat = new Boat();
Airplane plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();




#endregion


#region Task3

/*
Task 3
From the previous task get the implementation and DO NOT CHANGE the implementation of the classes.

Now we need to EXTEND the functionalities with a couple of methods:

Car objects should have Drive() method;
MotorBike should have Wheelie() method;
Boat should have Sail() method;
Airplane should have Fly() method;
// this goes after the code from the previous task
car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();

//Console output
// The car is driving
// The motorbike is driving on one wheel
// The boat is sailing
// The airplane is flying
*/

car.Drive();
motorBike.Wheelie();
boat.Sail();
plane.Fly();
#endregion