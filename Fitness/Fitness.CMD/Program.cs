using Fitness.BL.Controller;
using System;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title("Fitness");
            Console.WriteLine("Вас приветствует приложение Fitness");

            Console.WriteLine("Введите имя пользователя.");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол.");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения.");
            var birthDate = DateTime.Parse(Console.ReadLine()); // TODO: переписать

            Console.WriteLine("Введите вес.");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост.");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
