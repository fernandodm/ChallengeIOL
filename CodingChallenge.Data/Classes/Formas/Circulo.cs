using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado) : base(lado) { }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (this.Lado / 2) * (this.Lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this.Lado;
        }

        public override string ObtenerNombre(Idioma idioma, bool esPlural)
        {
            return idioma.ObtenerCirculo(esPlural);
        }
    }
}
