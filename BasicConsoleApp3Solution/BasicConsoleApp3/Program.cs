// See https://aka.ms/new-console-template for more information

using GeneralUtilities;
using Display;

Greetings.DisplayWelcome();

Console.WriteLine("First Name: ");
string firstName = Console.ReadLine();

Console.WriteLine("Last Name:");
string lastName = Console.ReadLine();

string fullName = Formatters.FormatName(firstName, lastName);
Console.WriteLine($"Hello {fullName} ");
