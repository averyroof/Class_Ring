using System;

namespace Ring
{
    public class Round
    {
        public int X { get; }
        public int Y { get; }
        public int Radius { get; }

        public Round(int x, int y, int radius)
        {
            X = x;
            Y = y;
            if (radius < 1)
                throw new ArgumentException("Радиус отрицателен");
            Radius = radius;
        }

        public double Length => 2 * Math.PI * Radius;
        
        public double Square => Math.PI * Radius * Radius;
        
        public override string ToString()
        {
            return "Круг с центром в точке: (" + X + ", " + Y +  "); радиусом: " + 
                   Radius + "; длиной: " + Length + " и площадью: " + Square ;
        }
    }
}