using System;

namespace hw6_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*
     Создать абстрактный класс «Садовое растение».
    От него наследовать классы «Овощ», «Фруктовое дерево»,
    «Ягода». От них наследовать соответствующие классы «Яблоня»,
    «Картошка», «Малина». Описать свойства – «Урожайность»,
    «Цвет плода», «Время созревания» и т.д.
    Предоставить возможность вывести на экран все растения
    в порядке созревания урожая, вывести 3 самых урожайных вида. 
    */
    internal class Program
    {
        abstract public class GardenPlant
        {
            protected int productivity;
            protected string color;
            protected string ripeningperiod;

            public abstract int Productivity
            {
                get;
                set;
            }
            public abstract string Color
            {
                get;
                set;
            }
            public abstract string RipeningPeriod
            {
                get;
                set;
            }
            public abstract void toString();

            public class Vegetable : GardenPlant
            {
                public override int Productivity
                {
                    get { return productivity; }
                    set { productivity = value; }
                }
                public override string Color
                {
                    get { return color; }
                    set { color = value; }
                }
                public override string RipeningPeriod
                {
                    get { return ripeningperiod; }
                    set { ripeningperiod = value; }
                }
                public override void toString()
                {
                    Console.WriteLine("Урожайность с гектара земли в тоннах: {0}", productivity);
                    Console.WriteLine("Цвет плода: {0}", color);
                    Console.WriteLine("Время созревания: {0}", ripeningperiod);
                }
                public class Potato : Vegetable
                {
                    public Potato()
                    {
                        this.productivity = 25;
                        this.color = "Жёлтый";
                        this.ripeningperiod = "Август";
                    }
                    public override void toString()
                    {
                        base.toString();
                    }
                }
            }
            public class FruitTree : GardenPlant
            {
                public override int Productivity
                {
                    get { return productivity; }
                    set { productivity = value; }
                }
                public override string Color
                {
                    get { return color; }
                    set { color = value; }
                }
                public override string RipeningPeriod
                {
                    get { return ripeningperiod; }
                    set { ripeningperiod = value; }
                }
                public override void toString()
                {
                    Console.WriteLine("Урожайность с гектара земли в тоннах: {0}", productivity);
                    Console.WriteLine("Цвет плода: {0}", color);
                    Console.WriteLine("Время созревания: {0}", ripeningperiod);
                }
                public class AppleTree : FruitTree
                {
                    public AppleTree()
                    {
                        this.productivity = 40;
                        this.color = "Красный";
                        this.ripeningperiod = "Сентябрь";
                    }
                    public override void toString()
                    {
                        base.toString();
                    }
                }
            }
            public class Berry : GardenPlant
            {
                public override int Productivity
                {
                    get { return productivity; }
                    set { productivity = value; }
                }
                public override string Color
                {
                    get { return color; }
                    set { color = value; }
                }
                public override string RipeningPeriod
                {
                    get { return ripeningperiod; }
                    set { ripeningperiod = value; }
                }
                public override void toString()
                {
                    Console.WriteLine("Урожайность с гектара земли в тоннах: {0}", productivity);
                    Console.WriteLine("Цвет плода: {0}", color);
                    Console.WriteLine("Время созревания: {0}", ripeningperiod);
                }
                public class Raspberry : Berry
                {
                    public Raspberry()
                    {
                        this.productivity = 15;
                        this.color = "Малиновый";
                        this.ripeningperiod = "Август";
                    }
                    public override void toString()
                    {
                        base.toString();
                    }

                }
            }
        }

    }

}