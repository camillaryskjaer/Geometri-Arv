using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public class Trapez : Square
    {

        private double height;

        /// <summary>
        /// Calculates the height of the Trapezoid
        /// </summary>
        private void CalcHeight()
        {
            double s = (SiteA + SiteB - SiteC + SiteD) / 2;
            height = (2 / (SiteA - SiteC)) * Math.Sqrt(s * (s - SiteA + SiteC) * (s - SiteB) * (s - SiteD));
            
        }

        /// <summary>
        /// Calculates Area of a Trapezoid
        /// </summary>
        /// <returns></returns>
        public override double ArealCalc()
        {
            CalcHeight();
            double result = 0.5 * (SiteA + SiteC) * height;

            return result;
        }

    }
}
