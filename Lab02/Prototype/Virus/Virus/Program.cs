using System;
using System.Collections.Generic;

namespace Virus
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus prototype = new Virus
            {
                Name = "Prototype",
                Type = "Alpha",
                Weight = 3.2m,
                Age = 5,
                Kids = new List<Virus>()
            };

            Virus child1 = new Virus
            {
                Name = "Child1",
                Type = "Beta",
                Weight = 1.5m,
                Age = 2,
                Kids = new List<Virus>()
            };

            Virus child2 = new Virus
            {
                Name = "Child2",
                Type = "Gamma",
                Weight = 1.8m,
                Age = 3,
                Kids = new List<Virus>()
            };

            child1.Kids.Add(new Virus
            {
                Name = "Grandchild1",
                Type = "Delta",
                Weight = 0.7m,
                Age = 1,
                Kids = new List<Virus>()
            });

            child1.Kids.Add(new Virus
            {
                Name = "Grandchild2",
                Type = "Epsilon",
                Weight = 0.6m,
                Age = 1,
                Kids = new List<Virus>()
            });

            child2.Kids.Add(new Virus
            {
                Name = "Grandchild3",
                Type = "Zeta",
                Weight = 0.8m,
                Age = 1,
                Kids = new List<Virus>()
            });

            prototype.Kids.Add(child1);
            prototype.Kids.Add(child2);

            Virus clone = prototype.Clone();

            Console.WriteLine("Original Virus:");
            prototype.PrintVirus();

            Console.WriteLine("\nChild 2:");
            child2.PrintVirus();

            Console.WriteLine("\nCloned Virus:");
            clone.PrintVirus();

            Console.ReadLine();
        }
    }
}
