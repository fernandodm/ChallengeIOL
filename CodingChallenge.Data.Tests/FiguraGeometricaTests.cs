using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class FiguraGeometricaTests
    {
        private Cuadrado _cuadrado;
        private TrianguloEquilatero _trianguloEquilatero;
        private Circulo _circulo;
        private Trapecio _trapecio;
        private Rectangulo _rectangulo;

        private Idioma _ingles;
        private Idioma _castellano;
        private Idioma _italiano;

        [SetUp]
        public void SetUp()
        {
            _cuadrado = new Cuadrado(3);
            _trianguloEquilatero = new TrianguloEquilatero(5);
            _circulo = new Circulo(8);
            _trapecio = new Trapecio(2, 4, 5, 2, 3);
            _rectangulo = new Rectangulo(6,3);

            _ingles = new Ingles();
            _castellano = new Castellano();
            _italiano = new Italiano();
        }

        #region Cuadrado
        [TestCase]
        public void TestCalcularAreaCuadrado()
        {
            Assert.AreEqual(_cuadrado.CalcularArea(), 9);
        }

        [TestCase]
        public void TestCalcularPerimetroCuadrado()
        {
            Assert.AreEqual(_cuadrado.CalcularPerimetro(), 12);
        }

        [TestCase]
        public void TestObtenerNombreCuadradoCastellano()
        {
            Assert.AreEqual(_cuadrado.ObtenerNombre(_castellano, false), "Cuadrado");
            Assert.AreEqual(_cuadrado.ObtenerNombre(_castellano, true), "Cuadrados");
        }

        [TestCase]
        public void TestObtenerNombreCuadradoIngles()
        {
            Assert.AreEqual(_cuadrado.ObtenerNombre(_ingles, false), "Square");
            Assert.AreEqual(_cuadrado.ObtenerNombre(_ingles, true), "Squares");
        }

        [TestCase]
        public void TestObtenerNombreCuadradoItaliano()
        {
            Assert.AreEqual(_cuadrado.ObtenerNombre(_italiano, false), "Piazza");
            Assert.AreEqual(_cuadrado.ObtenerNombre(_italiano, true), "Piazze");
        }
        #endregion

        #region Circulo
        [TestCase]
        public void TestCalcularAreaCirculo()
        {
            Assert.AreEqual(_circulo.CalcularArea(), 50.26548245743664m);
        }

        [TestCase]
        public void TestCalcularPerimetroCirculo()
        {
            Assert.AreEqual(_circulo.CalcularPerimetro(), 25.13274122871832m);
        }

        [TestCase]
        public void TestObtenerNombreCirculo()
        {
            Assert.AreEqual(_circulo.ObtenerNombre(_castellano, false), "Círculo");
            Assert.AreEqual(_circulo.ObtenerNombre(_castellano, true), "Círculos");
        }

        [TestCase]
        public void TestObtenerNombreCirculoIngles()
        {
            Assert.AreEqual(_circulo.ObtenerNombre(_ingles, false), "Circle");
            Assert.AreEqual(_circulo.ObtenerNombre(_ingles, true), "Circles");
        }

        [TestCase]
        public void TestObtenerNombreCirculoItaliano()
        {
            Assert.AreEqual(_circulo.ObtenerNombre(_italiano, false), "Cerchio");
            Assert.AreEqual(_circulo.ObtenerNombre(_italiano, true), "Cerchi");
        }
        #endregion
    }
}
