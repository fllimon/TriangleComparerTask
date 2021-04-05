using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleComparerView
{
    class DataValidator
    {
        public bool GetData(string name, double firstSide, double secondSide, double thirdSide)
        {
            bool isOk = true;
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    return isOk = false;
                }

                isOk = GetValidData(firstSide, secondSide, thirdSide);

                return isOk;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Not correct values. {ex.Message}");

                return isOk = false;
            }
        }

        private bool GetValidData(double firstSide, double secondSide, double thirdSide)
        {
            bool isOk = true;

            if (!IsTriangle(firstSide, secondSide, thirdSide) || !IsTriangle(secondSide, thirdSide, firstSide)
                    || !IsTriangle(firstSide, thirdSide, secondSide))
            {
                return isOk = false;
            }

            return isOk;
        }

        private bool IsTriangle(double a, double b, double c)
        {
            return ((a + b) > c);
        }
    }
}
