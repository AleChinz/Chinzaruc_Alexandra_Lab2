﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinzaruc_Alexandra_Lab2
{
    class Doughnut
    {
        public enum DoughnutType
        {
            Glazed,
            Sugar,
            Lemon,
            Chocolate,
            Vanilla
        }

        private DoughnutType mFlavor;

        public DoughnutType Flavor
        {
            get
            {
                return mFlavor;
            }
            set
            {
                mFlavor = value;
            }
        }
        private float mPrice;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public Doughnut(DoughnutType aFlavor) 
        {
            mFlavor = aFlavor;
        }
    }
}
    

