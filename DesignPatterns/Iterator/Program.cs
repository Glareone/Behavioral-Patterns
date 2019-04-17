using System;
using Iterator.Entities;

namespace Iterator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var coworkersProfileCollection = new ConcreteCollection<Profile>();

            coworkersProfileCollection[0] = new Profile
            {
                Name = "Alexey",
                Surname = "Kolesnikov",
                Age = 30
            };
            coworkersProfileCollection[1] = new Profile
            {
                Name = "Anton",
                Surname = "Vlasik",
                Age = 31
            };
            coworkersProfileCollection[2] = new Profile
            {
                Name = "Sergey",
                Surname = "Egorov",
                Age = 35
            };
            coworkersProfileCollection[3] = new Profile
            {
                Name = "Maksim",
                Surname = "Zuy",
                Age = 26
            };

            var concreteIterator = coworkersProfileCollection.GetIterator();

            Console.WriteLine("Read collection with default iterator");
            
            for (var profile = concreteIterator.FirstItem;
                concreteIterator.HasNext();
                profile = concreteIterator.GetNext)
            {
                Console.WriteLine($"{profile.Name}, {profile.Surname}, {profile.Age}");
            }

            Console.ReadKey();
        }
    }
}
