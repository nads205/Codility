using System.Linq;

namespace Codility
{
    public class SampleTest
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //if sequence contains no positive numbers return 1;
            var anyPositiveNumbers = A.Any(x => x > 0);
            if (!anyPositiveNumbers) return 1;

            //if there are any missing numbers then return the first missing
            var ret = Enumerable.Range(1, A.Max()).Except(A.OrderBy(x => x));
            if (ret.Any()) return ret.FirstOrDefault();

            //else 
            return A.OrderBy(x => x).Max() + 1;
        }
    }
}
