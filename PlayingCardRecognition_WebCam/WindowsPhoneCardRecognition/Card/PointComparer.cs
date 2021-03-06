﻿using AForge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPhoneCardRecognition
{
    public class PointComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            return p2.Y.CompareTo(p1.Y);
        }
    }
}
