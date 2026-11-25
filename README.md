
# EstoqueFacil

**Versão: v1.0.0**

Sistema de controle de estoque desenvolvido em **C#**, utilizando **xUnit** para testes automatizados e **GitFlow** para organização do versionamento.

## Funcionalidades

O sistema permite:

- Cadastrar produtos com ID, nome, quantidade e preço.
- Impedir o cadastro de produtos com ID duplicado.
- Consultar os produtos cadastrados.
- Consultar a quantidade disponível de um produto.
- Identificar produtos com estoque baixo ou sem estoque.
- Registrar entradas e saídas de produtos.
- Atualizar as quantidades disponíveis.
- Tratar situações como produtos inexistentes, quantidades inválidas e estoque insuficiente.

## Testes automatizados

O projeto utiliza o framework **xUnit** para verificar o funcionamento das regras de negócio.

Os testes abrangem operações de cadastro, movimentação e consulta de estoque, incluindo situações válidas e tratamento de erros.

### Validação da versão v1.0.0

| Projeto | Testes aprovados |
|---|---:|
| EstoqueFacil.Tests | 15 |
| MovimentacaoEstoque.Tests | 3 |
| Total | 18 |

- Testes aprovados: 18
- Testes com falha: 0
- Testes ignorados: 0
- Taxa de aprovação: 100%

## Como executar os testes

### Pré-requisitos

- SDK do .NET 10.
- Runtime do .NET 9 compatível com o projeto de movimentação.

### Execução

1. Clonar o repositório.
2. Abrir um terminal na pasta que contém `EstoqueFacil.sln`.
3. Executar o comando:

```bash
dotnet test EstoqueFacil.sln
```

O comando compila a solução, executa os testes automatizados e apresenta os resultados.

## Controle de versão

O projeto utiliza GitFlow para organizar o desenvolvimento colaborativo.

- `main`: versão estável do projeto.
- `develop`: integração das funcionalidades desenvolvidas.
- `feature`: desenvolvimento de novas funcionalidades.
- `release`: preparação e validação de versões oficiais.
- `hotfix`: correções emergenciais na versão estável, quando necessárias.

## Release v1.0.0

A branch `release/v1.0.0` foi criada a partir da `develop` para preparar a primeira versão oficial do sistema.

Durante a preparação da release, foram realizadas a revisão da documentação e a execução dos 18 testes automatizados da solução, todos aprovados.