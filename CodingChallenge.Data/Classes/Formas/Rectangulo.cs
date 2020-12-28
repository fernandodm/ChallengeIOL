using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal Base { get; set; }

        public Rectangulo(decimal baseDelRectangulo, decimal lado) : base(lado)
        {
            this.Base = baseDelRectangulo;
        }

        public override decimal CalcularArea()
        {
            return this.Base * this.Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return (this.Base * this.Lado) * 2;
        }

        public override string ObtenerNombre(Idioma idioma, bool esPlural)
        {
            return idioma.ObtenerNombreRectangulo(esPlural);
        }
    }
}
