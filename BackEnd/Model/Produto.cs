using System;
using System.Collections.Generic;

namespace Back.Model;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public double Preco { get; set; }

    public string Descricao { get; set; }

    public int? ImagemId { get; set; }

    public virtual Imagem Imagem { get; set; }

    public virtual ICollection<Post> Posts { get; } = new List<Post>();

    public virtual ICollection<ProdutosPedido> ProdutosPedidos { get; } = new List<ProdutosPedido>();
}
