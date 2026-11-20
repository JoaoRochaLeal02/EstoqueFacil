namespace MovimentacaoEstoque;

public class MovimentacaoEstoque
{
    private int saldo;

    public int ConsultarSaldo()
    {
        return saldo;
    }

    public void RegistrarEntrada(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        saldo += quantidade;
    }

    public void RegistrarSaida(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        if (quantidade > saldo)
        {
            throw new InvalidOperationException("Estoque insuficiente.");
        }

        saldo -= quantidade;
    }
}