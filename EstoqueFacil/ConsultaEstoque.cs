
using System.Collections.Generic;
using System.Linq;

namespace EstoqueFacil
{
    public class ConsultaEstoque
    {
        private readonly EstoqueRepositorio _repositorio;

        public ConsultaEstoque(EstoqueRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Produto> ListarProdutos()
        {
            return _repositorio.ListarTodos();
        }

        public int? ConsultarQuantidade(int id)
        {
            Produto? produto = _repositorio.BuscarPorId(id);
            return produto?.Quantidade;
        }

        public List<Produto> ProdutosEstoqueBaixo(int limite)
        {
            return _repositorio.ListarTodos()
                .Where(p => p.Quantidade > 0 && p.Quantidade < limite)
                .ToList();
        }

        public List<Produto> ProdutosSemEstoque()
        {
            return _repositorio.ListarTodos()
                .Where(p => p.Quantidade == 0)
                .ToList();
        }
    }
}
