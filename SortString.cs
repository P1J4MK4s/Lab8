using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Hello, im tired";
            string[] sa = stroka.Split(' ');
            Array.Sort(sa);
            string newstroka = String.Join(" ",sa);
        }
    }
}
