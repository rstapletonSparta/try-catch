using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace @throw
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowErr e = new ThrowErr();

            int[] arr = new int[3];
            for (int i = 0; i <= arr.Length; i++)
            {
                arr[i] = 8;
                e.ThrowException(i);
            }
        }
    }
    class ThrowErr
    {
        public void ThrowException(int i)
        {
            try
            {
                Console.WriteLine(++i);
            }
            catch (IndexOutOfRangeException err)
            {
                Console.WriteLine("an error has occored   :   {0}", err);
            }
        }
    }
}
