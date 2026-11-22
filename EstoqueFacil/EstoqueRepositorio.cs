
using System.Collections.Generic;

namespace EstoqueFacil
{
    public class EstoqueRepositorio
    {
        private readonly List<Produto> _produtos = new();

        public void Adicionar(Produto produto)
        {
            var produtoExistente = BuscarPorId(produto.Id); // procurando no repositório um produto que tenha o mesmo id daquele que queremos cadastrar

            if (produtoExistente != null)
            {
                throw new InvalidOperationException("Já existe um produto com esse ID."); // lança a exceção
            }

            _produtos.Add(produto);
        }

        public Produto? BuscarPorId(int id)
        {
            return _produtos.Find(p => p.Id == id); //método find pesquisa na lista se existe algum id igual ao id recebido como parâmetro no método BuscarPorID
        }

        public List<Produto> ListarTodos()
        {
            return new List<Produto>(_produtos);
        }
    }
}
