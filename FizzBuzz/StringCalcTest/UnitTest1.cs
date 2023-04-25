using NUnit.Framework;
using StringCalc;

namespace StringCalcTest
{
    public class Tests
    {
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4,5", 15)]       
        [TestCase("", 0)]
        public void MethodAddTwoNumbersReturnSum(string num, int expectedResult)
        {
            Assert.That(ProgramCalc.Add(num), Is.EqualTo(expectedResult));
        }

        [TestCase("1,2\n3,4,5", 15)]
        public void MethodAddTwoNumbersReturnSum_WithNewLine(string num, int expectedResult)
        {
            Assert.That(ProgramCalc.Add(num), Is.EqualTo(expectedResult));
        }

        [TestCase("1/2\n3,4;5", 15)]
        public void MethodAddTwoNumbersReturnSum_WithNewDelimiters(string num, int expectedResult)
        {
            Assert.That(ProgramCalc.Add(num), Is.EqualTo(expectedResult));
        }

        [TestCase("1,-2")]
        public void MethodAddTwoNumbersWithNegativeThrowsException(string num)
        {
            Assert.That(() => ProgramCalc.Add(num), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain($"negatives not allowed {-2}"));
        }
    }
}