using System;
using System.Collections.Generic;

namespace Back.Model;

public partial class PedidoProduto
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int PedidoId { get; set; }

    public int QtdProduto { get; set; }

    public virtual Pedido Pedido { get; set; }

    public virtual Usuario Usuario { get; set; }
}
