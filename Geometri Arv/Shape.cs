using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public abstract class Shape
    {

		

		private double siteb;

		public double SiteB
		{
			get { return siteb; }
			set { siteb = value; }
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


		///Function to calculate area of a square
		public abstract double ArealCalc();

		///Function to calculate circumference of a square
		public abstract double CircCalc();
	}
}
