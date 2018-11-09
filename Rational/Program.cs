/*pair programmed by Connor Albers and Caleb Herring*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            MutableRational mute = new MutableRational(1, 1);
            Console.Out.WriteLine(mute.toString());
            ImmutableRational immute = new ImmutableRational(1, 1);
            Console.Out.WriteLine(immute.toString());
        }
    }
}
