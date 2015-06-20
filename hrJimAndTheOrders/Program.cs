using System;
using System.Linq;

namespace hrJimAndTheOrders
{
    class Program
    {
        private struct Order
        {
            public readonly int Index;
            public readonly int ArrivalTime;

            public Order(int index, int time, int duration)
            {
                Index = index;
                ArrivalTime = time + duration;
            }
        }

        static void Main()
        {
            var numOrders = Int32.Parse(Console.ReadLine());
            var orders = new Order[numOrders];
            for (int i = 0; i < numOrders; ++i)
            {
                var tAndD = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                orders[i] = new Order(i + 1, tAndD[0], tAndD[1]);
            }
            orders = orders.OrderBy(x => x.ArrivalTime).ThenBy(x => x.Index).ToArray();
            var indices = orders.Select(x => x.Index).Select(x => x.ToString()).ToArray();
            Console.WriteLine(String.Join(" ", indices));
        }
    }
}
