using MathSolver.Exceptions;
using MathSolver.Interfaces;
using System;

namespace MathSolver
{
    //Integrals using Sipmson(parabolic) Method
    public class MathIntegrator: IIntegrator
    {
        public double CosIntegrate(double lowLim, double highLim, double divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider==0)
                throw new MathIntegratorException("Couldn't divide by zero");
                

            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return S;
        }

        public float CosIntegrate(double lowLim, double highLim, float divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (float)S;
        }

        public int CosIntegrate(double lowLim, double highLim, int divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (int)S;
        }

        public long CosIntegrate(double lowLim, double highLim, long divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (long)S;
        }

        public double CotanIntegrate(double lowLim, double highLim, double divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return S;
        }

        public float CotanIntegrate(double lowLim, double highLim, float divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (float)S;
        }

        public int CotanIntegrate(double lowLim, double highLim, int divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (int)S;
        }

        public long CotanIntegrate(double lowLim, double highLim, long divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (long)S;
        }
       
        public double SinIntegrate(double lowLim, double highLim, double divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return S;
        }

        public float SinIntegrate(double lowLim, double highLim, float divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (float)S;
        }

        public int SinIntegrate(double lowLim, double highLim, int divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (int)S;
        }

        public long SinIntegrate(double lowLim, double highLim, long divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (long)S;
        }

        public double TanIntegrate(double lowLim, double highLim, double divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return S;
        }

        public float TanIntegrate(double lowLim, double highLim, float divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (float)S;
        }

        public int TanIntegrate(double lowLim, double highLim, int divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (int)S;
        }

        public long TanIntegrate(double lowLim, double highLim, long divider)
        {
            if (highLim < lowLim)
                throw new MathIntegratorException("UpperLimit could be less that lower");

            if (highLim == lowLim)
                throw new MathIntegratorException("Upper and lower limits couldn't be equal");

            if (divider == 0)
                throw new MathIntegratorException("Couldn't divide by zero");


            double S = 0, x, h;
            //[lowLim, highLim] divide into n parts
            h = (highLim - lowLim) / MathIntegratorFunctions.IntegrationPartsAproximation;
            x = lowLim + h;
            while (x < highLim)
            {
                S += 4 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
                //check if we're outside of  [lowLim, highLim)
                if (x >= highLim) break;
                S += 2 * MathIntegratorFunctions.MyCos(x, divider);
                x += h;
            }
            S = (h / 3) * (S + MathIntegratorFunctions.MyCos(lowLim, divider) + MathIntegratorFunctions.MyCos(highLim, divider));
            return (long)S;
        }
    }
}
