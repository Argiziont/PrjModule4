using System;
using System.Collections.Generic;
using System.Text;

namespace MathSolver.Interfaces
{
    public interface IIntegrator
    {

        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        double CosIntegrate(double lowLim, double highLim, double val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        float CosIntegrate(double lowLim, double highLim, float val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        int CosIntegrate(double lowLim, double highLim, int val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        long CosIntegrate(double lowLim, double highLim, long val);

        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        double SinIntegrate(double lowLim, double highLim, double val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        float SinIntegrate(double lowLim, double highLim, float val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        int SinIntegrate(double lowLim, double highLim, int val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        long SinIntegrate(double lowLim, double highLim, long val);

        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        double TanIntegrate(double lowLim, double highLim, double val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        float TanIntegrate(double lowLim, double highLim, float val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        int TanIntegrate(double lowLim, double highLim, int val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        long TanIntegrate(double lowLim, double highLim, long val);

        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        double CotanIntegrate(double lowLim, double highLim, double val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        float CotanIntegrate(double lowLim, double highLim, float val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        int CotanIntegrate(double lowLim, double highLim, int val);
        /// <summary>
        /// <exception cref="MathIntegratorException">Thrown when one of arguments is wrong</exception>
        /// </summary>
        long CotanIntegrate(double lowLim, double highLim, long val);

    }
}
