namespace SCalc
{
    /// <summary>
    /// Triangle shape class
    /// </summary>
    public class Triangle : Shape
    {
        private double _heigth;
        private double _aSide;
        private double _bSide;
        private double _cSide;
        

        /// <summary>
        /// param less constructor
        /// </summary>
        public Triangle() { }

        /// <summary>
        /// Constructor taking 2 params: height and base side
        /// </summary>
        /// <param name="h">Heigth</param>
        /// <param name="b">Base side of triangle</param>
        public Triangle(double h, double b)
        {
            if (h <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(h), $"triangle heigth should be greather than zero.");
            }
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"triangle base side should be greather than zero.");
            }
            _heigth = h;
            _bSide = b;
        }

        /// <summary>
        /// Constructor taking 3 sides of triangle
        /// </summary>
        /// <param name="a">ab side</param>
        /// <param name="b">bc side</param>
        /// <param name="c">ca side</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"triangle a-side should be greather than zero.");
            }
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"triangle b-side side should be greather than zero.");
            }
            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(c), $"triangle c-side side should be greather than zero.");
            }
            _aSide = a;
            _bSide = b;
            _cSide = c;
        }
        public double Heigth
        {
            get => _heigth;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_heigth), $"triangle heigth should be greather than zero.");
                }
                _heigth = value;
            }
        }
        public double Base
        {
            get => _bSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_bSide), $"triangle base should be greather than zero.");
                }
                _bSide = value;
            }
        }
        public double ASide
        {
            get => _aSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_aSide), $"triangle base should be greather than zero.");
                }
                _aSide = value;
            }
        }
        public double CSide
        {
            get => _cSide;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_cSide), $"triangle base should be greather than zero.");
                }
                _cSide = value;
            }
        }
        public bool isIsosceles
        {
            get => _aSide == _bSide || _aSide == _cSide || _bSide == _cSide;
        }

        public bool isEquilateral
        {
            get => _aSide == _bSide && _bSide == _cSide;
        }

        /// <summary>
        /// Area calculation based on provided heigth or 3 sides
        /// </summary>
        /// <returns>Area of the triangle rounded to two decimal places away from zero</returns>
        public override double GetArea()
        {
            if (_heigth == 0)
            {
                double p = (_aSide + _bSide + _cSide) / 2;
                return Math.Round(Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide)), 2);
            }
            return 0.5 * _bSide * _heigth;
        }
    }
}