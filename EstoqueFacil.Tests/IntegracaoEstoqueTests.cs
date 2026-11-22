
using System;
using EstoqueFacil;
using Xunit;

namespace EstoqueFacil.Tests
{
    public class IntegracaoEstoqueTests
    {
        [Fact]
        public void DeveAtualizarConsultaAposEntrada()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10
            });

            var servico = new EstoqueServico(repositorio);
            var consulta = new ConsultaEstoque(repositorio);

            servico.RegistrarEntrada(1, 5);

            var produtos = consulta.ListarProdutos();

            Assert.Single(produtos);
            Assert.Equal(15, produtos[0].Quantidade);
        }

        [Fact]
        public void DeveAtualizarConsultaAposSaida()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Teclado",
                Quantidade = 20
            });

            var servico = new EstoqueServico(repositorio);
            var consulta = new ConsultaEstoque(repositorio);

            servico.RegistrarSaida(1, 5);

            var produtos = consulta.ListarProdutos();

            Assert.Single(produtos);
            Assert.Equal(15, produtos[0].Quantidade);
        }

        [Fact]
        public void NaoDevePermitirSaidaComEstoqueInsuficiente()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10
            });

            var servico = new EstoqueServico(repositorio);

            Assert.Throws<InvalidOperationException>(() =>
                servico.RegistrarSaida(1, 15));
        }

        [Fact]
        public void NaoDevePermitirMovimentacaoDeProdutoInexistente()
        {
            var repositorio = new EstoqueRepositorio();
            var servico = new EstoqueServico(repositorio);

            Assert.Throws<InvalidOperationException>(() =>
                servico.RegistrarSaida(99, 3));
        }

        [Fact]
        public void NaoDevePermitirSaidaComQuantidadeNegativa()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Monitor",
                Quantidade = 10
            });

            var servico = new EstoqueServico(repositorio);

            Assert.Throws<ArgumentException>(() =>
                servico.RegistrarSaida(1, -5));
        }

        [Fact]
        public void NaoDevePermitirEntradaComQuantidadeZero()
        {
            var repositorio = new EstoqueRepositorio();

            repositorio.Adicionar(new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10
            });

            var servico = new EstoqueServico(repositorio);

            Assert.Throws<ArgumentException>(() =>
                servico.RegistrarEntrada(1, 0));
        }
    }
}
