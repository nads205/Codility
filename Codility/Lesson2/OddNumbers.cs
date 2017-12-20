using System.Linq;

namespace Codility
{
    public class OddNumbers
    {
        public static int solution(int[] A)
        {
            var similarNumbers = A.GroupBy(x => x).ToList();
            similarNumbers.RemoveAll(x => x.Count() % 2 == 0);
            return similarNumbers.First().Key;
        }
    }
}
