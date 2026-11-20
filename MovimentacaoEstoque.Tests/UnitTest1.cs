using Xunit;
using MovimentacaoEstoque;

namespace MovimentacaoEstoque.Tests;

public class UnitTest1
{
    [Fact]
    public void RegistrarEntrada_DeveAumentarSaldo()
    {
        var estoque = new MovimentacaoEstoque();

        estoque.RegistrarEntrada(10);

        Assert.Equal(10, estoque.ConsultarSaldo());
    }

    [Fact]
    public void RegistrarSaida_DeveDiminuirSaldo()
    {
        var estoque = new MovimentacaoEstoque();

        estoque.RegistrarEntrada(10);
        estoque.RegistrarSaida(4);

        Assert.Equal(6, estoque.ConsultarSaldo());
    }

    [Fact]
    public void RegistrarSaida_MaiorQueSaldo_DeveGerarErro()
    {
        var estoque = new MovimentacaoEstoque();

        estoque.RegistrarEntrada(5);

        Assert.Throws<InvalidOperationException>(
            () => estoque.RegistrarSaida(8)
        );

        Assert.Equal(5, estoque.ConsultarSaldo());
    }
}