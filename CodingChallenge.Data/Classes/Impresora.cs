using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Impresora
    {
        public Idioma Idioma { get; set; }

        public Impresora(Idioma idioma)
        {
            this.Idioma = idioma;
        }

        public string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                sb.Append(this.Idioma.ObtenerListaVacia());
            else
            {
                sb.Append(this.Idioma.ObtenerHeader());

                var almacenamiento = new Dictionary<string, Almacenamiento>();

                foreach(FormaGeometrica forma in formas)
                {
                    var nombreForma = forma.ObtenerNombre(this.Idioma, false);
                    if (!almacenamiento.ContainsKey(nombreForma))
                        almacenamiento.Add(nombreForma, new Almacenamiento());

                    var almacenamientoSegunforma = almacenamiento[nombreForma];
                    almacenamientoSegunforma.Cantidad++;
                    almacenamientoSegunforma.AreaTotal += forma.CalcularArea();
                    almacenamientoSegunforma.PerimetroTotal += forma.CalcularPerimetro();
                    almacenamientoSegunforma.UltimaFormaEncontrada = forma;
                }

                var cantidadFormas = 0;
                var totalPerimetro = 0m;
                var totalArea = 0m;

                foreach (string clave in almacenamiento.Keys)
                {
                    var almacenamientoSegunforma = almacenamiento[clave];
                    sb.Append(
                            this.Idioma.ObtenerLinea(
                                    almacenamientoSegunforma.Cantidad, 
                                    almacenamientoSegunforma.AreaTotal, 
                                    almacenamientoSegunforma.PerimetroTotal, 
                                    almacenamientoSegunforma.UltimaFormaEncontrada));

                    cantidadFormas += almacenamientoSegunforma.Cantidad;
                    totalPerimetro += almacenamientoSegunforma.PerimetroTotal;
                    totalArea += almacenamientoSegunforma.AreaTotal;
                }

                // FOOTER
                sb.Append(this.Idioma.ObtenerFooter(cantidadFormas, totalPerimetro, totalArea));
            }

            return sb.ToString();
        }
    }
}