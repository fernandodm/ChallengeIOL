using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado) { }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * this.Lado * this.Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return this.Lado * 3;
        }

        public override string ObtenerNombre(Idioma idioma, bool esPlural)
        {
            return idioma.ObtenerNombreTriangulo(esPlural);
        }
    }
}
