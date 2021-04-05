using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleComparerLib
{
    public class TriangleComparer : IComparable
    {
        #region =======------ PRIVATE DATA -------=======

        private double _firstSide = -1;
        private double _secondSide = -1;
        private double _thirdSide = -1;
        private double _triangleSquare = -1;
        private string _triangleName;

        #endregion

        #region ======------ CTOR ------========

        public TriangleComparer(string triangleName, double firstSide, double secondSide, double thirdSide)
        {
            _triangleName = triangleName;
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        #endregion

        #region ========-------- PROPERTIES ------=======

        public double TriangleSquare
        {
            get
            {
                return _triangleSquare;
            }
        }

        public string TrinagleName
        {
            get
            {
                return _triangleName;
            }
        }

        #endregion

        public void GetTriangleSquare()
        {
            double p = GetSemiPerimetr();

            _triangleSquare = Math.Round(Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide)), 2);
        }

        private double GetSemiPerimetr()
        {
            return ((_firstSide + _secondSide + _thirdSide) / 2);
        }

        public override string ToString()
        {
            return string.Format($"{_triangleName} - {_triangleSquare} cm");
        }

        public int CompareTo(double other)
        {
            return _triangleSquare.CompareTo(other);
        }

        public int CompareTo(object obj)
        {
            TriangleComparer triangle = obj as TriangleComparer;

            if (triangle == null)
            {
                return -1;
            }

            return _triangleSquare.CompareTo(triangle.TriangleSquare);
        }
    }
}
