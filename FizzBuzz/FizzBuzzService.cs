using System;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzCalculator
    {
        private string ComponentName = "LOL";
        
        public virtual string Calculate(int inputNum)
        {
            if (IsMultipleOfThree(inputNum) && IsMultipleOfFive(inputNum))
            {
                return "FizzBuzz";
            }
            if (IsMultipleOfThree(inputNum))
            {
                return "Fizz";
            }
            if (IsMultipleOfFive(inputNum))
            {
                return "Buzz";
            }
            return inputNum.ToString();
        }

        private Boolean IsMultipleOfThree(int inputNum)
        {
            if (inputNum % 3 == 0)
            {
                return true;
            }
            return false;
        }

        private Boolean IsMultipleOfFive(int inputNum)
        {
            if (inputNum % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
