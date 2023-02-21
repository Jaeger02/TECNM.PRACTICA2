using System;
using TecNM.Practica2.Core.Managers;
using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Services;

namespace TecNM.Practica2.App;

public static class Program{
    public static void Main(string[] args){
        float salary = 0;

        System.Console.Write("Please enter the gross salary: ");
        Single.TryParse(System.Console.ReadLine(), out salary);

        var person = new Person{salary = salary};

        var service = new ISRService();
        var manager = new ISRManager(service);

        ISR isr = manager.GetISR(person);
        System.Console.WriteLine($"The ISR is: {isr.Index}");
        System.Console.WriteLine($"The Range is: {isr.ISRType}");
    }
}


