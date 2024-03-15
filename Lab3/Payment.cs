using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    internal class Payment
    {
        public string LastName { get; set; } //Фамилия
        public double Salary { get; set; } //Оклад
        public int Year; // Год поступления на работу
        public int year 
        { 
            get 
            { return Year; }
            set 
            {
                if (value <= 2024 && value >=1980)
                {
                    Year = value;
                }
                else value = 0;
            }
        }
        public double ProcentBonus; //Процент надбавки
        public double procentbonus
        {
            get { return ProcentBonus; }
            set
            {
                if (value>0)
                {
                    ProcentBonus = value;
                }
                else value=0;
            }
        }
        public int GivenAmount; //Начисленная сумма
        public int givenamount
        {
            get { return GivenAmount; }
            set 
            {
                if (value >= 0)
                {
                    GivenAmount = value;
                }
                else value = 0;
            }
        }
        public double ProcentWithheldAmount; //Удержанная сумма в процентах
        public double procentwithheldamount
        {
            get {return ProcentWithheldAmount;}
            set
            {
                if(value >= 0)
                {
                    ProcentWithheldAmount = value;
                }
                else value = 0;
            }
        }
        public Payment(string LastName, double Salary, int Year, double ProcentBonus, int GivenAmount, double ProcentWithheldAmount)
        {
            this.LastName = LastName;
            this.Salary = Salary;
            this.Year = Year;
            this.ProcentBonus = ProcentBonus;
            this.GivenAmount = GivenAmount;
            this.ProcentWithheldAmount = ProcentWithheldAmount;

        }
        public Payment()
        {
            LastName = "";
            Salary = 0;
            Year = 1980;
            ProcentBonus = 0;
            GivenAmount = 0;
            ProcentWithheldAmount = 0;
        }
        public double CalculationGivenAmount()
        {
            return Salary + (Salary * ProcentBonus) - (Salary - ProcentWithheldAmount);
        }
        public double CalculationWithheldAmount()
        {
            return Salary * ProcentWithheldAmount;
        }
        public int Experience()
        {
            return 2024-Year;
        }
        public double PencionDeductions()
        {
            return Salary * 0.22;
        }
        public double TaxDeductions()
        {
            return Salary * 0.13;
        }
    }
}
