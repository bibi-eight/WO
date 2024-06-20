using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.ViewModels;

public class InstituicaoVIewModel
{
    public Guid InstituicaoId { get; set; }
    public string Nome { get; set; }
    public string EmailContato { get; set; }
    public string TelefoneContato { get; set; }
    public string EmailLogin { get; set; }
    public string SenhaLogin { get; set; }
    public int QuantidadeDeOportunidades { get; set; }
    public IEnumerable<OportunidadeViewModel> Oportunidades { get; set; }

    public static InstituicaoVIewModel Mapear(Instituicao instituicao)
    {
        return new InstituicaoVIewModel()
        {
            InstituicaoId = instituicao.Id,
            Nome = instituicao.Nome,
            EmailContato = instituicao.Contato.Email,
            TelefoneContato = instituicao.Contato.Telefone,
            EmailLogin = instituicao.Login.Email,
            SenhaLogin = instituicao.Login.Senha,
            QuantidadeDeOportunidades = instituicao.QuantidadeDeOportunidades,
            Oportunidades = instituicao.Oportunidades.Select(OportunidadeViewModel.Mapear)
        };
    }
}