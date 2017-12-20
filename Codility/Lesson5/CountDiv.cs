using System;
using System.Linq;

namespace Codility.Lesson5
{
    public class CountDiv
    {
        public static int solution(int A, int B, int K)
        {
            var array = new int[B - A + 1];
            var count = 0;
            for (var i = A; i <= B; i++)
            {
                array[count] = i;
                count++;
            }
            return array.Where(i => i % K == 0).Count();
        }

        public static int solution1(int A, int B, int K)
        {
            var numberOfInts = B - A + 1;
            var numberDivisible = numberOfInts / K;
            return numberDivisible;
        }

        public static int solution2(int A, int B, int K)
        {
            var numberOfInts = B - A + 1;
            var numberDivisible = numberOfInts / K;
            return numberDivisible;
        }

        public static int solution3(int A, int B, int K)
        {
            //If the range if numbers is 1
            if (B - A == 0) return (B % K == 0) ? 1 : 0;

            var a = B / K; //2
            var b = A == 0 ? 0 : (A - 1) / K;//1
            return a - b;
        }

        public int IsDivisible(int x, int y)
        {
            return x%y == 0 ? 1 : 0;
        }
    }
}
