using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public class Parallelogram : Square
    {

        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public Parallelogram()
        {
            Angle = angle;
        }

        /// <summary>
        /// Calculates area of Parallelogram
        /// </summary>
        /// <returns></returns>
        public override double ArealCalc()
        {

            double radians = (Math.PI / 180) * Angle;
            double arealCalc = (SiteA * SiteB) * Math.Sin(radians);

            return arealCalc;
        }
    }
}
