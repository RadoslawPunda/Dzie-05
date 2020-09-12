using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejkaPriorytet
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer("A", 1);
            Customer cust2 = new Customer("B", 2);
            Customer cust3 = new Customer("C", 1);
            Customer cust4 = new Customer("D", 3);
            Customer cust5 = new Customer("E", 2);

            QueuePriority queue = new QueuePriority();
            queue.Que(cust1);
            queue.Que(cust2);
            queue.Que(cust3);
            queue.Que(cust4);
            queue.Que(cust5);

            for (int i = 0; i < 6; i++)
            {
                Customer c = queue.DeQueue();
                if (c == null)
                {
                    Console.WriteLine("Odczytano NULL");
                }
                else
                {
                    Console.WriteLine("Element z kolejki: "+c);
                }
            }
            Console.ReadLine();
        }
    }
}
