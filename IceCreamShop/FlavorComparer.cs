﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}

        public int Compare(Flavor x, Flavor y)
        {
            return x.Allergens.Count - y.Allergens.Count;
        }
    }
}
