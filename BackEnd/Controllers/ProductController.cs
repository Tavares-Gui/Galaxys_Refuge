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








    // [HttpGet("image")]
    // [EnableCors("DefaultPolicy")]
    // public async Task<IActionResult> GetImage(
    //     int photoId,
    //     [FromServices]ISecurityService security,
    //     [FromServices]GalaxysRefugeDbContext ctx)
    // {
    //     var query =
    //         from image in ctx.Imagems
    //         where image.Id == photoId
    //         select image;
        
    //     var photo = await query.FirstOrDefaultAsync();
    //     if (photo is null)
    //         return NotFound();

    //     return File(photo.Foto, "image/jpeg");
    // }

    // [DisableRequestSizeLimit]
    // [HttpPut("image")]
    // [EnableCors("DefaultPolicy")]
    // public async Task<IActionResult> AddImage(
    //     [FromServices]ISecurityService security
    // )
    // {
    //     var jwtData = Request.Form["jwt"];
    //     var jwtObj = JsonSerializer
    //         .Deserialize<JwtToken>(jwtData);
    //     var jwt = jwtObj.jwt;

    //     var userOjb = await security
    //         .ValidateJwt<JwtPayload>(jwt);
    //     if (userOjb is null)
    //         return Unauthorized();
    //     var userId = userOjb.id;

    //     var files = Request.Form.Files;
    //     if (files is null || files.Count == 0)
    //         return BadRequest();
        
    //     var file = Request.Form.Files[0];
    //     if (file.Length < 1)
    //         return BadRequest();
 
    //     using MemoryStream ms = new MemoryStream();
    //     await file.CopyToAsync(ms);
    //     var data = ms.GetBuffer();

    //     Imagem img = new Imagem();
    //     img.Foto = data;

    //     GalaxysRefugeDbContext ctx = new GalaxysRefugeDbContext();
    //     ctx.Add(img);
    //     await ctx.SaveChangesAsync();

    //     return Ok();
    // }
}