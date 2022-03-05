using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tarea6Detalle.Entidades
{
    public class ProductosDetalles
    {
        [Key] public int Id { get; set; }
        public int ProductoId { get; set; }
        public string? Descripcion {get; set;}
        public string? Presentacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal ExistenciaEmpaque {get; set;}
    }

    
}