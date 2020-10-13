using proyecto1.Semillas;
using System;

namespace proyecto1.Consultas
{
    public class Consulta
    {
        #region Methods
        public void consultar(Semilla s)
        {
            Console.WriteLine("El tipo de semilla es:", s.tipo);
            Console.WriteLine("La cantidad de agua que necesita es:", s.cantAgua);
            Console.WriteLine("La semilla en este momento se encuentra recibiendo:", s.sombra);
            s.size+=5;
            Console.WriteLine("Su tamaña actual es: ", s.size);
        }
        #endregion Methods

    }
}