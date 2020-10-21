using proyecto1.Semillas;
using System.Collections.Generic;
using System;

namespace proyecto1.Almacenes
{
    public class Almacen
    {
        #region Properties
        public List<Semilla> semillasGuardas = new List<Semilla>();
        #endregion Properties

        #region  Methods
        public void generarSemillas( string t )
        {
            Random rand = new Random(); 
            int a = rand.Next(1,10);
            for( int i = 0; i < a; i++ )
            {
                semillasGuardas.Add(new Semilla()
                {
                    id = rand.Next(100,500),
                    tipo = t,
                    cantAgua = 0,
                    sombra = false,
                    size = 0
                });
            }
        }
        #endregion Methods
    }

}