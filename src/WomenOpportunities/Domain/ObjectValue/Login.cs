namespace WomenOpportunities.Domain.ObjectValue;

public class Login
{
    public string Email { get; private set; }
    public string Senha { get; private set; }

    protected Login() { }

    public Login(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    
    public void AtribuirEmail(string email) => Email = email;
    public void AtribuirSenha(string senha) => Senha = senha;
}