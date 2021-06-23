using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            FileMove mover = new FileMove();
            mover.Start();
        }
    }
}
