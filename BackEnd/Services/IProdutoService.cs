using System.Threading.Tasks;

namespace Back.Services;

using DTO;
using Model;

public interface IProdutoService
{
    Task Create(ProductData data);
}