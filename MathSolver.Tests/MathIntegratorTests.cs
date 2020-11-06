using MathSolver.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MathSolver.Tests
{
    public class MathIntegratorTests
    {
        public MathIntegratorTests()
        {
            //Dot in console
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            //
        }

        #region snippet_CosIntegrate_ReturnsDouble_InputIsCorrect
        [Fact]
        public void CosIntegrate_ReturnsDouble_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorException_DividerIsZero
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorException_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ReturnsFloat_InputIsCorrect
        [Fact]
        public void CosIntegrate_ReturnsFloat_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<float>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ReturnsInt_InputIsCorrect
        [Fact]
        public void CosIntegrate_ReturnsInt_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<int>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ReturnsLong_InputIsCorrect
        [Fact]
        public void CosIntegrate_ReturnsLong_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit
        [Fact]
        public void CosIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CosIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion

        #region snippet_SinIntegrate_ReturnsDouble_InputIsCorrect
        [Fact]
        public void SinIntegrate_ReturnsDouble_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorException_DividerIsZero
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorException_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ReturnsFloat_InputIsCorrect
        [Fact]
        public void SinIntegrate_ReturnsFloat_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<float>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ReturnsInt_InputIsCorrect
        [Fact]
        public void SinIntegrate_ReturnsInt_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<int>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ReturnsLong_InputIsCorrect
        [Fact]
        public void SinIntegrate_ReturnsLong_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit
        [Fact]
        public void SinIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.SinIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion

        #region snippet_TanIntegrate_ReturnsDouble_InputIsCorrect
        [Fact]
        public void TanIntegrate_ReturnsDouble_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorException_DividerIsZero
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorException_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ReturnsFloat_InputIsCorrect
        [Fact]
        public void TanIntegrate_ReturnsFloat_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<float>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ReturnsInt_InputIsCorrect
        [Fact]
        public void TanIntegrate_ReturnsInt_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<int>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ReturnsLong_InputIsCorrect
        [Fact]
        public void TanIntegrate_ReturnsLong_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit
        [Fact]
        public void TanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.TanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion

        #region snippet_CotanIntegrate_ReturnsDouble_InputIsCorrect
        [Fact]
        public void CotanIntegrate_ReturnsDouble_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<double>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorException_DividerIsZero
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            double divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorException_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsDouble_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            double divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ReturnsFloat_InputIsCorrect
        [Fact]
        public void CotanIntegrate_ReturnsFloat_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<float>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            float divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsFloat_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            float divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ReturnsInt_InputIsCorrect
        [Fact]
        public void CotanIntegrate_ReturnsInt_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<int>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            int divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsInt_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            int divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ReturnsLong_InputIsCorrect
        [Fact]
        public void CotanIntegrate_ReturnsLong_InputIsCorrect()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 3;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            var result = integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.IsType<long>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_DividerIsZero()
        {
            // Arrange
            double upperLim = 0;
            double lowerLim = 5;
            long divider = 0;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitGreaterThanHigherLimit()
        {
            // Arrange
            double upperLim = 10;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
        #region snippet_CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit
        [Fact]
        public void CotanIntegrate_ThrowsMathIntegratorExceptionInstedOfReturnsLong_LowerLimitEqualsHigherLimit()
        {
            // Arrange
            double upperLim = 5;
            double lowerLim = 5;
            long divider = 5;
            MathIntegrator integrator = new MathIntegrator();

            // Act
            void result() => integrator.CotanIntegrate(upperLim, lowerLim, divider);

            // Assert
            Assert.Throws<MathIntegratorException>(result);
        }
        #endregion
    }
}
