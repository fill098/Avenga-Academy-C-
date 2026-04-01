using Class06.Atm.Models;


#region ATM
//Create an ATM application. A customer should be able to authenticate with card number and pin and should be
//greeted with a message greeting them by full name. After that they can choose one of the following:

//Balance checking
//Cash withdrawal
//Cash deposition
//In order for the ATM app to work we need Customers.

//Bonus: The balance and pin should not be public
//Bonus: Ask the customer if they want another action
//Bonus: Add an option to register a new card


Customers[] atmCustomers = new Customers[]
{
    new Customers("Milena", "Dimitrovksa", 1111, 12345 ,2300),
    new Customers("Martin", "Jakson", 2222, 123456 ,50500),
    new Customers("David", "Trump", 3333, 1234567, 3010),
    new Customers("Matej","Jonson",4444, 12345678, 5450)
};





void AtmUi()
{
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Filips ATM");
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("");

    Console.WriteLine("Enter your card number:");
    bool isValidCard = int.TryParse(Console.ReadLine(), out int cardNumber);
    Console.WriteLine("Enter your pin:");
    bool isValidPin = int.TryParse(Console.ReadLine(), out int cardPin);

    if (!isValidCard || !isValidPin)
    {
        Console.WriteLine("Invalid input. Try again with valid card number and pin!!");
    }


    Customers userFound = FindAtmUser(cardNumber, cardPin);

    if (userFound != null)
    {
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Filips ATM");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("");
        Console.WriteLine($"Welcome {userFound.FirstName} {userFound.LastName}");

        Console.WriteLine("\n  ┌─────────────────────────────┐");
        Console.WriteLine("  │        ATM MAIN MENU        │");
        Console.WriteLine("  ├─────────────────────────────┤");
        Console.WriteLine("  │  1. Check Balance           │");
        Console.WriteLine("  │  2. Withdraw Cash           │");
        Console.WriteLine("  │  3. Deposit Cash            │");
        Console.WriteLine("  │  4. Register New Card       │");
        Console.WriteLine("  │  5. Exit / Eject Card       │");
        Console.WriteLine("  └─────────────────────────────┘");
        Console.Write("\n  Choose an option (1-5): ");


    }
    else
    {
        Console.WriteLine("Unable to find costumer with that card number and pin.");
    }








}

Customers FindAtmUser(int cardNumber, int cardPin)
{
    foreach (Customers user in atmCustomers)
    {
        if (user.CardNumber == cardNumber && user.ValidatePin(cardPin))
        {
            return user;

        }
    }
    return null;
}


AtmUi();



//while (true) ;



#endregion