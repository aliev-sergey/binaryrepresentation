using System;
using System.Linq;
using System.Text;

namespace BinaryRepresentation
{
    /// <summary>
    /// Статический утилитарный класс для преобразования целого десятичного значения в двоичное
    /// </summary>
    public static class IntToBinary
    {
        /// <summary>
        /// Разрядность целого числа
        /// </summary>
        private static int BitNumber = 32;
        /// <summary>
        /// Метод, который преобразует целое десятичное значение в двоичное строковое
        /// </summary>
        /// <param name="number">число, которое необходимо преобразовать</param>
        /// <returns></returns>
        public static string Transform(int number)
        {
            StringBuilder sb = new StringBuilder();
            int mask = 1;

            for (int i = 0; i < BitNumber; i++)
            {
                if ((number & (mask << i)) > 0)
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
