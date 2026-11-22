
using System.Collections.Generic;

namespace EstoqueFacil
{
    public class EstoqueRepositorio
    {
        private readonly List<Produto> _produtos = new();

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public Produto? BuscarPorId(int id)
        {
            return _produtos.Find(p => p.Id == id);
        }

        public List<Produto> ListarTodos()
        {
            return new List<Produto>(_produtos);
        }
    }
}
