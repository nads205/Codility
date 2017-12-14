using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Lesson5
{
    
    public class PrefixSums
    {
        private static readonly List<Tuple<string, int, int, int>> _cache = new List<Tuple<string, int, int, int>>();

        public static int[] solution(string S, int[] P, int[] Q)
        {
            var dnaSequence = S;
            var dnaSequenceD = new Dictionary<int,int>();


            int count = 0;
            foreach (var s in S)
            {
                if (s == 'A') dnaSequenceD.Add(count, 1);
                if (s == 'C') dnaSequenceD.Add(count, 2);
                if (s == 'G') dnaSequenceD.Add(count, 3);
                if (s == 'T') dnaSequenceD.Add(count, 4);
                count++;
            }

            var result = new int[P.Length];
            for (var i = 0; i < P.Length; i++)
            {
                var lowestRange = P[i] < Q[i] ? P[i] : Q[i];
                var highesestRange = P[i] > Q[i] ? P[i] : Q[i];
                var cacheHit = _cache.FirstOrDefault(c => c.Item1 == dnaSequence && c.Item2 == lowestRange && c.Item3 == highesestRange);
                if (cacheHit != null)
                {
                    result[i] = cacheHit.Item4;
                }
                else
                {
                    result[i] = dnaSequenceD.ToNucleotides(lowestRange, highesestRange);
                    _cache.Add(new Tuple<string, int, int, int>(dnaSequence, lowestRange, highesestRange, result[i]));
                }
            }
            return result;


            //var result = new int[P.Length];
            //for (var i = 0; i < P.Length; i++)
            //{
            //    var lowestRange = P[i] < Q[i] ? P[i] : Q[i];
            //    var highesestRange = P[i] > Q[i] ? P[i] : Q[i];

            //    var cacheHit = _cache.FirstOrDefault(c => c.Item1 == dnaSequence && c.Item2 == lowestRange && c.Item3 == highesestRange);                
            //    if (cacheHit != null)
            //    {
            //        result[i] = cacheHit.Item4;
            //    }
            //    else 
            //    {
            //        result[i] = dnaSequence.ToNucleotidesRangePerformance(lowestRange, highesestRange);
            //        _cache.Add(new Tuple<string, int, int, int>(dnaSequence, lowestRange, highesestRange, result[i]));
            //    }
            //}
            //return result;
        }    
    }    

    public static class ExtensionMethods
    {
        public static int ToNucleotidesRangePerformance(this string S, int start, int end)
        {
            var length = end - start + 1;

            {
                var lowestValSoFar = 4;
                var lowestVal = 4;
                for (int i = start; i <= end; i++)
                {
                    if (S[i] == 'A') lowestVal = 1;
                    if (S[i] == 'C') lowestVal = 2;
                    if (S[i] == 'G') lowestVal = 3;
                    if (lowestVal < lowestValSoFar) lowestValSoFar = lowestVal;
                    if (lowestValSoFar == 1) return 1;
                }
                return lowestValSoFar;
            }
        }

        public static int ToNucleotides(this Dictionary<int,int> S, int start, int end)
        {
            var length = end - start + 1;

            var element = S.Where(c=>c.Key >= start && c.Key <= end).OrderBy(c=>c.Value).Take(1).First().Value;
            return element;
        }

    }    
}
