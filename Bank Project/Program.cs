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
    var mainMenuChoice = -1;
    do
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Customers");
        Console.WriteLine("2. Accounts");
        Console.WriteLine("3. Funds Transfer");
        Console.WriteLine("4. Funds Transfer Statement");
        Console.WriteLine("5. Account Statement");
        Console.WriteLine("0. Exit");

        Console.Write("Enter your choice: ");
        mainMenuChoice = int.Parse(Console.ReadLine());

        switch (mainMenuChoice)
        {
            case 1:
                CutomersMenu();
                break;
            case 2:
                AccountsMenu();
                break;
            case 3:
                FundsTransferMenu();
                break;
            case 4:
                AccountTransferMenu();
                break;
            case 5:
                AccountStatementMenu();
                break;
        }
    } while (mainMenuChoice != 0);
}

Console.WriteLine("Thank You! Visit Again!");
Console.ReadKey();

static void CutomersMenu()
{
    var customersMenuChoice = -1;

    do
    {
        Console.WriteLine("Customer Menu");
        Console.WriteLine("1. Add Customer");
        Console.WriteLine("2. Update Customer");
        Console.WriteLine("3. Delete Customer");
        Console.WriteLine("4. View Customer");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Enter your choice: ");
        customersMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (customersMenuChoice != 0);
}

static void AccountsMenu()
{
    var accountsMenuChoice = -1;

    do
    {
        Console.WriteLine("Account Menu");
        Console.WriteLine("1. Add Account");
        Console.WriteLine("2. Update Account");
        Console.WriteLine("3. Delete Account");
        Console.WriteLine("4. View Account");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Enter your choice: ");
        accountsMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (accountsMenuChoice != 0);
}

static void FundsTransferMenu()
{
    var fundsTransferMenuChoice = -1;
    do
    {
        Console.WriteLine("Funds Transfer Menu");
        Console.WriteLine("1. Add Funds Transfer");
        Console.WriteLine("2. Update Funds Transfer");
        Console.WriteLine("3. Delete Funds Transfer");
        Console.WriteLine("4. View Funds Transfer");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Enter your choice: ");
        fundsTransferMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (fundsTransferMenuChoice != 0);
}

static void AccountTransferMenu()
{
    var accountTransferMenuChoice = -1;
    do
    {
        Console.WriteLine("Account Transfer Menu");
        Console.WriteLine("1. Add Account Transfer");
        Console.WriteLine("2. Update Account Transfer");
        Console.WriteLine("3. Delete Account Transfer");
        Console.WriteLine("4. View Account Transfer");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Enter your choice: ");
        accountTransferMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (accountTransferMenuChoice != 0);
}

static void AccountStatementMenu()
{
    var accountStatementMenuChoice = -1;
    do
    {
        Console.WriteLine("Account Statement Menu");
        Console.WriteLine("1. Add Account Statement");
        Console.WriteLine("2. Update Account Statement");
        Console.WriteLine("3. Delete Account Statement");
        Console.WriteLine("4. View Account Statement");
        Console.WriteLine("0. Back to Main Menu");
        Console.Write("Enter your choice: ");
        accountStatementMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (accountStatementMenuChoice != 0);
}