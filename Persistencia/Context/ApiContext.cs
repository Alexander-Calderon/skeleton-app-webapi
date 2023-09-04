using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Context
{

    // El DbContext es una capa de abstracción que permitirá la interacción con la base de datos, lo que facilitará
    // la creación de un crud .
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        //Definir los nombres para las tablas en la bd
        DbSet<Pais> Paises { get; set; }
        DbSet<Departamento> Departamentos { get; set; }
        DbSet<Ciudad> Ciudades { get; set; }
        DbSet<TipoPersona> TipoPersonas { get; set; }
        DbSet<Ciudad> Personas { get; set; }
        DbSet<TrainerSalon> TrainerSalones { get; set; }
        DbSet<Salon> Salones { get; set; }
        DbSet<Matricula> Matriculas { get; set; }
        DbSet<Genero> Generos { get; set; }
        


    }
}