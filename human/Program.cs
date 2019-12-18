using System;
using HumanDLL;
using studentDll;

namespace human
{    
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student stu = new Student("Anon", "Bill", 20, Gender.Male, Countries.USA, Hobbies.Walking, 95, 165, 46, ConsoleColor.Green, ConsoleColor.Blue);

            stu.TheNameOfUniversity();
            stu.Characters();
        }
    }
}