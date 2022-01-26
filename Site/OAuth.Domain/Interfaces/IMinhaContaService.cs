using OAuth.Domain.ViewObjects;
using System.Threading.Tasks;

namespace OAuth.Domain.Interfaces
{
    public interface IMinhaContaService
    {
        Task<MinhaConta> MeusDados(string token);
    }
}
