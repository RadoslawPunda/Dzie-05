using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejkaPriorytet
{
    class QueuePriority
    {
        List<Customer> customers = new List<Customer>();

        public void Que(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer DeQueue()
        {
            int maxPrior = -1;
            int index = -1;

            if (customers.Count == 0) return null;

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Priority > maxPrior)
                {
                    maxPrior = customers[i].Priority;
                    index = i;
                }
            }
            if (index == -1) return null;

            Customer c = customers[index];
            customers.RemoveAt(index);

            return c;
        }
    }
}
