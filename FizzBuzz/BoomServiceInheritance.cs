using System;

namespace FizzBuzz
{
    public class BoomServiceInheritance : FizzBuzzService
    {
        public override string Calculate(int inputNum)
        {
            string value = base.Calculate(inputNum);
            if (Boom(inputNum.ToString()))
            {
                value = "Boom";
            }
            return value;
        }

        private Boolean Boom(String inputNum)
        {
            if (inputNum.Contains("0"))
            {
                return true;
            }
            return false;
        }
    }
}
