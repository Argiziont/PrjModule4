using MathSolver;
using MathSolver.Exceptions;
using MathSolver.Interfaces;
using System;

namespace PrjModule4
{
    class Program
    {
        static void Main()
        {
            #region Dot in console
            //Dot in console
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //
            #endregion

            while (true)
            {

                Menu(new MathIntegrator());

                Console.WriteLine("Press 'e' for exit or enter for continue");

                ConsoleKeyInfo exitState = Console.ReadKey();
                switch (exitState.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        continue;
                    case ConsoleKey.E:
                        return; ;
                    default:
                        return;

                }
            }
        }
        static void Menu(IIntegrator solver)
        {
            Console.Write($"\nWrite LowerLimit, HighLimit, Divider with a space: ");

            string stringData = Console.ReadLine();
            string[] stringDataSplit = stringData.Split(' ');

            double lowLim;
            try { lowLim = Convert.ToDouble(stringDataSplit[0]); } catch { ConsoleWithColor("\nWrong Low limit value\n", ConsoleColor.Red); return; }

            double highLim;
            try { highLim = Convert.ToDouble(stringDataSplit[1]); } catch { ConsoleWithColor("\nWrong High limit value\n", ConsoleColor.Red); return; }

            Console.Write($"\nWrite type of your data(integer|long|double|float): ");
            string numbersType = Console.ReadLine();
            dynamic divider;
            try
            {
                switch (numbersType)
                {
                    case "integer":
                        divider = Convert.ToInt32(stringDataSplit[2]);
                        break;
                    case "long":
                        divider = Convert.ToInt64(stringDataSplit[2]);
                        break;
                    case "double":
                        divider = Convert.ToDouble(stringDataSplit[2]);
                        break;
                    case "float":
                        divider = Convert.ToSingle(stringDataSplit[2]);
                        break;
                    default:
                        ConsoleWithColor("\nThis data type doesn't exist\n", ConsoleColor.Red);
                        return;
                }
            }
            catch { ConsoleWithColor("\nWrong divider value\n", ConsoleColor.Red); return; }

            Console.Write($"\nWrite function for integrate(Sin|Cos|Tan|Cotan): ");
            string funcType = Console.ReadLine();
            dynamic answer;
            try
            {
                switch (funcType)
                {
                    case "Sin":
                        answer = solver.SinIntegrate(lowLim, highLim, divider);
                        break;
                    case "Cos":
                        answer = solver.CosIntegrate(lowLim, highLim, divider);
                        break;
                    case "Tan":
                        answer = solver.TanIntegrate(lowLim, highLim, divider);
                        break;
                    case "Cotan":
                        answer = solver.CotanIntegrate(lowLim, highLim, divider);
                        break;
                    default:
                        ConsoleWithColor("\nThis function doesn't exist\n", ConsoleColor.Red);
                        return;

                }
            }
            catch(MathIntegratorException ex) { ConsoleWithColor($"\n{ex.Message}\n", ConsoleColor.Red); return; }

            Console.WriteLine($"Anser is: {answer}");
        }
        private static void ConsoleWithColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
