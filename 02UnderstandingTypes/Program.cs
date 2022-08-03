using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(String.Format("sbyte uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(sbyte),sbyte.MinValue,sbyte.MaxValue));
            Console.WriteLine(String.Format("byte uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(String.Format("short uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(String.Format("ushort uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(String.Format("int uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(String.Format("uint uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(String.Format("long uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(String.Format("ulong uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine(String.Format("float uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(String.Format("double uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(String.Format("decimal uses {0} number of bytes in memory. Its minimum value is {1} and maximumvalue is {2}.\n", sizeof(decimal), decimal.MinValue, decimal.MaxValue));
            Console.ReadKey();
        
        }
    }
}
