using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw6
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
    /*

    */

    /*
    abstract class Animal
        {
            protected int age;
            protected string food;
            protected string place;
            protected string name;
            public abstract string Food
            {
                get;
                set;
            }
            public abstract int Age
            {
                get;
                set;
            }
            public abstract string Place
            {
                get;
                set;
            }
            public string Name
            {
                get;
                set;
            }
            public abstract void toString();

        }
        class Mammal : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }

        }
        class Reptile : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }
        class Bird : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }
        class Fish : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }


        class Dog : Mammal
        {
            private string dogSound;
            public Dog()
            {
                this.food = "Sausage";
                this.age = 10;
                this.place = "Home";
                dogSound = "Woof Woof";
                Name = "Dog";
            }

            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Sound: {0}", dogSound);
                base.toString();

            }
        }
        class Cat : Mammal
        {
            private string russianName;
            public Cat()
            {
                this.food = "Meat";
                this.age = 10;
                this.place = "Home";
                russianName = "Кошка";
                Name = "Cat";
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("RussianName: {0}", russianName);
                base.toString();

            }
        }


        class Salamander : Reptile
        {
            private string behavior;
            public Salamander()
            {
                this.food = "Maggots";
                this.age = 20;
                this.place = "Forest";
                behavior = "Change body's color";
                Name = "Salamander";
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Behavior: {0}", behavior);
                base.toString();

            }
        }


        class Eagle : Bird
        {
            private int speed;
            public Eagle()
            {
                this.food = "Raw meat";
                this.age = 30;
                this.place = "Sky";
                Name = "Eagle";
                speed = 100;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Speed: {0}", speed);
                base.toString();

            }
        }
        class Sparrow : Bird
        {
            private int speed;
            public Sparrow()
            {
                this.food = "Grain";
                this.age = 3;
                this.place = "Sky";
                Name = "Sparrow";
                speed = 20;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Speed: {0}", speed);
                base.toString();

            }
        }


        class Shark : Fish
        {
            private int weight;
            public Shark()
            {
                this.food = "Fish meat";
                this.age = 25;
                this.place = "Ocean";
                Name = "Shark";
                weight = 100;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Weight: {0}", weight);
                base.toString();

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Information about animals:");

            List<Mammal> mammals = new List<Mammal>();
            mammals.Add(new Dog());
            mammals.Add(new Cat());

            List<Bird> birds = new List<Bird>();
            birds.Add(new Eagle());
            birds.Add(new Sparrow());

            List<Reptile> reptiles = new List<Reptile>();
            reptiles.Add(new Salamander());

            List<Fish> fishes = new List<Fish>();
            fishes.Add(new Shark());


            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Mammal m in mammals)
                {
                    if (Convert.ToInt32(m.Name[0]) == i)
                    {
                        m.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Bird b in birds)
                {
                    if (Convert.ToInt32(b.Name[0]) == i)
                    {
                        b.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Reptile r in reptiles)
                {
                    if (Convert.ToInt32(r.Name[0]) == i)
                    {
                        r.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
                        for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Fish f in fishes)
                {
                    if (Convert.ToInt32(f.Name[0]) == i)
                    {
                        f.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }


            Console.WriteLine("\nInformation about mammals and birds live more than 5 years:");
            foreach(Mammal m in mammals)
            {
                if (m.Age > 5) Console.WriteLine(m.Name);
            }
            foreach (Bird b in birds)
            {
                if (b.Age > 5) Console.WriteLine(b.Name);
            }

        }
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         

        private void btnAct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
