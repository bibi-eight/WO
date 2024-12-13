using EstartandoDevsCore.Data;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IInstituicaoRepository : IRepository<Instituicao>
{
    Task<IEnumerable<Instituicao>> ObterInstituicoes();
}