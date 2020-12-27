﻿/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public decimal Lado { get; set; }

        public FormaGeometrica(decimal lado)
        {
            this.Lado = lado;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();

        public abstract string ObtenerNombre(Idioma idioma, bool esPlural);
    }
}
