# Projeto Módulo 1 FullStack Floripa + Tec

Projeto desenvolvido em C# com .Net

## Ferramentas necessárias para uso do projeto:

  - VSCode ou Visual Studio
  - Postman, Insomnia ou Thunder Client(Extensão do VSCode)
  - SQL Server
  - Google Chrome

## Funcionalidade da aplicação
Com a aplicação é possível fazer um crud da entidade Alunos e a seleção das outras categoarias.

## Como usar a aplicação

- No VSCode abra o terminal e digite: dotnet run 
- Inicie a aplicação
- Na ferramenta de banco de dados verifique se foram criadas as tabelas
- No Postman ou no Swagger execute os endpoints
- Retorne ao SQL Server e veja os resultados da manipulação obtida com os endpoints
  
## Projeto documentado com a ferramenta Swagger.
O projeto pode ser executado com a ferramenta de documentação:   
 [Swagger](http://localhost:5119/swagger-ui.html#/)


## Exemplos de execução na ferramenta Thunder Client

### Exemplo de como cadastrar uma categoria:
### Método POST

![](Prints/post.png)

### Exemplo de como exibir uma categoria:
### Método GET

![](/modulo3/src/main/resources/getCategoria.png)

### Exemplo de como editar uma categoria:
### Método PUT

![](/modulo3/src/main/resources/putCategoria.png)

### Exemplo de como deletar uma categoria:
### Método DELETE

![](/modulo3/src/main/resources/deleteCategoria.png)

### Atenção!!!
Se um produto estiver cadastrado com uma categoria será exibido este erro:
### Método DELETE

![](/modulo3/src/main/resources/erroDeleteCategoria.png)



### Exemplo de como cadastrar um produto:
  Este é o formato Json para realizar o cadastro da entidade. Para manipular a entidade Produto é só seguir seguir os passos de Categoria.
#### Obs.: É necessário ter no mínimo uma categoria registrada antes de cadastrar um  produto.
### Método POST
### Url http://localhost:4000/produtos

    {
        "nome": "bolacha recheada",
        "valorProduto":5.0,
        "statusProduto": true,
        "id_categoria":1
    }

Resultado esperado:

    {
        "id": 1,
        "nome": "bolacha recheada",
        "valorProduto":5.0,
        "statusProduto": true,
        "id_categoria":1
    }


### Produzido por Emanuel Lopes
## Aluno FuturoDev Senai






