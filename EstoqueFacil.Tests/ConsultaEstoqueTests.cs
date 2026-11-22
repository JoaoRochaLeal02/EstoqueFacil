
using EstoqueFacil;
using Xunit;

namespace EstoqueFacil.Tests
{
    public class ConsultaEstoqueTests
    {
        [Fact]
        public void ListarProdutos_DeveRetornarTodos()
        {
            var repositorio = new EstoqueRepositorio();
            repositorio.Adicionar(new Produto { Id = 1, Nome = "Mouse", Quantidade = 10 });
            repositorio.Adicionar(new Produto { Id = 2, Nome = "Teclado", Quantidade = 5 });

            var consulta = new ConsultaEstoque(repositorio);

            var resultado = consulta.ListarProdutos();

            Assert.Equal(2, resultado.Count);
        }

        [Fact]
        public void ConsultarQuantidade_DeveRetornarQuantidadeCorreta()
        {
            var repositorio = new EstoqueRepositorio();
            repositorio.Adicionar(new Produto { Id = 1, Nome = "Mouse", Quantidade = 10 });

            var consulta = new ConsultaEstoque(repositorio);

            var resultado = consulta.ConsultarQuantidade(1);

            Assert.Equal(10, resultado);
        }

        [Fact]
        public void ConsultarQuantidade_ProdutoInexistente_DeveRetornarNull()
        {
            var repositorio = new EstoqueRepositorio();
            var consulta = new ConsultaEstoque(repositorio);

            var resultado = consulta.ConsultarQuantidade(99);

            Assert.Null(resultado);
        }

        [Fact]
        public void ProdutosEstoqueBaixo_DeveRetornarProdutosAbaixoDoLimite()
        {
            var repositorio = new EstoqueRepositorio();
            repositorio.Adicionar(new Produto { Id = 1, Nome = "Mouse", Quantidade = 3 });
            repositorio.Adicionar(new Produto { Id = 2, Nome = "Teclado", Quantidade = 15 });

            var consulta = new ConsultaEstoque(repositorio);

            var resultado = consulta.ProdutosEstoqueBaixo(5);

            Assert.Single(resultado);
            Assert.Equal("Mouse", resultado[0].Nome);
        }

        [Fact]
        public void ProdutosSemEstoque_DeveRetornarProdutosZerados()
        {
            var repositorio = new EstoqueRepositorio();
            repositorio.Adicionar(new Produto { Id = 1, Nome = "Mouse", Quantidade = 0 });
            repositorio.Adicionar(new Produto { Id = 2, Nome = "Teclado", Quantidade = 10 });

            var consulta = new ConsultaEstoque(repositorio);

            var resultado = consulta.ProdutosSemEstoque();

            Assert.Single(resultado);
            Assert.Equal("Mouse", resultado[0].Nome);
        }
    }
}
