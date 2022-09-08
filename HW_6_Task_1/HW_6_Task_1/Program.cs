using System;

/*Задание 1
Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле
для хранения копеек (центы, евроценты, копейки и т.д.). Реализовать методы для вывода суммы на экран, за-
дания значений для частей. На базе класса Money создать класс Product для работы
с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
Для каждого из классов реализовать необходимые методы и поля.*/

namespace HW_6_Task_1
{
    class Money
    {
        int wholePart;
        byte fractionalPart;
        public int Whole
        {
            get { return wholePart; }
            set { wholePart = value; }
        }
        public byte Fractional
        {
            get { return fractionalPart; }
            set
            {
                if (value > 99)
                {
                    throw new NotImplementedException("error");
                }
                else
                {
                    fractionalPart = value;
                }
            }
        }
        public Money() { }
        public Money(int wholePart, byte fractionalPart)
        {
            Whole = wholePart;
            Fractional = fractionalPart;
        }
        public override string ToString()
        {
            string zero = string.Empty;
            if (Fractional < 10)
            {
                zero = "0";
            }
            return $"{Whole}.{zero}{Fractional}";
        }
    }
    class Product : Money
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Product() : base()
        {
            Name = string.Empty;
        }
        public Product(string name, int wholePart, byte fractionalPart) : base(wholePart, fractionalPart)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"PRODUCT: {Name} PRICE: {base.ToString()}";
        }
        public void ReduceThePrice(int whole, byte fractional)
        {
            if (fractional > 99)
            {
                throw new NotImplementedException("error");
            }
            else
            {
                Whole -= whole;
                if (fractional <= Fractional)
                {
                    Fractional -= fractional;
                }
                else
                {
                    Whole--;
                    Fractional += (byte)(100 - fractional);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("product_name_1", 100, 9);
            Console.WriteLine(product1);

            product1.ReduceThePrice(11, 83);
            Console.WriteLine(product1);
        }
    }
}

