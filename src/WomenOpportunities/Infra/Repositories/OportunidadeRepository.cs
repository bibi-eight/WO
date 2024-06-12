using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain.Entities;
using WomenOpportunities.Domain.Interfaces;
using WomenOpportunities.Infra.Data;

namespace WomenOpportunities.Infra.Repositories;

public class OportunidadeRepository : IOportunidadeRepository
{
    private readonly WOContext _context;

    public OportunidadeRepository(WOContext context)
    {
        _context = context;
    }

    public void CriarOportunidade(Oportunidade oportunidade)
    {
        _context.Oportunidades.Add(oportunidade);
    }

    public void AtualizarOportunidade(Oportunidade oportunidade)
    {
        _context.Oportunidades.Update(oportunidade);
    }

    public async Task<bool> RemoverOportunidade(Guid id)
    {
        var oportunidade = await _context.Oportunidades.FirstOrDefaultAsync(x => x.Id == id);

        if (oportunidade is null)
        {
            return false;
        }

        _context.Oportunidades.Remove(oportunidade);
        await _context.SaveChangesAsync();

        return true;    
    }

    public async Task<Oportunidade> ObterOportunidadePorId(Guid oportunidadeId)
    {
        return await _context.Oportunidades.FirstOrDefaultAsync(X => X.Id == oportunidadeId);
    }

    public async Task<IEnumerable<Oportunidade>> ObterOportunidades()
    {
        return await _context.Oportunidades.ToListAsync();
    }
}