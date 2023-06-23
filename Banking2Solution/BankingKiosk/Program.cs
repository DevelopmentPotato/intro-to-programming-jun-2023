// See https://aka.ms/new-console-template for more information
using Banking2.Domain;
using System.Security.Principal;

Console.WriteLine("Welcome to the bank, we got banks!");
var account = new Account(new StandardBonusCalculator());

Console.WriteLine($"You Current Balance is {account.GetBalance():c}");

Console.Write("Enter a W to make a withdrawal\n" +
    "Enter a D for a desposit\n" +
    "Q to quit");

var entry = Console.ReadLine();

if(entry is null)
{
    Console.WriteLine("You stink!");
}
else
{
    if (entry.ToLower().Trim() == "w")
    {
        Console.Write("Ammount of Withdrawal: ");
        var amount = decimal.Parse(Console.ReadLine());
        account.Withdraw(amount);
    }

    if (entry.ToLower().Trim() == "d")
    {
        Console.Write("Ammount of Deposit: ");
        var amount = decimal.Parse(Console.ReadLine());
        account.Deposit(amount);
    }

    Console.WriteLine($"You new balance is: {account.GetBalance()}.");
}




