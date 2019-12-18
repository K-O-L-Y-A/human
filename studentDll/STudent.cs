using HumanDLL;
using System;

namespace studentDll
{
    public class Student : Human
    {
        public string NameOfUniversity { get; set; }

        public Student(string nameOfUniversity,
                        string name, 
                        int age, 
                        Gender gender, 
                        Countries countries, 
                        Hobbies hobbies, 
                        int weight, 
                        int height, 
                        int shoesize, 
                        ConsoleColor hairColor, 
                        ConsoleColor eyesColor
                    ) : base(name,
                        age,
                        gender,
                        countries,
                        hobbies,
                        weight,
                        height,
                        shoesize,
                        hairColor,
                        eyesColor)          
                                   
        {
            NameOfUniversity = nameOfUniversity;
        }
        public Student() : base()
        {
            NameOfUniversity = "Anon";

        }

        public void TheNameOfUniversity()
        {
            Console.WriteLine("Name Of University: " + NameOfUniversity);
        }
    }
}