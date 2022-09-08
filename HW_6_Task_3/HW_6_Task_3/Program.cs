using System;

/*Задание 3
Создать базовый класс «Музыкальный инструмент» и производные классы «Скрипка», «Тромбон», «Укулеле»,
«Виолончель». С помощью конструктора установить имя каждого музыкального инструмента и его характеристики.
Реализуйте для каждого из классов методы:
-Sound — издает звук музыкального инструмента(пишем текстом в консоль);
-Show — отображает название музыкального инструмента;
-Desc — отображает описание музыкального инструмента;
-History — отображает историю создания музыкального инструмента.*/

namespace HW_6_Task_3
{
    abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public string SoundDevice { get; set; }
        public string Description { get; set; }
        public string HistoryInstrument { get; set; }
        public MusicalInstrument(string name, string sound, string description, string history)
        {
            Name = name;
            SoundDevice = sound;
            Description = description;
            HistoryInstrument = history;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
        public override string ToString()
        {
            return $"NAME: {Name} SOUND: {SoundDevice} DESCRIPTION: {Description} HISTORY: {HistoryInstrument}";
        }
    }
    class Violin : MusicalInstrument
    {
        public Violin(string name, string sound, string description, string history) : base(name, sound, description, history)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void History()
        {
            Console.WriteLine($"{HistoryInstrument}");
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
    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string sound, string description, string history) : base(name, sound, description, history)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void History()
        {
            Console.WriteLine($"{HistoryInstrument}");
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
    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string sound, string description, string history) : base(name, sound, description, history)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void History()
        {
            Console.WriteLine($"{HistoryInstrument}");
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
    class Cello : MusicalInstrument
    {
        public Cello(string name, string sound, string description, string history) : base(name, sound, description, history)
        {
        }

        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }

        public override void History()
        {
            Console.WriteLine($"{HistoryInstrument}");
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
        public static void Print(params MusicalInstrument[] devices)
        {
            foreach (var item in devices)
            {
                if (item is Violin)
                {
                    (item as Violin).Show();
                    (item as Violin).Desc();
                    (item as Violin).History();
                    (item as Violin).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Trombone)
                {
                    (item as Trombone).Show();
                    (item as Trombone).Desc();
                    (item as Trombone).History();
                    (item as Trombone).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Ukulele)
                {
                    (item as Ukulele).Show();
                    (item as Ukulele).Desc();
                    (item as Ukulele).History();
                    (item as Ukulele).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
                else if (item is Cello)
                {
                    (item as Cello).Show();
                    (item as Cello).Desc();
                    (item as Cello).History();
                    (item as Cello).Sound();
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            var violin = new Violin("СКРИПКА", "violin_sound", "discription_violin", "history_violin");
            var trombone = new Trombone("ТРОМБОН", "trombone_sound", "discription_trombone", "history_trombone");
            var ukulele = new Ukulele("УКУЛЕЛЕ", "ukulele_sound", "discription_ukulele", "history_ukulele");
            var cello = new Cello("ВИОЛОНЧЕЛЬ", "cello_sound", "discription_cello", "history_cello");

            Print(violin, trombone, ukulele, cello);
        }
    }
}