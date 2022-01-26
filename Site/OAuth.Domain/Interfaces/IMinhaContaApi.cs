using OAuth.Domain.ViewObjects;
using Refit;
using System.Threading.Tasks;

namespace OAuth.Domain.Interfaces
{
    public interface IMinhaContaApi
    {
        [Get("/minhaConta/meusDados")]
        Task<MinhaConta> MeusDados([Header("Authorization")] string token);
    }
}
