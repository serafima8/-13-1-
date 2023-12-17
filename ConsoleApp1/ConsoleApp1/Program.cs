using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1 способ
            //Phone phone = new Phone();
            //phone.manufacturer = "Apple";
            //phone.model = "iPhone";
            //phone.price = 7000;
            //Console.WriteLine(phone.ToString());

            ////2 способ
            //Phone phone1 = new Phone("Xiaomi", "Redmi", 3500);
            //Console.WriteLine(phone1.ToString());

            ////3 способ 
            //Console.Write("Введите производителя телефона: ");
            //string manufacturer = Console.ReadLine();
            //Console.Write("Введите модель телефона: ");
            //string model = Console.ReadLine();
            //Console.Write("Введите цену телефона: ");
            //double price = Convert.ToDouble(Console.ReadLine());
            //Phone phone2 = new Phone(manufacturer, model, price);
            //Console.WriteLine(phone2.ToString());



            //Задание 1 (КП 1)

            //Student student = new Student();
            //student.Fam = "Иванов";
            //student.Kurs = -4;
            //Console.WriteLine(student.ShowInfo());

            //Student student1 = new Student("", 3);
            //Console.WriteLine(student1.ShowInfo());



            //Задание 2

            //Avto avto = new Avto();
            //avto.Brand = "Mercedes-Benz";
            //avto.Color = "Черный";
            //avto.Skor = 365;
            //Console.WriteLine(avto.ShowInfo());


            //Задание 3

            //Computer computer = new Computer();
            //computer.Model = "Samsung";
            //computer.Ram = 33;
            //computer.Hdd = 1999;
            //Console.WriteLine(computer.ShowInfo());


            //Задание 4

            //Tovar tovar = new Tovar();
            //tovar.Name = "Конфеты Марс";
            //tovar.Price = 80;
            //tovar.Kvo = 1;
            //Console.WriteLine(tovar.ShowInfo());

            Console.ReadKey();

        }
    }
}
