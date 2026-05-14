using Class06.Atm.Models;
using Class06.HelperMethod;

#region ATM
/*Create an ATM application. A customer should be able to authenticate with card number and pin and should be
greeted with a message greeting them by full name. After that they can choose one of the following:

Balance checking
Cash withdrawal
Cash deposition
In order for the ATM app to work we need Customers.

Bonus: The balance and pin should not be public
Bonus: Ask the customer if they want another action
Bonus: Add an option to register a new card

🧠 Design Hint – Separate Methods
This task is too big for one method.
Split it into logical parts:

Authentication (card + pin)
ATM menu
Balance operations
Deposit / Withdraw
Repeating actions

*/



Customers[] atmCustomers = new Customers[]
{
    new Customers("Milena", "Dimitrovksa", 1111, 12345 ,2300),
    new Customers("Martin", "Jakson", 2222, 12345 ,50500),
    new Customers("David", "Trump", 3333, 12345, 3010),
    new Customers("Matej","Jonson",4444, 12345, 5450)
};

bool AskForAnotherAction()
{
    return !Helper.GetYesNoInput("Do you want to perform another action? (Y/N): ", true);
}



bool AtmUi()
{
    Console.Clear();
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Filips ATM");
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("");

    int cardNumber = Helper.GetIntInput("Enter your card number:");
    int cardPin = Helper.GetIntInput("Enter your card Pin number:");


    Customers userFound = Customers.FindAtmUser(atmCustomers, cardNumber, cardPin);

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
        


        int atmChose = Helper.GetIntInputInRange("\n  Choose an option (1-5): ", 1, 5);

        switch (atmChose)
        {
            case 1:
                userFound.PrintBalance();
                return AskForAnotherAction();
            case 2:
                int withdrawAmount = Helper.GetIntInput("How much do you want to whitdraw:");
                userFound.Withdraw(withdrawAmount);

                return AskForAnotherAction();
            case 3:
                int depositAmount = Helper.GetIntInput("How much do do you want to deposit!");
                userFound.Deposit(depositAmount);

                return AskForAnotherAction();
            case 4:
                int newCardNum = Helper.GetIntInput("Enter your new card:");

                return AskForAnotherAction();
            case 5:
                Console.WriteLine("Thank you for using Filip's ATM. Goodbye!");
                return true; 
            default:
                return false;
        }




    }
    else

    {
        Console.WriteLine("Unable to find costumer with that card number and pin.");

        Console.ReadLine();
    }

    return false;








}




AtmUi();



while (!AtmUi()) ;



#endregion