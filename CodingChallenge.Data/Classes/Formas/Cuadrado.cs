using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica 
    {
        public Cuadrado(decimal lado) : base(lado) { }

        public override decimal CalcularArea()
        {
            return this.Lado * this.Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return this.Lado * 4;
        }

        public override string ObtenerNombre(Idioma idioma, bool esPlural)
        {
            return idioma.ObtenerCuadrado(esPlural);
        }
    }
}
