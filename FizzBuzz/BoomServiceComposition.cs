using System;

namespace FizzBuzz
{
    public class BoomServiceComposition : IFizzBuzzCalculator
    {
        private IFizzBuzzCalculator _baseService;

        public BoomServiceComposition(IFizzBuzzCalculator baseClass)
        {
            _baseService = baseClass;
        }

        private Boolean Boom(String inputNum)
        {
            if (inputNum.Contains("0"))
            {
                return true;
            }
            return false;
        }

        public string Calculate(int inputNum)
        {
            string baseClassResult = _baseService.Calculate(inputNum);
            if (Boom(inputNum.ToString()))
            {
                baseClassResult = "Boom";
            }
            return baseClassResult;
        }
    }
}
