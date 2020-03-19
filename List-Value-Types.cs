using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 254;
            Int16 c = 2;
            Int32 d = 333;
            Int64 e = 23213213;
            String s = "";
            Exception ex = new Exception();
            Object[] types = { a, b, c, d, e, s, ex };
            foreach(object t in types)
            {
                bool ff = t.GetType().IsValueType;
                Console.WriteLine("Type = {0}, IsValueType = {1}", t.GetType(), ff);
            }
        }
    }
}
