
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : Idioma
    {
        public override string ObtenerListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public override string ObtenerHeader()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica formaGeometrica)
        {
            if (cantidad > 0)
                return $"{cantidad} {formaGeometrica.ObtenerNombre(this, (cantidad > 1))} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

            return string.Empty;
        }

        public override string ObtenerFooter(int cantidadformas, decimal totalPerimetros, decimal totalArea)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(cantidadformas + (cantidadformas > 1 ? " formas " : " forma "));
            sb.Append("Perimetro " + totalPerimetros.ToString("#.##") + " ");
            sb.Append("Area " + totalArea.ToString("#.##"));

            return sb.ToString();
        }

        public override string ObtenerNombreCuadrado(bool esPlural)
        {
            return esPlural ? "Cuadrados" : "Cuadrado";
        }

        public override string ObtenerNombreTriangulo(bool esPlural)
        {
            return esPlural ? "Triángulos" : "Triángulo";
        }

        public override string ObtenerNombreCirculo(bool esPlural)
        {
            return esPlural ? "Círculos" : "Círculo";
        }

        public override string ObtenerNombreTrapecio(bool esPlural)
        {
            return esPlural ? "Trapecios" : "Trapecio";
        }

        public override string ObtenerNombreRectangulo(bool esPlural)
        {
            return esPlural ? "Rectangulos" : "Rectangulo";
        }
    }
}