using System.Text;
using Codility;
using Codility.Lesson1;
using Codility.Lesson4;
using Codility.Lesson5;
using NUnit.Framework;

namespace Codality.UnitTests
{
    [TestFixture]
    public class SampleTestTests
    {
        [Test]
        public void Test1()
        {
            var testCase = new int[] {1, 3, 6, 4, 1, 2};
            Assert.That(SampleTest.solution(testCase) == 5);
        }

        [Test]
        public void Test2()
        {
            var testCase = new int[] {1, 2, 3};
            Assert.That(SampleTest.solution(testCase) == 4);
        }

        [Test]
        public void Test3()
        {
            var testCase = new int[] {-1, -3};
            Assert.That(SampleTest.solution(testCase) == 1);
        }

        [Test]
        public void Test4()
        {
            var testCase = new int[] {2};
            Assert.That(SampleTest.solution(testCase) == 1);
        }
    }

    [TestFixture]
    public class TestOddNumbers
    {

        [Test]
        public void Test1()
        {
            var testCase = new int[] {9, 3, 9, 3, 9, 7, 9};
            Assert.That(OddNumbers.solution(testCase) == 7);

            testCase = new int[] {9, 3, 9, 9, 3, 7, 9};
            Assert.That(OddNumbers.solution(testCase) == 7);

            testCase = new int[] {44, 44, 88, 88, 88};
            Assert.AreEqual(88, OddNumbers.solution(testCase));
        }
    }

    [TestFixture]
    public class TestBinaryGap
    {
        [Test]
        public void TestBinaryConversion()
        {
            Assert.AreEqual("1000010001", BinaryGap.convertToBinary(529));
            Assert.AreEqual("1001", BinaryGap.convertToBinary(9));
            Assert.AreEqual("10100", BinaryGap.convertToBinary(20));
            Assert.AreEqual("1111", BinaryGap.convertToBinary(15));
            Assert.AreEqual("1111111111111111111111111111111", BinaryGap.convertToBinary(2147483647));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(4, BinaryGap.solution(529));
            Assert.AreEqual(2, BinaryGap.solution(9));
            Assert.AreEqual(1, BinaryGap.solution(20));
            Assert.AreEqual(0, BinaryGap.solution(15));

        }
    }

    [TestFixture]
    internal class TestsAmazonCoding
    {
        [Test]
        public void Test1()
        {
            var testCase = new int[] {7, 3, 7, 3, 1, 3, 4, 1};
            Assert.AreEqual(AmazonQ1Solution.solution(testCase), 5);
        }

        [Test]
        public void TestMonkeyQuestion()
        {
            var testCase = new int[] {1, -1, 0, 2, 3, 5};
            Assert.AreEqual(AmazonCodingQ2.solution(testCase, 3), 2);
        }
    }

    [TestFixture]
    internal class TestPermCheck
    {
        [Test]
        public void Test1()
        {
            var testCase = new int[] {4, 1, 3, 2};
            Assert.AreEqual(PermCheck.solution(testCase), 1);
            testCase = new int[] {4, 1, 3};
            Assert.AreEqual(PermCheck.solution(testCase), 0);
        }
    }

    [TestFixture]
    internal class TestPrefixSums
    {
        //    For example, given the string S = CAGCCTA and arrays P, Q such that:
        //    P[0] = 2    Q[0] = 4
        //    P[1] = 5    Q[1] = 5
        //    P[2] = 0    Q[2] = 6
        //the function should return the values[2, 4, 1], as explained above.   

        //    [Test]
        //public void TestNucleodCreation()
        //{   
        //        const string s = "CAGCCTA";
        //        var result = s.ToNucleotides();
        //        var expectedResult = new int[] { 2, 1, 3, 2, 2, 4, 1};
        //        Assert.AreEqual(result, expectedResult);
        //    }

        //[Test]
        //    public void TestNucleodRangeCreation()
        //    {
        //        const string s = "CAGCCTA";
        //        var result = s.ToNucleotidesRange(2,4);
        //        var expectedResut = new int[] { 3, 2, 2};
        //        Assert.AreEqual(result, expectedResut);
        //    }

        [Test]
        public void TestExample()
        {
            var s = "CAGCCTA";
            var p = new int[] {2, 5, 0};
            var q = new int[] {4, 5, 6};
            var result = PrefixSums.solution(s, p, q);
            Assert.AreEqual(result, new int[] {2, 4, 1});
        }

        [Test]
        public void TestSingle()
        {
            var s = "A";
            var p = new int[] {0};
            var q = new int[] {0};
            var result = PrefixSums.solution(s, p, q);
            Assert.AreEqual(new int[] {1}, result);
        }



        [Test]
        public void TestSingle1()
        {
            var s = "TC";
            var p = new int[] {0, 0, 1};
            var q = new int[] {0, 1, 1};
            var result = PrefixSums.solution(s, p, q);
            Assert.AreEqual(new int[] {4, 2, 2}, result);
        }


        [Test]
        public void TestLarge()
        {
            var p = new int[49999];
            var q = new int[49999];
            var expected = new int[49999];
            var s1 = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                s1.Append("G");
            }
            for (var x = 0; x < 49999; x++)
            {
                p[x] = 0;
                q[x] = 99999;
                expected[x] = 3;
            }

            var result = PrefixSums.solution(s1.ToString(), p, q);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestAlmostAllSame()
        {
            var p = new int[49999];
            var q = new int[49999];
            var expected = new int[49999];
            var s1 = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                s1.Append(i%100 == 0 ? "A" : "G");
            }
            for (var x = 0; x < 49999; x++)
            {
                p[x] = 0;
                q[x] = 99999;
                expected[x] = 1;
            }

            var result = PrefixSums.solution(s1.ToString(), p, q);
            Assert.AreEqual(result, expected);
        }
    }

    [TestFixture]
    internal class TestCountDiv
    {
        [TestCase(10, 10, 5, Result = 1)]
        [TestCase(1, 10, 2, Result = 5)]
        [TestCase(6, 11, 2, Result = 3)]
        [TestCase(0, int.MaxValue, int.MaxValue, Result = 1)]
        [TestCase(11, 345, 17, Result = 20)]
        [TestCase(0, 11, 11, Result = 1)]
        [TestCase(101, 123000000, 10000, Result = 12345)]
        [TestCase(0, int.MaxValue, 1, Result = 2000000001)]

        [Test]
        public int Test(int A,int B, int K)
        {
            var result = CountDiv.solution3(A, B, K);
            return result;
        }
    }
}
