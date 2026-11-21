using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueFacil
{
    internal class EstoqueRepositorio
    {
        private readonly List<Produto> _produtos = new();
        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }
    }
}
