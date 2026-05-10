using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Entidades
{
    public abstract class Obra
    {
        #region Propiedades Protegidas
        public int Id { get; private set; } //recordar que private para que no sea modificable desde afuera
        public string Titulo { get; set; }
        public int Anio { get; set; }
        public string Tecnica { get; set; }
        #endregion
        protected Obra(int id) //para que las obras tenga ID
        {
            Id = id;
        }

        public abstract string ObtenerInfo();
    }
}
