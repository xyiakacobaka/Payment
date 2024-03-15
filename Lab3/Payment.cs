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
                if (value <= 2024 && value >= 1980)
                {
                    Year = value;
                }
                else value = 0;
            }
        }
        public double ProcentBonus; //Процент надбавки
        public double procentbonus // свойство для проверки информации
        {
            get { return ProcentBonus; }
            set
            {
                if (value > 0)
                {
                    ProcentBonus = value;
                }
                else value = 0;
            }
        }
        public int GivenAmount; //Начисленная сумма
        public int givenamount // свойство для проверки иформации
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
        public double procentwithheldamount // свойство для проверки иформации
        {
            get { return ProcentWithheldAmount; }
            set
            {
                if (value >= 0)
                {
                    ProcentWithheldAmount = value;
                }
                else value = 0;
            }
        }
        public Payment(string LastName, double Salary, int Year, double ProcentBonus, int GivenAmount, double ProcentWithheldAmount)//Заполняемый конструктор
        {
            this.LastName = LastName;
            this.Salary = Salary;
            this.Year = Year;
            this.ProcentBonus = ProcentBonus;
            this.GivenAmount = GivenAmount;
            this.ProcentWithheldAmount = ProcentWithheldAmount;

        }
        public Payment()//пустой конструктор
        {
            LastName = "";
            Salary = 0;
            Year = 1980;
            ProcentBonus = 0;
            GivenAmount = 0;
            ProcentWithheldAmount = 0;
        }
        public double CalculationGivenAmount()//выданная сумма
        {
            return Salary + (Salary * ProcentBonus) - (Salary - ProcentWithheldAmount);
        }
        public double CalculationWithheldAmount()//удержанная сумма
        {
            return Salary * ProcentWithheldAmount;
        }
        public int Experience()//стаж работы
        {
            return 2024 - Year;
        }
        public double PencionDeductions()//пенсионный взнос
        {
            return Salary * 0.22;
        }
        public double TaxDeductions()//НДС
        {
            return Salary * 0.13;
        }
        public static Payment operator +(Payment p1, Payment p2)
        {
            if (p1.Experience() < p2.Experience()) { return new Payment(p2.LastName, p1.Salary + p2.Salary, p1.Year, p1.ProcentBonus + p2.ProcentBonus, p1.GivenAmount, p1.ProcentWithheldAmount); }
            else
            {
                return new Payment(p1.LastName, p1.Salary + p2.Salary, p2.Year, p1.ProcentBonus + p2.ProcentBonus, p2.GivenAmount, p2.ProcentWithheldAmount);
            }
        }
        public override string ToString()//Зачем использовать метод, если уже есть заранее созданная функция:\
        {
            return "Сотрудник " + this.LastName + " устроился на работу в " + this.Year + " его заработная плата составляет " + this.Salary +
                "\nПроцент надбавки к зарплате данного сотрудник = " + this.ProcentBonus + "\nСотрудник заработал за все время = " + this.GivenAmount +
                "\nУдержанная сумма = " + this.ProcentWithheldAmount;
        }
    }
}
