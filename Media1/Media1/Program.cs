using System;
using System.Globalization;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 3.5) + (B * 7.5)) / 11; // nota A com peso 3.5 e nota b com peso 7.5

            Console.WriteLine("Media = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
