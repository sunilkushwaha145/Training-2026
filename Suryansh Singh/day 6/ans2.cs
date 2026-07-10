using System;
class Employee{
    public int EmployeeId;
    public string EmployeeName;
    public double BasicSalary;
    public void ShowEmployeeInfo(){
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Employee Name: " + EmployeeName);
        Console.WriteLine("Salary: " + BasicSalary);
        Console.WriteLine();
    }
    public void UpdateSalary(double salary){
        BasicSalary = salary;
    }
    public double GetSalary(){
        return BasicSalary;
    }
    public double CalculateAnnualSalary(double bonus){
        return (BasicSalary * 12) + bonus;
    }
}
class Program{
    static void Main(){
        Employee e1 = new Employee();
        e1.EmployeeId = 1;
        e1.EmployeeName = "Rohit";
        e1.BasicSalary = 30000;
        Employee e2 = new Employee();
        e2.EmployeeId = 2;
        e2.EmployeeName = "Amit";
        e2.BasicSalary = 40000;
        e1.UpdateSalary(35000);
        e1.ShowEmployeeInfo();
        Console.WriteLine("Annual Salary with Bonus = " + e1.CalculateAnnualSalary(50000));
    }
}