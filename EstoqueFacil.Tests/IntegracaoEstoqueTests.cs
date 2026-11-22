
using EstoqueFacil;
using Xunit;

namespace EstoqueFacil.Tests
{
    public class IntegracaoEstoqueTests
    {
        [Fact]
        public void DeveAtualizarConsultaAposMovimentacao()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10,
                Preco = 50
            });

            var servico = new EstoqueServico(repositorio);
            var consulta = new ConsultaEstoque(repositorio);

            servico.RegistrarSaida(1, 3);

            var produtos = consulta.ListarProdutos();

            Assert.Single(produtos);
            Assert.Equal("Mouse", produtos[0].Nome);
            Assert.Equal(7, produtos[0].Quantidade);
        }
    }
}
