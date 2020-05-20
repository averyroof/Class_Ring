using System;
using System.IO;

namespace Ring
{
    public class RingProvider
    {
        private Ring _ring;

        public RingProvider(Ring ring)
        {
            _ring = ring;
        }
        
        public static Ring LoadFromFile()
        {
            using StreamReader sr = new StreamReader("input.txt");
            string[] mas = sr.ReadLine()?.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (mas != null && mas.Length == 4)
            {
                if (!int.TryParse(mas[0], out var x))
                {
                    throw new ArgumentException($@"Неккоректно введена кордината x: {mas[0]}");
                }

                if (!int.TryParse(mas[1], out var y))
                {
                    throw new ArgumentException($@"Неккоректно введена кордината y: {mas[1]}");
                }

                if (!int.TryParse(mas[2], out var r))
                {
                    throw new ArgumentException($@"Неккоректно введен внутренний радиус: {mas[2]}");

                }
                
                if (!int.TryParse(mas[3], out var r2))
                {
                    throw new ArgumentException($@"Неккоректно введен внешний радиус: {mas[3]}");

                }
                Ring ring = new Ring(x, y, r, r2);
                return ring;
            }

            return null;
        }

        public void SaveToFile()
        {
            using StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(_ring.ToString());
        }
    }
}