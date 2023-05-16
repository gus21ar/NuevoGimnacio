﻿using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class MediosDePago
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
