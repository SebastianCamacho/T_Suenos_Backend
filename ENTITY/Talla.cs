﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Talla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int idTalla { get; set; }
        public required string descripcion { get; set; }
        public required double medida { get; set; }

        public int idPedido { get; set; }
        //propiedad de navegacion
        [ForeignKey("idPedido")]
        public Pedido Pedido { get; set; }
    }
}