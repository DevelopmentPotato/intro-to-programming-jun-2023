Console.Clear();

 

int age = 0;

 

Console.Write("Hey, how old are you? ");
string? enteredAge = Console.ReadLine();

 

Console.WriteLine("You said " + enteredAge);

 

try
{
    age = int.Parse(enteredAge);
}
catch (FormatException)
{

 

    Console.WriteLine("Enter a number, you big old dork.");
}

 

if (age >= 21)
{
    Console.WriteLine("Jeff Was Here");
    Console.WriteLine("How's it going?");
} else
{
    Console.WriteLine("Too young. Come back later");
}