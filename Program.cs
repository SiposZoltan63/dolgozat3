using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homersekletek = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Add meg a héten az {i + 1} napi hőmérséklet értékét.");
                homersekletek[i] = Convert.ToInt32(Console.ReadLine());
            }

            int HetHomersekletOsszege = 0;
            for (int i = 0; i < 7; i++)
            {
                HetHomersekletOsszege += homersekletek[i];
            }

            double HetAtlagHomerseklete = HetHomersekletOsszege / 7.0;

            int legmelegebb = homersekletek[0];
            int leghidegebb = homersekletek[0];

            for (int i = 1; i < 7; i++)
            {
                if (homersekletek[i] > legmelegebb)
                {
                    legmelegebb = homersekletek[i];
                }
                if (homersekletek[i] < leghidegebb)
                {
                    leghidegebb = homersekletek[i];
                }
            }

            Console.WriteLine($"A hét átlag hőmérséklete {HetAtlagHomerseklete} Celsius fok: ");
            Console.WriteLine($"A hét legmelegebb napja {legmelegebb} Celsius fok");
            Console.WriteLine($"A hét leghidegebb napja {leghidegebb} Celsius fok");
            Console.ReadLine();

        }
    }
}
