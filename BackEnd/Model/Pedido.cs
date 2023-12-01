using System;
using System.Collections.Generic;

namespace Back.Model;

public partial class Pedido
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int CuponsID { get; set; }

    public string Cupom { get; set; }

    public double Valor { get; set; }

    public DateTime HoraPedido { get; set; }

    public bool ValCupom { get; set; }

    public virtual Cupom CuponsNavigation { get; set; }

    public virtual ICollection<PedidoProduto> PedidoProdutos { get; } = new List<PedidoProduto>();

    public virtual Usuario Usuario { get; set; }
}
