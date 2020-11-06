using System;
using System.Collections.Generic;
using System.Text;

namespace MathSolver.Interfaces
{
    public interface IIntegrator
    {
        double CosIntegrate(double lowLim, double highLim, double val);
        float CosIntegrate(double lowLim, double highLim, float val);
        int CosIntegrate(double lowLim, double highLim, int val);
        long CosIntegrate(double lowLim, double highLim, long val);

        double SinIntegrate(double lowLim, double highLim, double val);
        float SinIntegrate(double lowLim, double highLim, float val);
        int SinIntegrate(double lowLim, double highLim, int val);
        long SinIntegrate(double lowLim, double highLim, long val);

        double TanIntegrate(double lowLim, double highLim, double val);
        float TanIntegrate(double lowLim, double highLim, float val);
        int TanIntegrate(double lowLim, double highLim, int val);
        long TanIntegrate(double lowLim, double highLim, long val);

        double CotanIntegrate(double lowLim, double highLim, double val);
        float CotanIntegrate(double lowLim, double highLim, float val);
        int CotanIntegrate(double lowLim, double highLim, int val);
        long CotanIntegrate(double lowLim, double highLim, long val);

    }
}
