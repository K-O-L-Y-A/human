using System;

namespace HumanDLL
{
    public enum Gender
    {
        Anon,
        Male,
        Female
    }

    public enum Countries
    {
        Anon,
        USA,
        Russia,
        GreatBritain,
        Germany,
        Irland,
        Israel
    }

    public enum Hobbies
    {
        Anon,
        Walking,
        Talking,
        Eating,
        Sleeping,
        Playng,
        Building
    }

    public class Human
    {
        private int _age;
        private int _height;
        private int _shoeSize;
        private int _weight;
        public ConsoleColor HairColor { get; set; }
        public ConsoleColor EyesColor { get; set; }
        public Countries CountriesStatus { get; set; }
        public Hobbies HobbiesStatus { get; set; }
        public Gender GenderStatus { get; set; }
        public string Name { get; set; }
        public int Weight
        {
            get => _weight;
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("You need some sport");
                }
                else if (value < 40)
                {
                    Console.WriteLine("If you are child it's okey, but if you older then 16 years, you need to going the doctor");
                }
                else if (value > 60)
                {
                    Console.WriteLine("Normal Weight");
                }
                _weight = value;
            }
        }
        public int ShoeSize
        {
            get => _shoeSize;
            set
            {
                if (value > 60)
                {
                    Console.WriteLine("Seems like a giant");
                }
                else if (value < 35)
                {
                    Console.WriteLine("Little peaple are normal too");
                }
                else if (value > 46)
                {
                    Console.WriteLine("Normal human with normal ShoeSize");
                }

                _shoeSize = value;
            }
        }
        public int Height
        {
            get => _height;
            set
            {
                if (value > 180)
                {
                    Console.WriteLine("You are a giant?");
                }
                else if (value < 120)
                {
                    Console.WriteLine("You are a kid or small human");
                }
                else if (value > 160)
                {
                    Console.WriteLine("Congratulations! You have a norval Heigth!");
                }
                _height = value;
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value >= 60)
                {
                    Console.WriteLine("Elderly");
                }
                else if (value < 19)
                {
                    Console.WriteLine("Young");
                }
                else if (value > 30)
                {
                    Console.WriteLine("Adult");
                }
                _age = value;
            }
        }

        public void Characters()
        {
            Console.WriteLine($"Greatings! My name is {Name}, My age is {Age}, also i have a hobby {HobbiesStatus} , and you see my configurations of body:My Weight {_weight} - My Height {_height}, - And my ShoeSize {_shoeSize}");
            Console.WriteLine($"Also i have {EyesColor} color, and hair {HairColor} Color! That's me");
        }

        public Human()
        {
            Name = "Anon";
            Age = 0;
            GenderStatus = Gender.Anon;
            HobbiesStatus = Hobbies.Anon;
            CountriesStatus = Countries.Anon;
            Weight = 0;
            Height = 0;
            ShoeSize = 0;
            HairColor = ConsoleColor.White;
            EyesColor = ConsoleColor.White;
        }

        public Human(string name, int age, Gender gender, Countries countries, Hobbies hobbies, int weight, int height, int shoesize, ConsoleColor hairColor, ConsoleColor eyesColor)
        {
            Height = height;
            Weight = weight;
            ShoeSize = shoesize;
            HobbiesStatus = hobbies;
            CountriesStatus = countries;
            GenderStatus = gender;
            Name = name;
            Age = age;
            HairColor = hairColor;
            EyesColor = eyesColor;
        }
    }
}
