﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Marimo.RedRing.Model
{
    public class ベクトル : ObservableObject
    {
        public ベクトル(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        private double x = 0;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                Set(ref x, value);
            }
        }
        private double y = 0;
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                Set(ref y, value);
            }
        }
        private double z = 0;
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                Set(ref z, value);
            }
        }

        public static ベクトル operator+(ベクトル l, ベクトル r)
        {
            return new ベクトル(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
    }
}
