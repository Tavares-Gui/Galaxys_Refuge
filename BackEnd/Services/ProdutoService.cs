using DTO;
using System;
using Back.Model;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        // produto.Imagem = data.Imagem;

        this.ctx.Add(produto);
        await this.ctx.SaveChangesAsync();
    }
}
