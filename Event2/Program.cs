using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment7EventAndDelegates
{

    class LongRunningTask
    {
        public delegate void Multiples(string number);



        public double MultiplesOf(Multiples num)
        {

            int total = 0;
            try
            {
                for (int i = 2; i < 10000000; i++)
                {
                    if ((i % 2) == 0)
                    {
                        total += i;
                        ;
                        num(total.ToString());
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Found {e.Message} exception during counting");
            }
            return total;
        }

    }



    class CallBack
    {
        public void ShowCount()
        {
            var totalMultiplesOf = new LongRunningTask();

            var total = totalMultiplesOf.MultiplesOf(x => Console.WriteLine($"It has found {x} multiples of 3"));

        }
    }
}
