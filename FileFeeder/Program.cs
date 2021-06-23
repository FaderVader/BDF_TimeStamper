using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFeeder
{
    class Program
    {
        /*
         * Very simple console-app, that polls a source-directory
         * and copies files to target-dir if the time-stamp name is in the past.
         * Intended to process a collection of files whose name-time-stamp are still in the future.
         * As the app runs, it will gradually move qualified files to target-directory.
         */
        static void Main(string[] args)
        {
            FileMove mover = new FileMove();
            mover.Start();
        }
    }
}
