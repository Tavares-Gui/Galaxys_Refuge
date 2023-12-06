using System.Threading.Tasks;

namespace Back.Services;

using DTO;
using Model;

public interface ICupomService
{
    Task Create(CupomData data);
}