using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueFacil
{
    public class EstoqueServico
    {
        private readonly EstoqueRepositorio _repositorio; ///referencia ao repositório

        public EstoqueServico (EstoqueRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void RegistrarEntrada (int IdProduto, int quantidade) //método registrar entrada ID do produto e quantidade que chegaram
        {
            var produto = _repositorio.BuscarPorId(IdProduto); /// busca o produto por ID
            if (produto == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");  // verifica se o produto existe, se devolver null lancará a exceção
            }
            if (quantidade <= 0)
            {
                throw new ArgumentException("A quantidade deve ser maior que zero.");
            }
            produto.Quantidade += quantidade;
        }

    }
}
