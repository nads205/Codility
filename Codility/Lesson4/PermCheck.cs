using System.Linq;

namespace Codility.Lesson4
{
    public class PermCheck
    {
        public static int solution(int[] A)
        {
            if (A.Distinct().Count() != A.Count())  return 0;
            return A.Distinct().Count() == A.Max() ? 1 : 0;
        }
    }
}
