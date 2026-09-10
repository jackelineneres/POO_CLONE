namespace PooPedidos.Entidades;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;

    public Cliente(int id, string nome, string email, string telefone, string endereco)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public Boolean ValidarDados(ref string mensagem)
    {
        if (Nome.Length < 3)
        {

        }
    }

    public bool ValidarCliente(string mensagem)
    {   
        if (Nome Length <=3)
        {
            mensagem = "Nome do cliente deve ter mais de 3 caracteres.";
            return false;
        }
        return true;
    }
    public override string ToString() => 
        $"Cliente #{Id}: {Nome}\n" +
        $"  Email: {Email}\n" +
        $"  Telefone: {Telefone}\n" +
        $"  Endereço: {Endereco}";
}
