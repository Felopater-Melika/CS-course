namespace EmployeeLibrary;

public class Employee
{
    public const string TypeOfEmployee = "Contract Based";

    public static string OrganizationName;
    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Finance Department";
    }

    public int EmpID { get; set; }
    public string EmpName { get; set; }
    public double SalaryPerHour { get; set; }
    public int NoOfWorkingHours { get; set; }
    public double NetSalary { get; private set; }

    public void CalculateNetSalary()
    {
        NetSalary = SalaryPerHour * NoOfWorkingHours;
    }
}