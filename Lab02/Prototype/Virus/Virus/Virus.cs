using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virus
{
    public class Virus
    {
        public decimal Weight;
        public int Age;
        public string Name;
        public string Type;
        public List<Virus> Kids;

        public Virus Clone()
        {
            Virus clone = new Virus();
            clone.Weight = this.Weight;
            clone.Age = this.Age;
            clone.Name = this.Name;
            clone.Type = this.Type;
            clone.Kids = this.Kids;
            return clone;
        }
        public void PrintVirus(int indent = 0)
        {
            string indentSpace = new string(' ', indent * 2);
            Console.WriteLine($"{indentSpace}Name: {this.Name}");
            Console.WriteLine($"{indentSpace}Type: {this.Type}");
            Console.WriteLine($"{indentSpace}Weight: {this.Weight}");
            Console.WriteLine($"{indentSpace}Age: {this.Age}\n");


            if (Kids != null && Kids.Count > 0)
            {
                Console.WriteLine($"{indentSpace}Kids:");
                foreach (var kid in this.Kids)
                {
                    kid.PrintVirus(indent + 1);
                }
            }
        }
    }
}
