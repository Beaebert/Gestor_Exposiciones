using System;
using System.Collections.Generic;
using System.Text;
using BE.Interfaces; //para que tenga en cuenta esa carpeta

namespace BE.Entidades
{
        public class Artista : IParticipante
        {
            #region Atributos Controlados
            public int Id { get; private set; }
            public string Nombre { get; set; }
            public string Bio { get; set; }
            public string Nacionalidad { get; set; }

            public List<Obra> Obras { get; } 
            #endregion

            public Artista(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
                Obras = new List<Obra>();
            }

            public string ObtenerNombre() => Nombre;

            public string ObtenerInfo() => $"{Nombre} - {Nacionalidad} - {Bio}";

            public void VincularObra(Obra obra)
            {
                if (obra != null && !Obras.Contains(obra))
                {
                    Obras.Add(obra);
                }
            }
        }
    }
