using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Domain;

public class Favoritos
{
    public Guid UsuarioId { get; private set; }
    public Usuario Usuario { get; set; }
    public Guid OportunidadeId { get; private set; }
    public Oportunidade Oportunidade { get; set; }
    
    protected Favoritos() {}

    public Favoritos(Guid usuarioId, Guid oportunidadeId)
    {
        UsuarioId = usuarioId;
        OportunidadeId = oportunidadeId;
    }
}