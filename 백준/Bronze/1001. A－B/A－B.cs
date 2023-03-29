using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] inputArr = Console.ReadLine().Split();//위에서 받은 값을 나눔. 기준은 공백. 예로

            int a = int.Parse(inputArr[0]);
            int b = int.Parse(inputArr[1]);

            Console.WriteLine(a - b);
        }
    }
}