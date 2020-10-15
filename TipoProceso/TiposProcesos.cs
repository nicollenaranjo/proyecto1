using proyecto1.Semillas;
using proyecto1.Almacenes;
using proyecto1.Granjas;
using System.Linq;
using System.Collections.Generic;

namespace proyecto1.TipoProceso
{
    public class TipoProceso
    {
        #region Methods
        public void riego(Semilla s, Granja g)
        {
            Semilla s1 = g.almacenOfi.semillasGuardas.First( s2 => s2.id == s.id ) as Semilla;
        }

        public void techo(Semilla s)
        {

        }

        public void plantar(Semilla s)
        {

        }

        public void alarma(Semilla s)
        {

        }
        #endregion Methods
    }

}