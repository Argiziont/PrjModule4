using System;

namespace MathSolver
{
    public static class MathIntegratorFunctions
    {
        public static int IntegrationPartsAproximation = 100000;
        public static double MySin(double x, double flow)
        {
            return Math.Sin(x / flow);
        }
        public static double MyCos(double x, double flow)
        {
            return Math.Cos(x / flow);
        }
        public static double MyTan(double x, double flow)
        {
            return Math.Tan(x / flow);
        }
        public static double MyCotan(double x, double flow)
        {
            return 1 / Math.Tan(x / flow);
        }
    }
}
