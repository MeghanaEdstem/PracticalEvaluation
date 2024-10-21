namespace PracticalEvaluation;

public class EmployeePay
{
    public static void Main(string[] args)
    {
        Console.Write("Enter hourly rate: ");
        var hourlyRate = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter hours worked: ");
        var hoursWorked = Convert.ToDecimal(Console.ReadLine());
        var normalHours = 40;
        var overTimeHours = hoursWorked - 40;
        var regularPay = normalHours * hourlyRate;
        var overtimePay = overTimeHours * hourlyRate * 1.5m;
        var grossPay = regularPay + overtimePay;
        var tax = grossPay * 0.20m;
        var netPay = grossPay - tax;
        Console.WriteLine("Gross Pay: " + grossPay);
        Console.WriteLine("Tax-20%: " + tax);
        Console.WriteLine("Net Pay: " + netPay);
    }

}