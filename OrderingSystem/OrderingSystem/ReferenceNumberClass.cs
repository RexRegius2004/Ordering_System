using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    class ReferenceNumberClass
    {
        public static object RefNo;

        public void ReferenceNumber()
        {
            generateRefNo();
            Console.ReadKey();
        }

        public static void generateRefNo()
        {
            Random rand = new Random();
            RefNo = rand.Next();
            Console.WriteLine("Reference Number:" + RefNo);

        }

    }
}
