using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri_Arv
{
    public class Rektangel : Square
    {

        public override double ArealCalc()
        {
            double arealCalc = SiteA * SiteB;

            return arealCalc;
        }

    }
}
