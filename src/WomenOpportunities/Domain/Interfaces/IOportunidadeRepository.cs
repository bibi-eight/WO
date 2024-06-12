using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IOportunidadeRepository
{
    void CriarOportunidade(Oportunidade oportunidade);
    void AtualizarOportunidade(Oportunidade oportunidade);
    Task<bool> RemoverOportunidade(Guid id);
    Task<Oportunidade> ObterOportunidadePorId(Guid oportunidadeId);
    Task<IEnumerable<Oportunidade>> ObterOportunidades();
}