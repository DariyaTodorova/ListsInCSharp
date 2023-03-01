using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi broi elementi: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi chislo: ");
                int item = int.Parse(Console.ReadLine());
                numbers.Add(item);
            }
            //dobavq v sredata
            //int newIndex = n / 2;
            //numbers.Insert(newIndex, 6);
            ////dobavqne v kraq na min element
            //int minElement = numbers.Min();
            //numbers.Add(minElement);
            //da iztriya 0te vsichki
            //foreach (int x in numbers) 
            while (numbers.Contains(0))
            {
                    numbers.Remove(0);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            Console.WriteLine($"Broqt na elementite v spisuka e : {numbers.Count}");
        }
    }
}
