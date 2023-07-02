// display title
Console.WriteLine("Bank Project");
Console.WriteLine("Login");

string username = null, password = null;
Console.Write("Username: ");
username = Console.ReadLine();
if (username != "")
{
    Console.Write("Password: ");
    password = Console.ReadLine();
}

if (username == "system" && password == "manager")
{
    Console.WriteLine("Main Menu");
}
Console.WriteLine("Thank You! Visit Again!");
Console.ReadKey();
