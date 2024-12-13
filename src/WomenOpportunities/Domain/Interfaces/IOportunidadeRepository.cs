using EstartandoDevsCore.Data;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IOportunidadeRepository : IRepository<Oportunidade>
{
    Task<IEnumerable<Oportunidade>> ObterOportunidades();
}