/* ask the user for their personal info
if they are an adult
 - HAHA Took your bank info
Not an adult
 -Don't give out your personal info
*/

Console.WriteLine("Welcome to info collector.");

//collecting info
Console.WriteLine("Please type out your name:");
string name = Console.ReadLine();

Console.WriteLine($"Hello {name}, what is your age?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} what is your hometown?");
string hometown = Console.ReadLine();

//display results
if (age >= 18)
{
    Console.WriteLine($"HAHA {name}, I am going to take your account that is in {hometown}");
}
else
{
    Console.WriteLine($"{name} don't give out your info.");
}

Console.WriteLine($"Bye, {name}");