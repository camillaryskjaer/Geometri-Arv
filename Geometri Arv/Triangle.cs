using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public class Triangle : Square
    {
                     
        /// <summary>
        /// Calculates area of triangle
        /// </summary>
        /// <returns></returns>
        public override double ArealCalc()
        {
            double result = 0.5 * (SiteA * SiteB);

                return result;
        }
        /// <summary>
        /// calculates Circumference of triangle
        /// </summary>
        /// <returns></returns>
        public override double CircCalc()
        {
            double result = SiteA + SiteB + SiteC;

            return result;
        }
    }
}
