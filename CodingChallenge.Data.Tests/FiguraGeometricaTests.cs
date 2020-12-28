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
        public void TestObtenerNombreCirculoCastellano()
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

        #region Triangulo
        [TestCase]
        public void TestCalcularAreaTriangulo()
        {
            Assert.AreEqual(_trianguloEquilatero.CalcularArea(), 10.8253175473055m);
        }

        [TestCase]
        public void TestCalcularPerimetroTriangulo()
        {
            Assert.AreEqual(_trianguloEquilatero.CalcularPerimetro(), 15);
        }

        [TestCase]
        public void TestObtenerNombreTrianguloCastellano()
        {
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_castellano, false), "Triángulo");
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_castellano, true), "Triángulos");
        }

        [TestCase]
        public void TestObtenerNombreTrianguloIngles()
        {
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_ingles, false), "Triangle");
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_ingles, true), "Triangles");
        }

        [TestCase]
        public void TestObtenerNombreTrianguloItaliano()
        {
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_italiano, false), "Triangolo");
            Assert.AreEqual(_trianguloEquilatero.ObtenerNombre(_italiano, true), "Triangoli");
        }
        #endregion

        #region Trapecio
        [TestCase]
        public void TestCalcularAreaTrapecio()
        {
            Assert.AreEqual(_trapecio.CalcularArea(), 15m);
        }

        [TestCase]
        public void TestCalcularPerimetroTrapecio()
        {
            Assert.AreEqual(_trapecio.CalcularPerimetro(), 11m);
        }

        [TestCase]
        public void TestObtenerNombreTrapecioCastellano()
        {
            Assert.AreEqual(_trapecio.ObtenerNombre(_castellano, false), "Trapecio");
            Assert.AreEqual(_trapecio.ObtenerNombre(_castellano, true), "Trapecios");
        }

        [TestCase]
        public void TestObtenerNombreTrapecioIngles()
        {
            Assert.AreEqual(_trapecio.ObtenerNombre(_ingles, false), "Trapeze");
            Assert.AreEqual(_trapecio.ObtenerNombre(_ingles, true), "Trapezoids");
        }

        [TestCase]
        public void TestObtenerNombreTrapecioItaliano()
        {
            Assert.AreEqual(_trapecio.ObtenerNombre(_italiano, false), "Trapezio");
            Assert.AreEqual(_trapecio.ObtenerNombre(_italiano, true), "Trapezi");
        }
        #endregion

        #region Rectangulo
        [TestCase]
        public void TestCalcularAreaRectangulo()
        {
            Assert.AreEqual(_rectangulo.CalcularArea(), 18m);
        }

        [TestCase]
        public void TestCalcularPerimetroRectangulo()
        {
            Assert.AreEqual(_rectangulo.CalcularPerimetro(), 36m);
        }

        [TestCase]
        public void TestObtenerNombreTrapecioRectangulo()
        {
            Assert.AreEqual(_rectangulo.ObtenerNombre(_castellano, false), "Rectangulo");
            Assert.AreEqual(_rectangulo.ObtenerNombre(_castellano, true), "Rectangulos");
        }

        [TestCase]
        public void TestObtenerNombreRectanguloIngles()
        {
            Assert.AreEqual(_rectangulo.ObtenerNombre(_ingles, false), "Rectangle");
            Assert.AreEqual(_rectangulo.ObtenerNombre(_ingles, true), "Rectangles");
        }

        [TestCase]
        public void TestObtenerNombreRectanguloItaliano()
        {
            Assert.AreEqual(_rectangulo.ObtenerNombre(_italiano, false), "Rettangolo");
            Assert.AreEqual(_rectangulo.ObtenerNombre(_italiano, true), "Rettangoli");
        }
        #endregion
    }
}
