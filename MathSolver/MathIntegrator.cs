using MathSolver.Exceptions;
using MathSolver.Interfaces;
using System;

namespace MathSolver
{
    //Integrals using Sipmson(parabolic) Method
    public class MathIntegrator: IIntegrator
    {
        /// <summary>
        /// Integrates cos(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cos(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cos(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cos(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cotan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cotan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cotan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates cotan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates sin(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates sin(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates sin(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates sin(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates tan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates tan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates tan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
        /// <summary>
        /// Integrates tan(x) function
        /// </summary>
        /// <param name="lowLim">Lower limit of integral</param>
        /// <param name="highLim">Higher limit of integral</param>
        /// <param name="divider">Divider for x value</param>
        /// <returns>Integration result</returns>
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
