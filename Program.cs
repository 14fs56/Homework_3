using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main()
        {
            string name = "Андрей";
            int age = 27;
            int programCount = 3;
            int money = 99999;
            int time = 1000000000;
            bool truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".\n" +
                "Мне " + age + " лет.\n" +
                "Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.\n" +
                "Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.\n" +
                "Достигну ли я желаемого? " + truth + "!");
        }
    }
}
