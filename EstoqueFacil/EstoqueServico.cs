
using System;

namespace EstoqueFacil
{
    public class EstoqueServico
    {
        private readonly EstoqueRepositorio _repositorio;

        public EstoqueServico(EstoqueRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void RegistrarEntrada(int idProduto, int quantidade)
        {
            var produto = _repositorio.BuscarPorId(idProduto);

            if (produto == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");
            }

            if (quantidade <= 0)
            {
                throw new ArgumentException("A quantidade deve ser maior que zero.");
            }

            produto.Quantidade += quantidade;
        }

        public void RegistrarSaida(int idProduto, int quantidade)
        {
            var produto = _repositorio.BuscarPorId(idProduto);

            if (produto == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");
            }

            if (quantidade <= 0)
            {
                throw new ArgumentException("A quantidade deve ser maior que zero.");
            }

            if (quantidade > produto.Quantidade)
            {
                throw new InvalidOperationException("Estoque insuficiente.");
            }

            produto.Quantidade -= quantidade;
        }
    }
}
