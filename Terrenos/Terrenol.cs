using proyecto1.Semillas;
using System;
using System.Collections.Generic;
using proyecto1.Autenticadores;

namespace proyecto1.Terreno
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
        public void cambioTerreno() //para del terreno 1 al plan b
        {
            Autenticador a;
        } 
        #endregion  Methods

    }
}