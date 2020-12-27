using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Altura { get; set; }
        public decimal LadoDos { get; set; }

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoDos, decimal lado) : base(lado)
        {
            this.BaseMayor = baseMayor;
            this.BaseMenor = baseMenor;
            this.Altura = altura;
            this.LadoDos = ladoDos;
        }

        public override decimal CalcularArea()
        {
            return (this.BaseMayor + this.BaseMenor) * this.Altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return this.BaseMayor + this.BaseMenor + this.LadoDos + this.Lado;
        }

        public override string ObtenerNombre(Idioma idioma, bool esPlural)
        {
            return idioma.ObtenerTrapecio(esPlural);
        }
    }
}
