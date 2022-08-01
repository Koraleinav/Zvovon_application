using System;

namespace Services
{
    public class Service
    {
        public static string calc(double h, double angle, double v0)
        {
            // convert to radian
            angle = angle * (Math.PI / 180);

            var time = calaTime(h, angle, v0);
            return "The Hit's location: " + calcHit(time, v0, angle) + " m " + ", The speed is " + calcSpeed(v0, angle, h) + " m/h" + " and the hit's degree is " + calcDeg(v0, angle, h);
        }

        private static double calaTime(double h, double angle, double v0)
        {
            return ((v0 * Math.Sin(angle)) + Math.Sqrt(Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2) + (20 * h))) / 10;
        }

        private static double calcHit(double time, double v0, double angle)
        {
            return v0 * Math.Cos(angle) * time;
        }

        private static double calcSpeed(double v0, double angle, double h)
        {
            return Math.Sqrt(Math.Pow(v0, 2) * Math.Pow(Math.Cos(angle), 2) + Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2) + 20 * h);
        }

        private static double calcDeg(double v0, double angle, double h)
        {
            var D = Math.Atan(Math.Sqrt(Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2) + 20 * h) / (v0 * Math.Cos(angle)));
            return ConvertRadiansToDegrees(D);
        }

        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return (degrees);
        }

    }
}
