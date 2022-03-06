using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea6Detalle.Entidades;

namespace Tarea6Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos {get; set;}
         public DbSet<ProductosDetalles> ProductosDetalles {get; set;}
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}