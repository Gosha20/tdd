﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization
{
    class ArchimedesSpiralPointGenerator : IEnumerable<Point>
    {
        private double spiralAngle { get; set; }
        private Point center { get; set; }
        private double angleStep { get; set; }

        public ArchimedesSpiralPointGenerator(Point center, double angleStep = 0.1, double spiralAngle = 0.0 )
        {
            this.spiralAngle = spiralAngle;
            this.center = center;
            this.angleStep = angleStep;
        }

        public IEnumerator<Point> GetEnumerator()
        {
            var currentAngle = spiralAngle;
            while (true)
            {
                yield return
                      new Point(center.X + (int)(currentAngle * Math.Cos(currentAngle)),
                          center.Y + (int)(currentAngle * Math.Sin(currentAngle)));
                currentAngle += angleStep;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
