using DTO;
using System;
using Back.Model;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Back.Services;

public class CupomService : ICupomService
{
    GalaxysRefugeDbContext ctx;
    public CupomService(GalaxysRefugeDbContext ctx)
    {
        this.ctx = ctx;
    }

    public async Task Create(CupomData data)
    {
        Cupon cupon = new Cupon();

        cupon.Codigo = data.Codigo;
        cupon.Desconto = data.Desconto;
        cupon.Descricao = data.Descricao;

        this.ctx.Add(cupon);
        await this.ctx.SaveChangesAsync();
    }
}
