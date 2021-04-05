using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriangleComparerLib;

namespace TriangleComparerView
{
    class ConsoleControler
    {
        #region ========------- PRIVATE DATA -----========

        private List<TriangleComparer> _triangle = new List<TriangleComparer>();

        #endregion

        public TriangleComparer this[int index]
        {
            get
            {
                return _triangle[index];
            }
        }

        public int CountItems
        {
            get
            {
                return _triangle.Count;
            }
        }

        public bool AddNewTriangle(string name, string firstSide, string secondSide, string thirdSide)
        {
            bool isAdd = false;

            if (ConvertAndValidateData(name, firstSide, secondSide, thirdSide))
            {
                TriangleComparer someTriangle = new TriangleComparer(name, DataConvertor.ConvertData(firstSide),
                                                                        DataConvertor.ConvertData(secondSide),
                                                                        DataConvertor.ConvertData(thirdSide));
                someTriangle.GetTriangleSquare();

                _triangle.Add(someTriangle);

                _triangle.Sort();
                _triangle.Reverse();

                isAdd = true;
            }

            return isAdd;
        }

        private bool ConvertAndValidateData(string name, string firstSide, string secondSide, string thirdSide)
        {
            DataValidator validator = new DataValidator();

            bool result = validator.GetData(name, DataConvertor.ConvertData(firstSide),
                                DataConvertor.ConvertData(secondSide),
                                DataConvertor.ConvertData(thirdSide));

            return result;
        }
    }
}
