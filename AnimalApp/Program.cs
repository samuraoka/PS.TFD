using Animals;
using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var responses = dog.Bark(0);

            foreach (var response in responses)
            {
                Console.WriteLine(response);
            }
        }
    }
}
