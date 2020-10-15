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

        #region Initialize 
        public Almacen()
        {
            semillasGuardas = generarSemillas();
        }
        #endregion Initialize

        #region  Methods
        public List<Semilla> generarSemillas()
        {
            Random rand = new Random(); 
            int a = rand.Next(1,10);
            List<Semilla> semillas = new List<Semilla>();
            for( int i = 0; i < a; i++ )
            {
                semillas.Add(new Semilla()
                {
                    id = rand.Next(100,500),
                    tipo = "Girasol",
                    cantAgua = 350,
                    sombra = false,
                    size = 0
                });
            }

            a = rand.Next(1,10);
            for( int i = 0; i < a; i++ )
            {
                semillas.Add(new Semilla()
                {
                    id = rand.Next(100,500),
                    tipo = "Sandia",
                    cantAgua = 35,
                    sombra = false,
                    size = 0
                });
            }
            a = rand.Next(1,10);
            for( int i = 0; i < a; i++ )
            {
                semillas.Add(new Semilla()
                {
                    id = rand.Next(100,500),
                    tipo = "Frijol",
                    cantAgua = 3,
                    sombra = false,
                    size = 0
                });
            }
            a = rand.Next(1,10);
            for( int i = 0; i < a; i++ )
            {
                semillas.Add(new Semilla()
                {
                    id = rand.Next(100,500),
                    tipo = "Brocoli",
                    cantAgua = 100,
                    sombra = false,
                    size = 0
                });
            }
            return semillas;
        }

        #endregion Methods
    }

}