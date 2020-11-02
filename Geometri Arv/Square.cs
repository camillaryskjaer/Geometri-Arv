using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public class Square
    {

        private double sitea;

        public double SiteA
        {
            get { return sitea; }
            set { sitea = value; }
        }

        private double siteb;

        public double SiteB
        {
            get { return sitea; }
            set { sitea = value; }
        }

        private double sitec;

        public double SiteC
        {
            get { return sitec; }
            set { sitec = value; }
        }

        private double sited;

        public double SiteD
        {
            get { return sited; }
            set { sited = value; }
        }


        /// <summary>
        /// Calculates area of a square
        /// </summary>
        /// <returns></returns>
        public virtual double ArealCalc()
        {
            double arealCalc = Math.Pow(SiteA, 2) * 2;

            return arealCalc;
        }


        /// <summary>
        /// Calculates circumference of a square
        /// </summary>
        /// <returns></returns>
        public virtual double CircCalc()
        {
            double circCalc = 4 * SiteA;

            return circCalc;
        }

        public Square()
        {
            SiteA = sitea;
            SiteB = siteb;
            SiteC = sitec;
            SiteD = sited;
        }


    }
}
