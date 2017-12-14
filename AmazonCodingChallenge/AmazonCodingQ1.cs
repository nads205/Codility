
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public static class AmazonQ1Solution
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //get a list of all distinct elements in the list
            var distinct = A.Distinct().ToList();

            //Get all sublists
            var lists = A.Select((t, x) => GetLists(A, x)).Select(sublists => sublists.ToList()).ToList();

            //find the shortest sublist where the occurance exists
            foreach (var list in lists)
            {
                foreach (var l1 in list)
                {
                    var areTheyAllThere = ContainsAll(l1, distinct);
                    if (areTheyAllThere) return l1.Count();
                }
            }

            //can't find? return 0
            return 0;
        }

        public static bool ContainsAll<T>(IEnumerable<T> source, IEnumerable<T> values)
        {
            return values.All(value => source.Contains(value));
        }

        static IEnumerable<int[]> GetLists(int[] list, int size)
        {
            return Enumerable.Range(0, list.Length - size + 1).Select(x => list.Skip(x).Take(size).ToArray());
        }
    }
}
