﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseDeDatos.Models
{
    public partial class horarios_popularesResult
    {
        public int? Dia { get; set; }
        public TimeOnly? hora_inicio { get; set; }
        public int? Compras { get; set; }
        [Column("Ganancias", TypeName = "decimal(38,6)")]
        public decimal? Ganancias { get; set; }
    }
}
