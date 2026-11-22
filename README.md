# EstoqueFacil

Sistema de controle de estoque desenvolvido em **C#**, utilizando **xUnit** para testes automatizados e **GitFlow** para organização do versionamento.

## Funcionalidades

O sistema permite:

- Cadastrar produtos com ID, nome, quantidade e preço.
- Consultar os produtos cadastrados.
- Identificar produtos sem estoque.
- Registrar entradas e saídas de produtos.
- Atualizar as quantidades disponíveis.
- Tratar situações como produtos inexistentes, quantidades inválidas e estoque insuficiente.

## Testes automatizados

O projeto utiliza o framework **xUnit** para verificar o funcionamento das regras de negócio.

Os testes abrangem operações de cadastro, movimentação e consulta de estoque, incluindo situações válidas e tratamento de erros.

## Como executar os testes

**Pré-requisito:** possuir o SDK do .NET compatível com o projeto instalado.

1. Clonar o repositório.
2. Abrir um terminal na pasta que contém `EstoqueFacil.sln`.
3. Executar o comando:

```bash
dotnet test
```

O comando compila os projetos de testes e apresenta os resultados, indicando quantos testes passaram, falharam ou foram ignorados.

## Controle de versão

O projeto utiliza GitFlow, com branches `main`, `develop` e `feature` para organizar o desenvolvimento colaborativo.
