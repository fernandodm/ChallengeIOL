using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ImpresoraTests
    {
        private Impresora _impresoraEnItaliano;
        private Impresora _impresoraEnIngles;
        private Impresora _impresoraEnCastellano;

        [SetUp]
        public void SetUp()
        {
            var castellano = new Castellano();
            var ingles = new Ingles();
            var italiano = new Italiano();

            _impresoraEnCastellano = new Impresora(castellano);
            _impresoraEnIngles = new Impresora(ingles);
            _impresoraEnItaliano = new Impresora(italiano);
        }

        [TestCase]
        public void TestResumenListaVaciaCastellano()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                _impresoraEnCastellano.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                _impresoraEnIngles.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaitaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                _impresoraEnItaliano.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoCastellano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5)};

            var resumen = _impresoraEnCastellano.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _impresoraEnItaliano.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Rapporto di forme</h1>1 Piazza | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = _impresoraEnIngles.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new Rectangulo(3,2),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(3,2,4,5,5),
                new Rectangulo(5,2)
            };

            var resumen = _impresoraEnIngles.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>2 Rectangles | Area 16 | Perimeter 32 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapeze | Area 10 | Perimeter 15 <br/>TOTAL:<br/>10 shapes Perimeter 144,66 Area 117,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(3,2,4,5,5)
            };

            var resumen = _impresoraEnCastellano.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Trapecio | Area 10 | Perimetro 15 <br/>TOTAL:<br/>8 formas Perimetro 112,66 Area 101,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(3,2,4,5,5),
                new Trapecio(3,2,4,5,5)
            };

            var resumen = _impresoraEnItaliano.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>2 Piazze | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>2 Trapezi | Area 20 | Perimetro 30 <br/>TOTALE:<br/>9 formes Perimetro 127,66 Area 111,65",
                resumen);
        }
    }
}
