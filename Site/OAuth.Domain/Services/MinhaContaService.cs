using OAuth.Domain.Interfaces;
using OAuth.Domain.ViewObjects;
using Refit;
using System.Threading.Tasks;

namespace OAuth.Domain.Services
{
    public class MinhaContaService : IMinhaContaService
    {
        public Task<MinhaConta> MeusDados(string token)
        {
            var minhaContaApi = RestService.For<IMinhaContaApi>("https://localhost:8001");
            return minhaContaApi.MeusDados($"Bearer {token}");
        }
    }
}
