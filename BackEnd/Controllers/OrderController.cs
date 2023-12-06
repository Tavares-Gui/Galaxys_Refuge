// using System;
// using System.IO;
// using System.Linq;
// using System.Text.Json;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Cors;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;

// namespace backCPC.Controllers;

// using DTO;
// using backCPC.Services;
// using System.ComponentModel;
// using Trevisharp.Security.Jwt;
// using System.Security.Cryptography;

// [ApiController]
// [Route("pedido")]
// public class PedidoController : ControllerBase
// {
//     [HttpPost("register")]
//     [EnableCors("DefaultPolicy")]
//     public async Task<IActionResult> Create(
//         [FromServices]IPedidoService service)
//     {
//         var errors = new List<string>();

//         if (errors.Count > 0)
//             return BadRequest(errors);

//         var id = await service.Create(carrinho[0].Total);

//         return Ok();
//     }

//     [HttpGet("")]
//     [EnableCors("DefaultPolicy")]
//     public async Task<IActionResult> Get(
//         [FromServices]IPedidoService service)
//     {
//         var a = await service.Get();
//         var errors = new List<string>();
//         if (errors.Count > 0)
//             return BadRequest(errors);

//         return Ok(a);
//     }

//     [HttpDelete]
//     [EnableCors("DefaultPolicy")]
//     public IActionResult DeleteUser()
//     {
//         throw new NotImplementedException();
//     }
// }