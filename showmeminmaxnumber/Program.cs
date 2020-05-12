using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];


            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            int max = 0, min = number[0];

            for (int i = 0; i < number.Length; i++)
            {
                if (max < number[i])
                    max = number[i];
                if (min > number[i])
                    min = number[i];
            }


            Console.WriteLine("---------------------------");
            Console.WriteLine("가장 큰 수: " + max);
            Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
