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
                Semilla s2 = g.terrenoOfi.listSemillas.First( s3 => s3.id == s.id ) as Semilla;   
                Semilla s3 = g.terrenoOfi.listSemillas.First( s4 => s4.id == s.id ) as Semilla;    
                Console.WriteLine("El tipo de semilla es:", s.tipo);
                Console.WriteLine("La cantidad de agua que necesita es:", s.cantAgua);
                Console.WriteLine("La semilla en este momento se encuentra recibiendo:", s.sombra);
                Console.WriteLine("Su tamaño actual es: ", s.size);  
                if( s1 != null )
                {
                    Console.WriteLine("Se encuentra en el Almacen" );  
                }
                if( s2 != null )
                {
                    Console.WriteLine("Se encuentra en el Terreno" );  
                }
                if( s3 != null )
                {
                    Console.WriteLine("Se encuentra en el planB" );  
                }
            }
            catch( ArgumentNullException ex )
            {
                throw ex;
            }
        }
        #endregion Methods
    }
}