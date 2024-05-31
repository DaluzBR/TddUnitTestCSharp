using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Models
{
    public class Calculator
    {

        private List<string> Historic { get; set; }

        public Calculator()
        {
            Historic = new List<string>();
        }

        public int Sum(int number1, int number2)
        {
            var result = number1 + number2;

            Historic.Insert(0, $"{number1} + {number2} = {result}");

            return result;
        }

        public int Subtract(int number1, int number2)
        {
            var result = number1 - number2;

            Historic.Insert(0, $"{number1} - {number2} = {result}");

            return result;
        }

        public int Multiply(int number1, int number2)
        {
            var result = number1 * number2;

            Historic.Insert(0, $"{number1} * {number2} = {result}");

            return result;
        }

        public int Division(int number1, int number2)
        {
            if (number2 == 0.0)
            {
                throw new ArithmeticException("Erro: Divisão por zero.");
            }

            var result = number1 / number2;

            Historic.Insert(0, $"{number1} / {number2} = {result}");

            return result;
        }

        public List<string> ShowHistoric()
        {
            return Historic.GetRange(0, Math.Min(Historic.Count, 3));
        }
    }
}