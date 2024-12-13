using EstartandoDevsCore.Data;
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
    public IUnitOfWorks UnitOfWork { get; }

    public async Task<IEnumerable<Oportunidade>> ObterOportunidades()
    {
        return await _context.Oportunidades.ToListAsync();
    }

    public async Task<Oportunidade> ObterPorId(Guid Id)
    {
        return await _context.Oportunidades.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public void Adicionar(Oportunidade entity)
    {
        _context.Oportunidades.Add(entity);
    }

    public void Atualizar(Oportunidade entity)
    {
        _context.Oportunidades.Update(entity);
    }

    public void Apagar(Func<Oportunidade, bool> predicate)
    {
        _context.Oportunidades.RemoveRange(_context.Oportunidades.Where(predicate));
    }
    
    public void Dispose()
    {
        _context?.Dispose();
    }
}