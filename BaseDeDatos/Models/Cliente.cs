﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BaseDeDatos.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Email { get; set; }

    public string Telefono { get; set; }

    public string NroDocumento { get; set; }

    public int? TipoDocumento { get; set; }

    public virtual TiposDocumento TipoDocumentoNavigation { get; set; }

    public virtual ICollection<Transaccione> Transacciones { get; set; } = new List<Transaccione>();
}