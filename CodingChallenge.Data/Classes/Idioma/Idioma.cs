using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract string ObtenerListaVacia();
        public abstract string ObtenerHeader();
        public abstract string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica formaGeometrica);
        public abstract string ObtenerFooter(int cantidadformas, decimal totalPerimetros, decimal totalArea);
        public abstract string ObtenerNombreCuadrado(bool esPlural);
        public abstract string ObtenerNombreTriangulo(bool esPlural);
        public abstract string ObtenerNombreCirculo(bool esPlural);
        public abstract string ObtenerNombreTrapecio(bool esPlural);
        public abstract string ObtenerNombreRectangulo(bool esPlural);
    }
}
