using System.ComponentModel.DataAnnotations;
using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Models;

public class InstituicaoModel
{
    public Guid InstituicaoId { get; set; }
    public string Nome { get; set; }
    public ContatoModel Contato { get; set; }
    public LoginModel Login { get; set; }
}

public class ContatoModel
{
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Telefone { get; set; }
}

public class LoginModel
{
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Senha { get; set; }
}