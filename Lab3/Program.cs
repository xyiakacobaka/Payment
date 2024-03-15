using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payments;

internal class Program
{
    static void Main(string[] args)
    {
        Payment payment1 = new Payment("Потапов", 15000, 2020, 0.15, 0, 0.3);
        Payment payment2 = new Payment("Сиротин", 20000, 2015, 0.80, 15000, 0);
        Payment payment3 = new Payment();
        Payment payment4 = new Payment();
        payment3.LastName = "Сибилев";
        payment3.Year = 2021;
        payment3.Salary = 14000;
        payment3.ProcentBonus = 0.5;
        payment3.ProcentWithheldAmount = 0.5;
        Console.WriteLine(payment1.ToString() + "\n");
        Console.WriteLine(payment2.ToString() + "\n");
        Console.WriteLine(payment3.ToString() + "\n");
        Console.WriteLine("Сотруднику " + payment1.LastName + " который работает на своей должности " + payment1.Experience() +
            " года.\nЕго месячная зарплата составляет " + payment1.Salary + "р. Если учесть его штрафы за месяц " + payment1.CalculationWithheldAmount() +
            "р пенсионный взос " + payment1.PencionDeductions() + "р и налог " + payment1.TaxDeductions() + "р, то его зарплата за этот месяц составит " +
            payment1.CalculationGivenAmount() + "р.\n");
        payment4 = payment1 + payment2;
        Console.WriteLine(payment4.ToString());
    }
}
