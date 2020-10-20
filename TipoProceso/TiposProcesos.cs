using proyecto1.Semillas;
using proyecto1.Almacenes;
using proyecto1.Granjas;
using System.Linq;
using System.Collections.Generic;
using System;

namespace proyecto1.TipoProceso
{
    public class TipoProceso
    {
        #region Methods
        public void riego(Semilla s, Granja g)
        {
            //Cómo se manejaria el sistema de riego si lo tengo que utiliar hasta 3 veces por dia
            Semilla s1 = g.terrenoOfi.listSemillas.Find( s11 => s11.id == s.id ) as Semilla;
            Semilla s2 = g.terrenoOfi.planB.listSemillas.Find( s22 => s22.id == s.id ) as Semilla;
            if( s1 != null && s2 == null )
            {
                
            }
            else if( s2 != null && s1 == null )
            {

            }
            else
            {
                Console.WriteLine( "La semilla no se encuentra.");
            }
        }

        public void techo(Semilla s, Granja g)
        {
            Semilla s1 = g.terrenoOfi.listSemillas.Find( s11 => s11.id == s.id ) as Semilla;
            Semilla s2 = g.terrenoOfi.planB.listSemillas.Find( s22 => s22.id == s.id ) as Semilla;
            if( s1 != null && s2 == null )
            {
                if( s1.sombra == false )
                    s1.sombra = true;
                else
                    s1.sombra = false;
            }
            else if( s2 != null && s1 == null )
            {
                if( s2.sombra == false )
                    s2.sombra = true;
                else
                    s2.sombra = false;
            }
            else
            {
                Console.WriteLine( "La semilla no se encuentra en el terreno.");
            }
        }

        public void plantar(Semilla s, Granja g)
        {
            Semilla s1 = g.almacenOfi.semillasGuardas.Find( s11 => s11.id == s.id ) as Semilla;
            Semilla s2 = g.almacenOfi.semillasGuardas.Find( s22 => s22.id == s.id ) as Semilla;
            if( s1 != null && s2 == null )
            {
                if( g.terrenoOfi.validador == false )
                {
                    g.terrenoOfi.listSemillas.Add(s1);
                    g.terrenoOfi.estadoTerreno++;
                    g.almacenOfi.semillasGuardas.Remove(s1);
                }
                else
                {
                    g.terrenoOfi.planB.listSemillas.Add(s1);
                    g.terrenoOfi.planB.estadoTerreno++;
                    g.almacenOfi.semillasGuardas.Remove(s1);
                }
            }
            else if( s2 != null && s1 == null )
            {
                if( g.terrenoOfi.validador == false )
                {
                    g.terrenoOfi.listSemillas.Add(s2);
                    g.terrenoOfi.estadoTerreno++;
                    g.almacenOfi.semillasGuardas.Remove(s2);
                }
                else
                {
                    g.terrenoOfi.planB.listSemillas.Add(s2);
                    g.terrenoOfi.planB.estadoTerreno++;
                    g.almacenOfi.semillasGuardas.Remove(s2);
                }
            }
            else
            {
                Console.WriteLine( "La semilla no se encuentra en el almacen.");
            }
        }

        public void alarma(Semilla s)
        {
            
        }

        #endregion Methods
    }

}