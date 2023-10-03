Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    Printhello();
}
else
{
    printGoodBye();
}

static void Printhello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void printGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}