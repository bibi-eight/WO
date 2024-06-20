using WomenOpportunities.Domain;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.ViewModels;

public class UsuarioViewModel
{
    public Guid UsuarioId { get; set; }
    public string Nome { get; set; }
    public string EmailContato { get; set; }
    public string TelefoneContato { get; set; }
    public string EmailLogin { get; set; }
    public string SenhaLogin { get; set; }
    public int QuantidadeDeFavoritos { get; set; }
    public IEnumerable<FavoritosViewModel> Favoritos { get; set; }

    public static UsuarioViewModel Mapear(Usuario usuario)
    {
        return new UsuarioViewModel()
        {
            UsuarioId = usuario.Id,
            Nome = usuario.Nome,
            EmailContato = usuario.Contato.Email,
            TelefoneContato = usuario.Contato.Telefone,
            EmailLogin = usuario.Login.Email,
            SenhaLogin = usuario.Login.Senha,
            QuantidadeDeFavoritos = usuario.QuantidadeDeFavoritos,
            Favoritos = usuario.Favoritos.Select(FavoritosViewModel.Mapear)
        };
    }
}

public class FavoritosViewModel
{
    public Guid UsuarioId { get; set; }

    public Guid OportunidadeId { get; set; }

    public static FavoritosViewModel Mapear(Favoritos favoritos)
    {
        return new FavoritosViewModel()
        {
            UsuarioId = favoritos.UsuarioId,
            OportunidadeId = favoritos.OportunidadeId
        };
    }
}