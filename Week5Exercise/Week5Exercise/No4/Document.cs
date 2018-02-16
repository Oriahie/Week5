using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise.No4
{
    class Document : IStorable
    {
        public void ExportTo()
        {
            Console.WriteLine("Exporting Document");
        }

        public void Print()
        {
            Console.WriteLine("Printing Document");
        }

        public void Read()
        {
            Console.WriteLine("Read Document");
        }

        public void Write()
        {
            Console.WriteLine("Processing Document");
        }
    }
}
