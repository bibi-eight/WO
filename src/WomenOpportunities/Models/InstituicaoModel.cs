using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Models;

public class InstituicaoModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public ContatoModel Contato { get; set; }
    public LoginModel Login { get; set; }
}

public class ContatoModel
{
    public string Email { get; set; }
    public string Telefone { get; set; }
}

public class LoginModel
{
    public string Email { get; set; }
    public string Senha { get; set; }
}