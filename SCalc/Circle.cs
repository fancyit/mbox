namespace SCalc
{
    /// <summary>
    /// Class describes the circle shape
    /// you may initialize it without specifing the raius or with it
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;
        /// <summary>
        /// parameterless constructor
        /// </summary>
        public Circle() { }

        /// <summary>
        /// constructor with single param
        /// </summary>
        /// <param name="r">Specify the radius of the circle</param>
        public Circle(double r)
        {
            _radius = r;
        }
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_radius), $"Circle radius should be grather than 0.");
                }
                _radius = value;
            }
        }
        /// <summary>
        /// Method to calculate the area
        /// </summary>
        /// <returns>Area of the circle rounded to two decimal places away from zero</returns>
        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2, MidpointRounding.AwayFromZero);
        }
    }
}