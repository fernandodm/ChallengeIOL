using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract string ObtenerListaVacia();
        public abstract string ObtenerHeader();
        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica formaGeometrica);
        public abstract string ObtenerFooter(int cantidadformas, decimal totalPerimetros, decimal totalArea);
        public abstract string ObtenerCuadrado(bool esPlural);
        public abstract string ObtenerTriangulo(bool esPlural);
        public abstract string ObtenerCirculo(bool esPlural);
        public abstract string ObtenerTrapecio(bool esPlural);
        public abstract string ObtenerRectangulo(bool esPlural);
    }
}
