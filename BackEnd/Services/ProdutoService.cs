using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DTO;
using Back.Model;
using System;

namespace Back.Services;

public class ProdutoService : IProdutoService
{
    GalaxysRefugeDbContext ctx;
    public ProdutoService(GalaxysRefugeDbContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(ProductData data)
    {
        Produto produto = new Produto();

        produto.Nome = data.Nome;
        produto.Preco = data.Preco;
        produto.Descricao = data.Descricao;

        this.ctx.Add(produto);
        await this.ctx.SaveChangesAsync();
    }
}
