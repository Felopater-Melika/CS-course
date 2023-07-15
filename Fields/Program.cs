using EmployeeLibrary;

namespace ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee.OrganizationName = "Harsha Inc.";

        for (var i = 0; i < 5; i++)
        {
            var employee = new Employee();

            Console.WriteLine("Enter Employee Details:");
            Console.Write("Employee ID: ");
            employee.EmpID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name: ");
            employee.EmpName = Console.ReadLine();

            Console.Write("Salary Per Hour: ");
            employee.SalaryPerHour = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of Working Hours: ");
            employee.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());

            employee.CalculateNetSalary();

            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Employee ID: {employee.EmpID}");
            Console.WriteLine($"Employee Name: {employee.EmpName}");
            Console.WriteLine($"Salary Per Hour: {employee.SalaryPerHour}");
            Console.WriteLine($"Number of Working Hours: {employee.NoOfWorkingHours}");
            Console.WriteLine($"Net Salary: {employee.NetSalary}");
            Console.WriteLine($"Organization Name: {Employee.OrganizationName}");
            Console.WriteLine($"Type of Employee: {Employee.TypeOfEmployee}");
            Console.WriteLine($"Department Name: {employee.DepartmentName}");

            Console.Write("Do you want to continue to the next employee? (Yes/No): ");
            var continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() != "yes")
                break;
        }

        Console.WriteLine("Program execution completed.");
    }
}