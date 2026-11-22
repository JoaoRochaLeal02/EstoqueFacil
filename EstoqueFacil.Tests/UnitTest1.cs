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
        [Fact]
        public void RegistrarEntrada_QuantidadeNegativa_DeveLancarExcecao()
        {
            var repositorio = new EstoqueRepositorio();

            var produto = new Produto
            {
                Id = 1,
                Nome = "Teclado",
                Quantidade = 10,
                Preco = 100
            };
            repositorio.Adicionar(produto);
           var servico =  new EstoqueServico(repositorio);
           Assert.Throws<ArgumentException>(() =>
           servico.RegistrarEntrada(1, -5));

        }
        [Fact]
        public void RegistrarEntrada_ProdutoInexistente_DeveLancarExcecao()
        {
            var repositorio = new EstoqueRepositorio();
            var servico = new EstoqueServico(repositorio); // passando repositório vazio para fazer o teste
            Assert.Throws<InvalidOperationException>(() =>
            servico.RegistrarEntrada(99, 5));
        }
        [Fact]
        public void Adicionar_ProdutoComIdDuplicado_DeveLancarExcecao()
        {
            var repositorio = new EstoqueRepositorio();
            var mouse = new Produto
            {
                Id = 1,
                Nome = "Mouse",
                Quantidade = 10,
                Preco = 50
            };
            repositorio.Adicionar(mouse);
            var teclado = new Produto
            {
                Id = 1,
                Nome = "Teclado",
                Quantidade = 5,
                Preco = 100
            };
            Assert.Throws<InvalidOperationException>(() =>
            repositorio.Adicionar(teclado));


        }
    }
}
