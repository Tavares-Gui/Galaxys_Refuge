using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Back.Controllers;

using System.Security.Cryptography;
using DTO;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Model;
using Services;
using Trevisharp.Security.Jwt;

[ApiController]
[Route("product")]
public class ProdutoController : ControllerBase
{
    [HttpPost("register")]
    [EnableCors("DefaultPolicy")]
    public async Task<IActionResult> Create(
        [FromBody]ProductData product,
        [FromServices]IProdutoService service)
    {
        var errors = new List<string>();

        //VALIDACOES

        if (errors.Count > 0)
            return BadRequest(errors);

        await service.Create(product);
        return Ok();
    }
}