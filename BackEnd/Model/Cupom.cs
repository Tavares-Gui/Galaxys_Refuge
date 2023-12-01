﻿using System;
using System.Collections.Generic;

namespace Back.Model;

public partial class Cupom
{
    public int Id { get; set; }

    public string Codigo { get; set; }

    public double Desconto { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();
}
