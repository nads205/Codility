using System;


namespace Codility
{
    public class AmazonCodingQ2
    {
        public static int solution(int[] A, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //if the monkey can leap across the river in just one jump, return 0
            var numberOfSteps = A.Length;
            var maxJump = D;
            if (maxJump >= numberOfSteps) return 0;


            throw new NotImplementedException();
        }
    }
}
