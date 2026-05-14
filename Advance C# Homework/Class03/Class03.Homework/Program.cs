
#region Task 1
/*
Task 1
Create class User that will have 3 properties Id, Name, Age.
Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
*/


using Class03.Homework.BaseEntity;
using Class03.Homework.Models;
using Class03.Homework.Models2;

Console.WriteLine(UserDatabasa.SearchById(3).ToString());

//Console.WriteLine(UserDatabasa.SearchById(0).ToString());



List<User> foundNames = UserDatabasa.SearchByName("Alice");

List<User> foundNames2 = UserDatabasa.SearchByName("Filip");

//I do not know how to handel null execpton here 

foreach (var user in foundNames)
{
    Console.WriteLine(user.ToString());
}


List<User> foundAges = UserDatabasa.SearchByAge(35);

List<User> foundAges2 = UserDatabasa.SearchByAge(10);

foreach (var user in foundAges)
{
    Console.WriteLine(user.ToString());


}














#endregion


#region Task 2
/*
Task 2
Create a class Vehicle that have one method DisplayInfo(). Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method;

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



Vehicle car = new Car();
Vehicle motorbike = new Motorbike();
Vehicle boat = new Boat();
Vehicle palne = new Plane();

car.DispalyInfo();
motorbike.DispalyInfo();
boat.DispalyInfo();
palne.DispalyInfo();





#endregion