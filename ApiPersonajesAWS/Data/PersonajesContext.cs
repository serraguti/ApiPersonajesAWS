using ApiPersonajesAWS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPersonajesAWS.Data
{
    public class PersonajesContext: DbContext
    {
        public PersonajesContext(DbContextOptions<PersonajesContext> options)
            :base(options) { }
        public DbSet<Personaje> Personajes { get; set; }
    }
}
