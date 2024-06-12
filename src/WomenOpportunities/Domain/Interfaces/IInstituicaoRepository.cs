using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain.Interfaces;

public interface IInstituicaoRepository
{
    void CriarInstituicao(Instituicao instituicao);
    void AtualizarInstituicao(Instituicao instituicao);
    Task<bool> RemoverInstituicao(Guid id);
    Task<Instituicao> ObterInstituicaoPorId(Guid instituicaoId);
    Task<IEnumerable<Instituicao>> ObterInstituicoes();
}