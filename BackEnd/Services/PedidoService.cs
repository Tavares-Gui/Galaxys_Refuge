// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;

// namespace backCPC.Services;

// using DTO;
// using System;
// using Back.Model;
// using Microsoft.Identity.Client;
// using System.Collections.Generic;
// using Swashbuckle.AspNetCore.SwaggerGen;
// using Microsoft.AspNetCore.Http.Features;
// using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
// using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

// public class PedidoService : IPedidoService
// {
//     GalaxysRefugeDbContext ctx;

//     public string[] produtos;
//     public int[] qtds;
//     public int[] ids;

//     public PedidoService(GalaxysRefugeDbContext ctx)
//     {
//         this.ctx = ctx;
//     }
//     private async Task<Pedido> getOrder(int order_id)
//     {
//         var orders = 
//             from order in this.ctx.Pedidos
//             where order.Id == order_id
//             select order;

//         return await orders.FirstOrDefaultAsync();
//     }

//     public async Task<List<CozinhaData>> Get()
//     {
//         var query1 =
//             from ped in this.ctx.Pedidos
//             join prodPed in this.ctx.ProdutosPedidos
//                 on ped.Id equals prodPed.PedidoId
//             join prod in this.ctx.Produtos
//                 on prodPed.ProdutoId equals prod.Id
//             select new
//             {
//                 OrderId = ped.Id,
//                 ProdName = prod.Nome,
//                 Quantidade = prodPed.Quantidade,
//                 Pronto = ped.Pronto,
//                 Entregue = ped.Entregue
//             };

//         var a = await query1.ToListAsync();

//         var orders = 
//             from peds in a
//             group peds by peds.OrderId into grouped
//             select new {
//                 OrderId = grouped.Key
//             };

//         var c = orders.ToList();

//         List<CozinhaData> list = new();

//         foreach (var item in c)
//         {
//             var query = 
//                 from member in a
//                 where member.OrderId == item.OrderId
//                 select new {
//                     Nome = member.ProdName,
//                     Quantidade = member.Quantidade,
//                     Pronto = member.Pronto,
//                     Entregue = member.Entregue
//                 };

//             var b = query.ToList();

//             string[] Nomes = b.Select(x=>x.Nome).ToArray();
//             int[] qtds = b.Select(x=>x.Quantidade).ToArray();

//             CozinhaData kd = new()
//             {
//                 OrderId = item.OrderId,
//                 Produto = Nomes,
//                 Quantidade = qtds,
//                 Pronto = b[0].Pronto,
//                 Entregue = b[0].Entregue
//             };
//             list.Add(kd);
//         }
//         return list;
//     }
// }