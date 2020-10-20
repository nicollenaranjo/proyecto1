using proyecto1.Semillas;
using System;
using System.Collections.Generic;
using proyecto1.Autenticadores;

namespace proyecto1.Terrenos
{
    public class Terreno
    {
        #region  Properties
        public int totalTerreno;
        public int estadoTerreno;
        public List<Semilla> listSemillas = new List<Semilla>();
        public Terreno planB;
        public bool validador;
        #endregion Properties

        #region  Initialize
        public Terreno()
        {
            Random rand = new Random(); 
            totalTerreno = rand.Next(50,100);
            estadoTerreno = 0;
            validador = false;
        }
        #endregion  Initialize

        #region  Methods
        public void cambioTerreno() //pasa del terreno 1 al plan b
        {
            if( validador == false && estadoTerreno == totalTerreno )
            {
                Autenticador a1 = null;
                validador = a1.autentica();
            }
            else
            {
                Console.WriteLine( "El terreno principal no se enucentra totalmente lleno o planB ya está en ejecución." );
            }
        } 
        #endregion  Methods

    }
}