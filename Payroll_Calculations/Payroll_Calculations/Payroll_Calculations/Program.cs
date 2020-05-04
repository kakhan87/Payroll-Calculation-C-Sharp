// Program Name:    Payroll Calculations ‐ Console Input Version
//
// Author:          Karim Khan
//
// Date:            27-March-2020
//
// Description:     Assignment #1 ‐ Payroll Calculations ‐ Console Input Version
//
//                  The intent of this application is to prepare a Pay Slip to be included in a cheque envelope for the 
//                  employees of a small business. The Pay Slip will also be used by the accountant to prepare the actual 
//                  pay-cheques, and to record the deductions in a company ledger. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName; // declare string variable to specify Employee Name
            double numberOfHours; // declare floating point variable to specify number of hours worked by Employee
            double hourlyPay; // declare floating point variable to input hourly rate of pay
            int deductions; // declare integer variable for percentage of gross pay to be deducted (whole numbers only)
            double grossPay; // declare floating point variable to compute the gross pay
            double deductionAmount; // declare floating point variable to compute total deductions for benefits, income tax, etc.
            double netPay; // declare floating point variable to compute the net pay

            // Ask the user for Input

            Console.Write("Enter the Employee Name: ");
            employeeName = Console.ReadLine();

            Console.Write("Enter the number of hours worked (Decimal hours allowed): ");
            numberOfHours = double.Parse(Console.ReadLine());

            Console.Write("Enter hourly wage: ");
            hourlyPay = double.Parse(Console.ReadLine());

            Console.Write("Enter deduction percentage (Whole percentages only): ");
            deductions = int.Parse(Console.ReadLine());

            // Calculate Gross pay, Deduction amount and Net pay

            grossPay = numberOfHours * hourlyPay;
            deductionAmount = grossPay * deductions / 100;
            netPay = grossPay - deductionAmount;

            // Output Results in Pay-slip Format

            Console.WriteLine("                                                     " +
                "                                                                   " +
                "                                                                   " +
                "                                                                   " +
                "");   // Create space between Input variables and Pay-slip output
            Console.WriteLine("****************** Pay Slip ******************");
            Console.WriteLine("");
            Console.WriteLine($"        Name: {employeeName}");
            Console.WriteLine($"Hours worked: {numberOfHours} hours at {hourlyPay:C2} per hour.");
            Console.WriteLine("");
            Console.WriteLine($"   Gross Pay:     {grossPay:C2}");
            Console.WriteLine($"  Deductions:     -{deductionAmount:C2}");
            Console.WriteLine("                ----------");
            Console.WriteLine($"     Net Pay:     {netPay:C2}");
            Console.WriteLine("                                                     " +
    "                                                                   " +
    "                                                                   " +
    "                                                                   " +
    ""); // Create space between Pay-slip output and "Press any key to continue . . ." prompt
        }
    }
}
