using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 4)
                Console.WriteLine("Yes, student will be have a scholarship");
            else
                Console.WriteLine("No, student won't be have a scholarship");
        }
    }
}
