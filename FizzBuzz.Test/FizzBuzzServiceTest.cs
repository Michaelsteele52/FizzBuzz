using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzServiceTest
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        //public void TestFizz(int input)
        //{
        //    FizzBuzzService fizz = new FizzBuzzService();
        //    var result = fizz.IsMultipleOfThree(input);
        //    Assert.IsTrue(result);
        //} 
        
        [TestCase(15)]
        public void TestFizzBuzz(int input)
        {
            FizzBuzzService fizz = new FizzBuzzService();
            Assert.AreEqual("FizzBuzz",fizz.Calculate(input));
        }

        //[TestCase(5)]
        //[TestCase(10)]
        //[TestCase(15)]
        //public void TestBuzz(int input)
        //{
        //    FizzBuzzService fizz = new FizzBuzzService();
        //    var result = fizz.IsMultipleOfFive(input);
        //    Assert.IsTrue(result);
        //}
    }
}
