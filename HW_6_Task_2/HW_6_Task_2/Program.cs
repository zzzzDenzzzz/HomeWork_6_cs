using System;

/*Задание 2
Создать базовый класс «Устройство» и производные классы «Чайник», «Микроволновка», «Автомобиль», «Пароход».
С помощью конструктора установить имя каждого устройства и его характеристики.
Реализуйте для каждого из классов методы:
-Sound — издает звук устройства (пишем текстом в
консоль);
-Show — отображает название устройства;
-Desc — отображает описание устройства.*/

namespace HW_6_Task_2
{
    abstract class Device
    {
        public string Name { get; set; }
        public string SoundDevice { get; set; }
        public string Description { get; set; }
        public Device(string name, string sound, string description)
        {
            Name = name;
            SoundDevice = sound;
            Description = description;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public override string ToString()
        {
            return $"NAME: {Name} SOUND: {SoundDevice} DESCRIPTION: {Description}";
        }
    }
    class Teapot : Device
    {
        public Teapot(string name, string sound, string description) : base(name, sound, description)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Name}");
        }

        public override void Sound()
        {
            Console.WriteLine($"{SoundDevice}");
        }
    }
    class Microwave : Device
    {
        public Microwave(string name, string sound, string description) : base(name, sound, description)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Name}");
        }

        public override void Sound()
        {
            Console.WriteLine($"{SoundDevice}");
        }
    }
    class Car : Device
    {
        public Car(string name, string sound, string description) : base(name, sound, description)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Name}");
        }

        public override void Sound()
        {
            Console.WriteLine($"{SoundDevice}");
        }
    }
    class Steamership : Device
    {
        public Steamership(string name, string sound, string description) : base(name, sound, description)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void Show()
        {
            Console.WriteLine($"{Name}");
        }

        public override void Sound()
        {
            Console.WriteLine($"{SoundDevice}");
        }
    }
    internal class Program
    {
        public static void Print(params Device[] devices)
        {
            foreach (var item in devices)
            {
                if (item is Teapot)
                {
                    (item as Teapot).Show();
                    (item as Teapot).Desc();
                    (item as Teapot).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Microwave)
                {
                    (item as Microwave).Show();
                    (item as Microwave).Desc();
                    (item as Microwave).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Car)
                {
                    (item as Car).Show();
                    (item as Car).Desc();
                    (item as Car).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Steamership)
                {
                    (item as Steamership).Show();
                    (item as Steamership).Desc();
                    (item as Steamership).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            var teapot = new Teapot("ЧАЙНИК", "teapot_sound", "КИПИТ");
            var microwave = new Microwave("МИКРОВОЛНОВКА", "microwave_sound", "ГРЕЕТ");
            var car = new Car("АВТОМОБИЛЬ", "car_sound", "ЕДЕТ");
            var steamership = new Steamership("ПАРОХОД", "steamership_sound", "ПЛЫВЕТ");

            Print(teapot, microwave, car, steamership);
        }
    }
}