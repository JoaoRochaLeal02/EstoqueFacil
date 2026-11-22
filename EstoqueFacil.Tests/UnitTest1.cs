namespace EstoqueFacil.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void RegistrarEntrada_DeveAumentarQuantidade ()
        {
            var repositorio = new EstoqueRepositorio(); // cria reposítório vazio
            var produto = new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10,
                Preco = 50
            };
            repositorio.Adicionar(produto); // adiciona o produto no repositório
            var servico = new EstoqueServico(repositorio);
            servico.RegistrarEntrada(1, 5);
            Assert.Equal(15, produto.Quantidade); // valor esperado x valor obtido
        }
    }
}
