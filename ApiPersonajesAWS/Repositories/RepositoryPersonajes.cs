using ApiPersonajesAWS.Data;
using ApiPersonajesAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPersonajesAWS.Repositories
{
    public class RepositoryPersonajes
    {
        private PersonajesContext context;

        public RepositoryPersonajes(PersonajesContext context)
        {
            this.context = context;
        }

        public List<Personaje> GetPersonajes()
        {
            return this.context.Personajes.ToList();
        }

        public Personaje FindPersonaje(int id)
        {
            return this.context.Personajes.SingleOrDefault(x => x.IdPersonaje == id);
        }

        public void InsertPersonaje(int id, string nombre, string imagen)
        {
            Personaje p = new Personaje
            {
                IdPersonaje= id, Nombre = nombre, Imagen = imagen
            };
            this.context.Personajes.Add(p);
            this.context.SaveChanges();
        }
    }
}
