
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : Idioma
    {
        public override string ObtenerListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public override string ObtenerHeader()
        {
            return "<h1>Shapes report</h1>";
        }

        public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica formaGeometrica)
        {
            if (cantidad > 0)
                return $"{cantidad} {formaGeometrica.ObtenerNombre(this, (cantidad > 1))} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";

            return string.Empty;
        }

        public override string ObtenerFooter(int cantidadformas, decimal totalPerimetros, decimal totalArea)
        {
            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append(cantidadformas + (cantidadformas > 1 ? " shapes " : " shape ") );
            sb.Append("Perimeter " + totalPerimetros.ToString("#.##") + " ");
            sb.Append("Area " + totalArea.ToString("#.##"));

            return sb.ToString();
        }

        public override string ObtenerNombreCuadrado(bool esPlural)
        {
            return esPlural ? "Squares" : "Square";
        }

        public override string ObtenerNombreTriangulo(bool esPlural)
        {
            return esPlural ? "Triangles" : "Triangle";
        }

        public override string ObtenerNombreCirculo(bool esPlural)
        {
            return esPlural ? "Circles" : "Circle";
        }

        public override string ObtenerNombreTrapecio(bool esPlural)
        {
            return esPlural ? "Trapezoids" : "Trapeze";
        }

        public override string ObtenerNombreRectangulo(bool esPlural)
        {
            return esPlural ? "Rectangles" : "Rectangle";
        }
    }
}