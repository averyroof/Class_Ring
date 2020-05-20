using System;

namespace Ring
{
    public class Ring: Round
    {
        public int Radius2 { get; } // внешний радиус кольца
        
        public Ring(int x, int y, int radius, int radius2) : base(x, y, radius)
        {
            if (radius2 < 1)
                throw new ArgumentException("Радиус отрицателен");
            if (radius2 < radius)
                throw new ArgumentException("Внутренний радиус не может быть больше внешнего радиуса");
            Radius2 = radius2;
        }
        
        public double Length2 => 2 * Math.PI * Radius2;
        
        public double Total_Length => Length + Length2;
        
        public double Square => Math.PI * (Radius2 * Radius2 - Radius * Radius);
        
        public override string ToString()
        {
            return "Кольцо с центром в точке: (" + X + ", " + Y +  "); внутренним радиусом: " + 
                   Radius + "; внешним радиусом: " + Radius2 + "; суммарной длиной: " + Total_Length + " и площадью: " + Square ;
        }
    }
}