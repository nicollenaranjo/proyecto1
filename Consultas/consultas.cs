using proyecto1.Semillas;
using System;
using proyecto1.Granjas;
using System.Linq;

namespace proyecto1.Consultas
{
    public class Consulta
    {
        #region Methods
        public void consultar(Semilla s, Granja g)
        {
            try
            {
                Semilla s1 = g.almacenOfi.semillasGuardas.First( s2 => s2.id == s.id ) as Semilla;    
                Console.WriteLine("El tipo de semilla es:", s.tipo);
                Console.WriteLine("La cantidad de agua que necesita es:", s.cantAgua);
                Console.WriteLine("La semilla en este momento se encuentra recibiendo:", s.sombra);
                s.size+=5;
                Console.WriteLine("Su tamaña actual es: ", s.size);   
            }
            catch( ArgumentNullException ex )
            {
                Console.WriteLine("La semilla ingresada no se encontró.");
            }
        }
        #endregion Methods

    }
}