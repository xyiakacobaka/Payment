﻿using System;
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
    }
}