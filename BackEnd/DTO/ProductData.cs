using System;
using Back.Model;

namespace DTO;

public class ProductData
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Descricao { get; set; }
    public int ImagemId { get; set; }
}