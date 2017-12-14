using System;
using System.Linq;

namespace Codility.Lesson1
{
    public static class BinaryGap
    {
        public static int solution(int N)
        {
            var binaryRepresenation = convertToBinary(N);
            var splits = binaryRepresenation.Split('1').ToList();
            var lastChar = binaryRepresenation.LastCharacter();
            if (lastChar == '0') splits.RemoveAt(splits.Count - 1);
            return splits.Max().Length;
        }

        public static string convertToBinary(int N)
        {
            string bin = Convert.ToString(N, 2).PadLeft(50, '0');
            bin = bin.TrimStart('0');
            return bin;
        }
    }

    public static class ExtensionMethods
    {
        public static char LastCharacter(this string s)
        {
            return s[s.Length - 1];
        }
    }

}
