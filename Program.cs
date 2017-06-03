using System;
using System.Collections.Generic;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 start = 5; 
            Int64 nummer = start - 2; 
            int teller = 2; 
            Int64 optellen = 5;
            int limit = 100000;
            double startTime = Environment.TickCount;
            List<Int64> primes = new List<Int64>();

            for (start = start; nummer > 2; start = start + 2)
            {
                foreach (Int64 prime in primes )
                {
                    if (start % prime == 0)
                    {
                        continue;
                    }
                }
                if (start % nummer == 0)
                {
                    continue;
                }
                else
                {
                    nummer = (start / 2) + 1; 
                    for (start = start; start % nummer != 0; nummer = nummer - 1)
                    {
                        if (nummer <= 2)
                        {
                            teller = teller + 1;
                            optellen = optellen + start;
                            if (start < 100)
                            {
                                primes.Add(start);
                            }
                            
                            if (start >= limit) 
                            {
                                double endTime = Environment.TickCount;                    
                                Console.WriteLine("total sum of all primes below " + limit + " is: " + (optellen - start));
                                Console.WriteLine("time to compute in ms: " + (endTime - startTime));
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    nummer = (start / 2) + 1; 
                }
            }
        }
    }
}
