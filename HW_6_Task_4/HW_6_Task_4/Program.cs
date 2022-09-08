using System;

/*Задание 4
Создать абстрактный базовый класс Worker (работника) с методом Print(). Создайте четыре производных класса:
President, Security, Manager, Engineer. Переопределите метод Print() для вывода информации, соответствующей
каждому типу работника.*/

namespace HW_6_Task_4
{
    abstract class Worker
    {
        protected string Responsibilities { get; set; }
        public Worker(string responsibilities)
        {
            Responsibilities = responsibilities;
        }
        public abstract void Print();
        public override string ToString()
        {
            return $"Обязанности: {Responsibilities}";
        }
    }
    class President : Worker
    {
        public President(string responsibilities) : base(responsibilities)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{Responsibilities}");
        }
    }
    class Security : Worker
    {
        public Security(string responsibilities) : base(responsibilities)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{Responsibilities}");
        }
    }
    class Manager : Worker
    {
        public Manager(string responsibilities) : base(responsibilities)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{Responsibilities}");
        }
    }
    class Engineer : Worker
    {
        public Engineer(string responsibilities) : base(responsibilities)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"{Responsibilities}");
        }
    }
    class Program
    {
        public static void Print(params Worker[] devices)
        {
            foreach (var item in devices)
            {
                if (item is President)
                {
                    (item as President).Print();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Security)
                {
                    (item as Security).Print();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Manager)
                {
                    (item as Manager).Print();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Engineer)
                {
                    (item as Engineer).Print();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            var president = new President("president_responsibilities");
            var security = new Security("security_responsibilities");
            var manager = new Manager("manager_responsibilities");
            var engineer = new Engineer("engineer_responsibilities");

            Print(president, security, manager, engineer);
        }
    }
}
