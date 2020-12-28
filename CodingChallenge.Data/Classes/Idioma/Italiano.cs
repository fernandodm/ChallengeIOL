
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Italiano : Idioma
    {
        public override string ObtenerListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }

        public override string ObtenerHeader()
        {
            return "<h1>Rapporto di forme</h1>";
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
            sb.Append("TOTALE:<br/>");
            sb.Append(cantidadformas + (cantidadformas > 1 ? " formes " : " forma ") );
            sb.Append("Perimetro " + totalPerimetros.ToString("#.##") + " ");
            sb.Append("Area " + totalArea.ToString("#.##"));

            return sb.ToString();
        }

        public override string ObtenerNombreCuadrado(bool esPlural)
        {
            return esPlural ? "Piazze" : "Piazza";
        }

        public override string ObtenerNombreTriangulo(bool esPlural)
        {
            return esPlural ? "Triangoli" : "Triangolo";
        }

        public override string ObtenerNombreCirculo(bool esPlural)
        {
            return esPlural ? "Cerchi" : "Cerchio";
        }

        public override string ObtenerNombreTrapecio(bool esPlural)
        {
            return esPlural ? "Trapezi" : "Trapezio";
        }

        public override string ObtenerNombreRectangulo(bool esPlural)
        {
            return esPlural ? "Rettangoli" : "Rettangolo";
        }
    }
}