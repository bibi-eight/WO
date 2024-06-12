using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain.Entities;
using WomenOpportunities.Domain.Interfaces;
using WomenOpportunities.Infra.Data;

namespace WomenOpportunities.Infra.Repositories;

public class InstituicaoRepository : IInstituicaoRepository
{
    private readonly WOContext _context;

    public InstituicaoRepository(WOContext context)
    {
        _context = context;
    }

    public void CriarInstituicao(Instituicao instituicao)
    {
        _context.Instituicaos.Add(instituicao);
        _context.SaveChanges();
    }

    public void AtualizarInstituicao(Instituicao instituicao)
    {
        _context.Instituicaos.Update(instituicao);
        _context.SaveChanges();
    }

    public async Task<bool> RemoverInstituicao(Guid id)
    {
        var instituicao = await _context.Instituicaos.FirstOrDefaultAsync(x => x.Id == id);

        if (instituicao is null)
        {
            return false;
        }

        _context.Instituicaos.Remove(instituicao);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<Instituicao> ObterInstituicaoPorId(Guid instituicaoId)
    {
        return await _context.Instituicaos
            .Include(x => x.Oportunidades)
            .FirstOrDefaultAsync(x => x.Id == instituicaoId);
    }

    public async Task<IEnumerable<Instituicao>> ObterInstituicoes()
    {
        return await _context.Instituicaos.ToListAsync();
    }
}