# Cenário Prático para Aprendizado de LINQ em C#: Sistema de Gerenciamento de Livraria Online

## Introdução

Bem-vindo ao projeto de aprendizado prático de LINQ em C#! Neste cenário, você trabalhará com um sistema de gerenciamento para uma livraria online. Este ambiente simulado foi projetado para ajudá-lo a dominar os conceitos de LINQ em C# através de situações realistas de manipulação de dados.

## Contexto do Negócio

A "BookVerse" é uma livraria online que está em expansão e precisa melhorar seu sistema de gerenciamento de dados. Como desenvolvedor, você foi contratado para implementar funcionalidades que ajudarão a equipe a obter insights valiosos a partir dos dados da livraria.

O sistema possui as seguintes entidades principais:
- Livros
  - Id
  - Title
  - AuthorId
  - CategoryId
  - Price
  - Stock
  - PageCount
  - PublishedDate
  - ISBN
  - Rating
- Autores
  - Id
  - Name
  - Country
  - BirthDate
  - Biography
- Categorias
  - Id
  - Name
  - Description
- Clientes
  - Id,
  - Name
  - Email
  - City
  - Country
  - MemberSince
  - TotalPurchases
- Vendas
  - Id
  - BookId
  - CustomerId
  - SaleDate
  - Quantity
  - TotalAmount

---
> OBS: Você deverá criar cada entidade com os atributos listados acima.
---


## Configuração do Projeto

### Estrutura de Classes

```csharp
// Modelo para Livros
public class Book
{
    // atributos
}

// Modelo para Autores
public class Author
{
    // atributos
}

// Modelo para Categorias
public class Category
{
    // atributos
}

// Modelo para Clientes
public class Customer
{
    // atributos
}

// Modelo para Vendas
public class Sale
{
    // atributos
}
```

### Dados de Exemplo

Criei quatro arquivos JSON que você deve usar neste projeto:

#### books.json (contém 50 livros)
```json
[
  {
    "Id": 1,
    "Title": "O Grande Gatsby",
    "AuthorId": 3,
    "CategoryId": 1,
    "Price": 29.99,
    "Stock": 15,
    "PageCount": 180,
    "PublishedDate": "1925-04-10T00:00:00",
    "ISBN": "978-3-16-148410-0",
    "Rating": 4.5
  },
  // ... mais 49 registros ...
]
```

#### authors.json (contém 30 autores)
```json
[
  {
    "Id": 1,
    "Name": "Jane Austen",
    "Country": "Reino Unido",
    "BirthDate": "1775-12-16T00:00:00",
    "Biography": "Romancista inglesa conhecida principalmente por seus seis romances principais."
  },
  // ... mais 29 registros ...
]
```

#### categories.json (contém 10 categorias)
```json
[
  {
    "Id": 1,
    "Name": "Ficção Clássica",
    "Description": "Obras literárias que resistiram ao teste do tempo"
  },
  // ... mais 9 registros ...
]
```

#### sales.json (contém 100 vendas)
```json
[
  {
    "Id": 1,
    "BookId": 5,
    "CustomerId": 12,
    "SaleDate": "2023-05-15T14:30:00",
    "Quantity": 1,
    "TotalAmount": 24.99
  },
  // ... mais 99 registros ...
]
```

#### customers.json (contém 40 clientes)
```json
[
  {
    "Id": 1,
    "Name": "Maria Silva",
    "Email": "maria.silva@email.com",
    "City": "São Paulo",
    "Country": "Brasil",
    "MemberSince": "2020-03-15T00:00:00",
    "TotalPurchases": 12
  },
  // ... mais 39 registros ...
]
```

### Código para Carregar os Dados

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LINQLearningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carregando dados dos arquivos JSON
            var books = LoadData<Book>("books.json");
            var authors = LoadData<Author>("authors.json");
            var categories = LoadData<Category>("categories.json");
            var customers = LoadData<Customer>("customers.json");
            var sales = LoadData<Sale>("sales.json");
            
            // Aqui você irá implementar as consultas LINQ
            
            Console.ReadLine();
        }
        
        static List<T> LoadData<T>(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }
    }
}
```

## Desafios LINQ

Agora vamos aos desafios que você deverá resolver usando LINQ. Para cada desafio, primeiro tente resolver por conta própria, depois consulte as dicas e, se necessário, a solução.

### Nível 1: Fundamentos

#### Desafio 1: Listar livros com preço acima de um determinado valor

**Contexto de negócio:** A equipe de marketing quer criar uma promoção especial para livros premium e precisa de uma lista de todos os livros com preço acima de R$35,00.

**Tarefa:** Use LINQ para filtrar e retornar todos os livros com preço superior a R$35,00. Mostre o título, preço e ID da categoria.

**Dica:** Use o operador `Where` para filtrar e `Select` para projetar os campos específicos.

**Resultado esperado:** Uma lista de objetos anônimos contendo título, preço e ID da categoria de cada livro premium.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestExpensiveBooks()
{
    // Execute sua consulta LINQ aqui
    // var result = ... sua solução do Desafio 1 ...
    
    // Validações
    // 1. Verificar a contagem total
    Assert.AreEqual(12, result.Count(), "Deve haver exatamente 12 livros com preço acima de R$35,00");
    
    // 2. Verificar livros específicos na lista
    Assert.IsTrue(result.Any(b => b.Title == "O Grande Gatsby" && b.Price == 39.99m && b.CategoryId == 1),
        "O livro 'O Grande Gatsby' deve estar na lista");
    Assert.IsTrue(result.Any(b => b.Title == "Cem Anos de Solidão" && b.Price == 42.50m && b.CategoryId == 1),
        "O livro 'Cem Anos de Solidão' deve estar na lista");
        
    // 3. Verificar livro que não deve estar na lista
    Assert.IsFalse(result.Any(b => b.Title == "Aventuras de Tom Sawyer"),
        "O livro 'Aventuras de Tom Sawyer' não deve estar na lista (preço abaixo de R$35,00)");
}
```

#### Desafio 2: Encontrar autores de um determinado país

**Contexto de negócio:** Para um evento literário focado em autores brasileiros, precisamos identificar todos os autores do Brasil.

**Tarefa:** Use LINQ para encontrar todos os autores do Brasil e retornar seus nomes e datas de nascimento, ordenados alfabeticamente.

**Dica:** Combine os operadores `Where` e `OrderBy`.

**Resultado esperado:** Uma lista de objetos anônimos contendo nome e data de nascimento dos autores brasileiros, em ordem alfabética.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestBrazilianAuthors()
{
    // Execute sua consulta LINQ aqui
    // var result = ... sua solução do Desafio 2 ...
    
    // Validações
    // 1. Verificar a contagem total
    Assert.AreEqual(8, result.Count(), "Deve haver exatamente 8 autores brasileiros");
    
    // 2. Verificar a ordenação alfabética
    var resultList = result.ToList();
    Assert.AreEqual("Clarice Lispector", resultList[0].Name, "O primeiro autor deve ser 'Clarice Lispector'");
    Assert.AreEqual("Machado de Assis", resultList[4].Name, "O quinto autor deve ser 'Machado de Assis'");
    Assert.AreEqual("Paulo Coelho", resultList[7].Name, "O último autor deve ser 'Paulo Coelho'");
    
    // 3. Verificar datas de nascimento específicas
    var machadoDeAssis = resultList.FirstOrDefault(a => a.Name == "Machado de Assis");
    Assert.IsNotNull(machadoDeAssis, "Machado de Assis deve estar na lista");
    Assert.AreEqual(new DateTime(1839, 6, 21), machadoDeAssis.BirthDate);
}
```

#### Desafio 3: Calcular o valor total do estoque

**Contexto de negócio:** O departamento financeiro precisa fazer um balanço do valor total em livros no estoque.

**Tarefa:** Use LINQ para calcular o valor total do estoque (preço × quantidade em estoque para cada livro).

**Dica:** Utilize a operação `Sum` com uma expressão lambda.

**Resultado esperado:** Um valor decimal representando a soma do valor total em estoque (preço multiplicado pela quantidade) de todos os livros.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestTotalStockValue()
{
    // Execute sua consulta LINQ aqui
    // var result = ... sua solução do Desafio 3 ...
    
    // Validações
    // 1. Verificar o valor total do estoque
    Assert.AreEqual(24689.50m, result, 0.01m, "O valor total do estoque deve ser R$ 24.689,50");
    
    // 2. Teste com variação no estoque
    // Criar conjunto de dados modificado
    var modifiedBooks = new List<Book>(_testBooks);
    modifiedBooks[0].Stock = 0; // Zerando o estoque do primeiro livro
    
    // Recalcular com o novo conjunto
    var newResult = /* repita sua consulta LINQ usando modifiedBooks */;
    
    // O valor deve ser menor agora
    Assert.IsTrue(newResult < result, "O valor deve diminuir quando um livro fica sem estoque");
    
    // 3. Teste com estoque vazio
    var emptyStock = new List<Book>();
    var emptyResult = /* repita sua consulta LINQ usando emptyStock */;
    
    Assert.AreEqual(0m, emptyResult, "O valor total deve ser zero quando não há livros");
}
```

#### Desafio 4: Encontrar livros com estoque baixo

**Contexto de negócio:** O gerente de estoque precisa identificar quais livros precisam ser reabastecidos.

**Tarefa:** Use LINQ para listar todos os livros com estoque menor que 10 unidades, mostrando o título, estoque atual e categoria.

**Dica:** Use `Where` para filtrar e faça um `Join` com a tabela de categorias para mostrar o nome da categoria.

#### Desafio 5: Listar vendas recentes

**Contexto de negócio:** O time de vendas precisa analisar as vendas do último mês.

**Tarefa:** Use LINQ para listar todas as vendas dos últimos 30 dias, mostrando o título do livro vendido, data da venda e quantidade.

**Dica:** Use `Where` com uma comparação de data e faça um `Join` com a tabela de livros.

### Nível 2: Intermediário

#### Desafio 6: Agrupar livros por categoria

**Contexto de negócio:** A equipe de UX quer reorganizar o site e precisa entender quantos livros existem em cada categoria.

**Tarefa:** Use LINQ para agrupar os livros por categoria e contar quantos livros existem em cada grupo.

**Dica:** Use `GroupBy` seguido de `Select` para criar um objeto anônimo com o nome da categoria e a contagem.

#### Desafio 7: Calcular média de avaliação por autor

**Contexto de negócio:** Para destacar os autores mais bem avaliados, precisamos calcular a média de avaliação dos livros de cada autor.

**Tarefa:** Use LINQ para calcular a média das avaliações dos livros agrupados por autor.

**Dica:** Combine `GroupBy` com `Average`.

#### Desafio 8: Encontrar os 5 livros mais vendidos

**Contexto de negócio:** Para uma seção de "Mais Vendidos" no site, precisamos identificar os 5 livros com maior número de vendas.

**Tarefa:** Use LINQ para encontrar os 5 títulos mais vendidos, baseado na quantidade total vendida.

**Dica:** Use `GroupBy` para agrupar as vendas por livro, `OrderByDescending` para ordenar por quantidade total e `Take` para limitar a 5 resultados.

**Resultado esperado:** Uma lista contendo os 5 livros mais vendidos, com informações do título e quantidade total vendida, em ordem decrescente de vendas.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestTopFiveSellingBooks()
{
    // Execute sua consulta LINQ aqui
    // var result = ... sua solução do Desafio 8 ...
    
    // Validações
    // 1. Verificar a contagem total
    Assert.AreEqual(5, result.Count(), "Deve haver exatamente 5 livros no resultado");
    
    // 2. Verificar o livro mais vendido
    var topBook = result.First();
    Assert.AreEqual("Dom Casmurro", topBook.Title, "O livro mais vendido deve ser 'Dom Casmurro'");
    Assert.AreEqual(58, topBook.TotalSold, "Dom Casmurro deve ter 58 cópias vendidas");
    
    // 3. Verificar o quinto livro mais vendido
    var fifthBook = result.Last();
    Assert.AreEqual("O Pequeno Príncipe", fifthBook.Title, "O quinto livro mais vendido deve ser 'O Pequeno Príncipe'");
    Assert.AreEqual(32, fifthBook.TotalSold, "O Pequeno Príncipe deve ter 32 cópias vendidas");
    
    // 4. Verificar a ordenação decrescente
    var resultList = result.ToList();
    Assert.IsTrue(resultList[0].TotalSold >= resultList[1].TotalSold, "O primeiro livro deve ter mais vendas que o segundo");
    Assert.IsTrue(resultList[1].TotalSold >= resultList[2].TotalSold, "O segundo livro deve ter mais vendas que o terceiro");
    Assert.IsTrue(resultList[2].TotalSold >= resultList[3].TotalSold, "O terceiro livro deve ter mais vendas que o quarto");
    Assert.IsTrue(resultList[3].TotalSold >= resultList[4].TotalSold, "O quarto livro deve ter mais vendas que o quinto");
}
```

#### Desafio 9: Calcular receita total por mês

**Contexto de negócio:** O departamento financeiro precisa de um relatório de receitas mensais para o último ano.

**Tarefa:** Use LINQ para agrupar as vendas por mês e calcular o total de receita em cada mês.

**Dica:** Use `GroupBy` com uma expressão que extraia o mês da data de venda.

#### Desafio 10: Identificar clientes fiéis

**Contexto de negócio:** A equipe de marketing quer criar um programa de fidelidade para os clientes que mais compram.

**Tarefa:** Use LINQ para identificar os 10 clientes com maior número de compras e valor total gasto.

**Dica:** Use `GroupBy` para agrupar vendas por cliente, `OrderByDescending` para ordenar por quantidade ou valor total, e `Take` para limitar aos 10 primeiros.

### Nível 3: Avançado

#### Desafio 11: Análise de vendas por categoria e mês

**Contexto de negócio:** A diretoria quer entender quais categorias têm melhor desempenho em cada mês.

**Tarefa:** Use LINQ para criar um relatório que mostre, para cada mês do último ano, a categoria com maior volume de vendas.

**Dica:** Este é um problema complexo que requer múltiplos joins, agrupamentos e subqueries.

**Resultado esperado:** Uma lista contendo, para cada mês, o nome do mês, a categoria mais vendida naquele mês e o total vendido.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestTopCategoryByMonth()
{
    // Execute sua consulta LINQ aqui
    // var result = ... sua solução do Desafio 11 ...
    
    // Validações
    // 1. Verificar a contagem total de meses
    Assert.AreEqual(12, result.Count(), "Deve haver dados para 12 meses");
    
    // 2. Verificar dados de meses específicos
    var januaryData = result.FirstOrDefault(r => r.Month == "Janeiro");
    Assert.IsNotNull(januaryData, "Janeiro deve estar presente nos resultados");
    Assert.AreEqual("Romance", januaryData.TopCategory, "A categoria mais vendida em Janeiro deve ser 'Romance'");
    Assert.AreEqual(145, januaryData.TotalSold, "Romance deve ter 145 unidades vendidas em Janeiro");
    
    var julyData = result.FirstOrDefault(r => r.Month == "Julho");
    Assert.IsNotNull(julyData, "Julho deve estar presente nos resultados");
    Assert.AreEqual("Ficção Científica", julyData.TopCategory, "A categoria mais vendida em Julho deve ser 'Ficção Científica'");
    Assert.AreEqual(187, julyData.TotalSold, "Ficção Científica deve ter 187 unidades vendidas em Julho");
    
    var decemberData = result.FirstOrDefault(r => r.Month == "Dezembro");
    Assert.IsNotNull(decemberData, "Dezembro deve estar presente nos resultados");
    Assert.AreEqual("Infantil", decemberData.TopCategory, "A categoria mais vendida em Dezembro deve ser 'Infantil'");
    Assert.AreEqual(210, decemberData.TotalSold, "Infantil deve ter 210 unidades vendidas em Dezembro");
    
    // 3. Verificar que não há meses duplicados
    var monthNames = result.Select(r => r.Month).ToList();
    Assert.AreEqual(monthNames.Count, monthNames.Distinct().Count(), "Não deve haver meses duplicados");
}
```

#### Desafio 12: Recomendação de livros

**Contexto de negócio:** Queremos implementar um sistema simples de recomendação que sugira livros com base nas compras anteriores dos clientes.

**Tarefa:** Para um cliente específico, encontre outros clientes que compraram os mesmos livros e, baseado nisso, recomende livros que o cliente original ainda não comprou.

**Dica:** Este problema envolve múltiplos joins e comparações de conjuntos.

#### Desafio 13: Análise de estoque vs vendas

**Contexto de negócio:** O gerente de estoque quer otimizar os níveis de estoque com base na velocidade de venda de cada livro.

**Tarefa:** Crie uma análise que compare o nível atual de estoque com a média mensal de vendas de cada livro, para identificar possíveis problemas de excesso ou falta de estoque.

**Dica:** Você precisará calcular a média de vendas mensais para cada livro e compará-la com o estoque atual.

#### Desafio 14: Clientes inativos

**Contexto de negócio:** A equipe de marketing quer reativar clientes que não fizeram compras recentemente.

**Tarefa:** Use LINQ para identificar todos os clientes que não fizeram compras nos últimos 6 meses, ordenados pelo tempo de inatividade.

**Dica:** Use uma técnica de left join para encontrar clientes sem vendas recentes.

**Resultado esperado:** Uma lista de clientes inativos, contendo nome, email e data da última compra (ou null se nunca comprou), ordenada do cliente mais inativo para o menos inativo.

**Orientações para teste:**
```csharp
[TestMethod]
public void TestInactiveCustomers()
{
    // Define uma data de referência para o teste (considere que "hoje" é esta data)
    var referenceDate = new DateTime(2023, 12, 31);
    
    // Execute sua consulta LINQ aqui, usando a data de referência
    // var result = ... sua solução do Desafio 14 com a referenceDate ...
    
    // Validações
    // 1. Verificar a contagem total
    Assert.AreEqual(15, result.Count(), "Deve haver 15 clientes inativos");
    
    // 2. Verificar o cliente mais inativo
    var mostInactive = result.First();
    Assert.AreEqual("Carlos Oliveira", mostInactive.Name, "O cliente mais inativo deve ser 'Carlos Oliveira'");
    Assert.IsNull(mostInactive.LastPurchaseDate, "Carlos Oliveira nunca fez uma compra");
    
    // 3. Verificar clientes específicos
    var anaLima = result.FirstOrDefault(c => c.Name == "Ana Lima");
    Assert.IsNotNull(anaLima, "Ana Lima deve estar na lista de inativos");
    Assert.AreEqual(new DateTime(2022, 8, 15), anaLima.LastPurchaseDate, "Ana Lima fez sua última compra em 15/08/2022");
    
    // 4. Verificar que clientes ativos não estão na lista
    var joaoSilva = result.FirstOrDefault(c => c.Name == "João Silva");
    Assert.IsNull(joaoSilva, "João Silva não deve estar na lista (cliente ativo)");
    
    // 5. Verificar ordenação pelo tempo de inatividade
    var resultList = result.ToList();
    for (int i = 0; i < resultList.Count - 1; i++)
    {
        var current = resultList[i].LastPurchaseDate;
        var next = resultList[i + 1].LastPurchaseDate;
        
        if (current == null)
        {
            continue; // Null (nunca comprou) sempre vem primeiro
        }
        else if (next != null)
        {
            Assert.IsTrue(current <= next, 
                "Os clientes devem estar ordenados do mais inativo para o menos inativo");
        }
    }
}
```

#### Desafio 15: Análise de popularidade por autor e categoria

**Contexto de negócio:** Para melhorar as recomendações e o layout da loja, queremos entender quais combinações de autor e categoria são mais populares.

**Tarefa:** Use LINQ para analisar a quantidade de vendas por combinação de autor e categoria, e liste as 10 combinações mais populares.

**Dica:** Você precisará fazer joins entre vendas, livros, autores e categorias, seguido de agrupamento e ordenação.

## Validando suas Soluções com Testes Unitários

Para garantir que suas soluções LINQ estão corretas, é importante criar testes unitários que validem o comportamento esperado. Aqui está um guia sobre como criar testes para os desafios:

### Configurando o Projeto de Testes

1. Adicione um projeto de testes à sua solução (MSTest, NUnit ou xUnit)
2. Adicione uma referência ao seu projeto principal
3. Crie uma classe de teste para cada nível ou grupo de desafios

### Estrutura Básica de Teste

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLearningProject.Tests
{
    [TestClass]
    public class LinqChallengesTests
    {
        // Dados de teste que serão utilizados em vários testes
        private List<Book> _testBooks;
        private List<Author> _testAuthors;
        private List<Category> _testCategories;
        private List<Customer> _testCustomers;
        private List<Sale> _testSales;
        
        [TestInitialize]
        public void Initialize()
        {
            // Configura dados de teste simplificados para cada entidade
            SetupTestData();
        }
        
        private void SetupTestData()
        {
            // Aqui você configuraria dados de teste realistas mas simplificados
            // que permitam validar todos os cenários necessários
            
            _testCategories = new List<Category>
            {
                new Category { Id = 1, Name = "Romance", Description = "Livros de romance" },
                new Category { Id = 2, Name = "Ficção Científica", Description = "Livros de ficção científica" },
                new Category { Id = 3, Name = "Infantil", Description = "Livros infantis" },
                // Adicionar mais categorias conforme necessário
            };
            
            _testAuthors = new List<Author>
            {
                new Author { 
                    Id = 1, 
                    Name = "Machado de Assis", 
                    Country = "Brasil",
                    BirthDate = new DateTime(1839, 6, 21),
                    Biography = "Importante escritor brasileiro"
                },
                new Author { 
                    Id = 2, 
                    Name = "J.K. Rowling", 
                    Country = "Reino Unido",
                    BirthDate = new DateTime(1965, 7, 31),
                    Biography = "Autora da série Harry Potter"
                },
                // Adicionar mais autores conforme necessário
            };
            
            // Configurar livros, clientes e vendas de forma similar
        }
        
        // Métodos de teste para cada desafio viriam aqui
    }
}
```

### Exemplo de Método de Teste Completo

```csharp
[TestMethod]
public void TestLowStockBooksByCategory()
{
    // Arrange - Preparar dados específicos para este teste, se necessário
    
    // Act - Executar a consulta LINQ que queremos testar
    var result = /* ... sua implementação do Desafio 4 ... */;
    
    // Assert - Verificar se os resultados estão corretos
    // 1. Verificar número de categorias que têm livros com estoque baixo
    Assert.AreEqual(2, result.Count(), "Deve haver 2 categorias com livros de estoque baixo");
    
    // 2. Verificar a categoria "Romance"
    var romanceGroup = result.FirstOrDefault(g => g.CategoryName == "Romance");
    Assert.IsNotNull(romanceGroup, "A categoria Romance deve estar presente nos resultados");
    Assert.AreEqual(3, romanceGroup.Books.Count(), "Romance deve ter 3 livros com estoque baixo");
    
    // 3. Verificar a ordenação dos livros na categoria "Romance"
    var romanceBooks = romanceGroup.Books.ToList();
    Assert.AreEqual("Dom Casmurro", romanceBooks[0].Title, "O primeiro livro deve ser Dom Casmurro");
    Assert.AreEqual(2, romanceBooks[0].Stock, "Dom Casmurro deve ter estoque = 2");
    Assert.AreEqual("O Cortiço", romanceBooks[1].Title, "O segundo livro deve ser O Cortiço");
    Assert.AreEqual(5, romanceBooks[1].Stock, "O Cortiço deve ter estoque = 5");
    
    // 4. Verificar que uma categoria está ausente
    Assert.IsFalse(result.Any(g => g.CategoryName == "Infantil"), 
        "A categoria Infantil não deve estar nos resultados (não tem livros com estoque baixo)");
}
```

### Framework de Testes Recomendados
- **MSTest**: Framework de teste integrado ao Visual Studio
- **NUnit**: Framework popular com grande comunidade
- **xUnit**: Framework moderno, utilizado pela equipe do .NET Core

### Instalação via NuGet
```
Install-Package MSTest.TestFramework
Install-Package MSTest.TestAdapter
```

## Recursos Adicionais

- [Documentação oficial do LINQ (Microsoft)](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/)
- [101 Exemplos de LINQ](https://linqsamples.com/)
- [LINQPad](https://www.linqpad.net/) - Uma ferramenta excelente para testar consultas LINQ
- [Testes Unitários no .NET Core](https://docs.microsoft.com/pt-br/dotnet/core/testing/)
- [Melhores Práticas para Testes Unitários](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)

## Conclusão

Parabéns por completar este projeto prático de aprendizado de LINQ em C#! Através dos desafios propostos e da validação com testes unitários, você desenvolveu habilidades práticas com uma ampla gama de operadores LINQ e viu como eles podem ser aplicados em cenários do mundo real para manipulação eficiente de dados.

O processo de validação através de testes é uma habilidade fundamental para qualquer desenvolvedor, e ajuda a garantir que suas consultas LINQ estão realmente produzindo os resultados esperados.

Lembre-se que LINQ é uma ferramenta poderosa, mas como qualquer ferramenta, deve ser usada adequadamente. Considere sempre o desempenho e a legibilidade ao escrever consultas LINQ em seus projetos reais.

Bom aprendizado!{
                new Book { Id = 1, Title = "Livro Barato", Price = 29.99m, CategoryId = 1, Stock = 15 },
                new Book { Id = 2, Title = "Livro Médio", Price = 35.00m, CategoryId = 2, Stock = 8 },
                new Book { Id = 3, Title = "Livro Caro", Price = 45.99m, CategoryId = 1, Stock = 5 }
            };
            
            _testCategories = new List<Category>
            {
                new Category { Id = 1, Name = "Ficção" },
                new Category { Id = 2, Name = "Não-Ficção" }
            };
        }
        
        [TestMethod]
        public void TestExpensiveBooks()
        {
            // Execute sua solução para o Desafio 1
            // Por exemplo:
            var result = _testBooks
                .Where(book => book.Price > 35.0m)
                .Select(book => new { book.Title, book.Price, book.CategoryId })
                .ToList();
                
            // Valide os resultados
            Assert.AreEqual(1, result.Count, "Deve encontrar apenas um livro com preço > 35.0");
            Assert.AreEqual("Livro Caro", result[0].Title);
            Assert.AreEqual(45.99m, result[0].Price);
            Assert.AreEqual(1, result[0].CategoryId);
        }
    }
}
```

### O que Testar em Cada Desafio

Para cada desafio, seus testes unitários devem verificar:

1. **Contagem de resultados**: O número de itens retornados está correto?
2. **Condições do filtro**: Os itens retornados atendem aos critérios estabelecidos?
3. **Ordenação**: Os itens estão na ordem correta quando aplicável?
4. **Agrupamento**: Os grupos foram formados corretamente?
5. **Cálculos**: Os valores calculados (soma, média, etc.) estão corretos?

### Dicas para Testes Eficazes

- Use dados de teste simplificados mas representativos
- Verifique valores específicos, não apenas condições gerais
- Adicione testes para casos de borda (coleções vazias, valores nulos)
- Nas operações de agrupamento, verifique tanto o número de grupos quanto seu conteúdo

Crie testes específicos para cada um dos 15 desafios, adaptando as validações aos requisitos específicos de cada um.

## Recursos para Testes Unitários

### Framework de Testes Recomendados
- **MSTest**: Framework de teste integrado ao Visual Studio
- **NUnit**: Framework popular com grande comunidade
- **xUnit**: Framework moderno, utilizado pela equipe do .NET Core

### Instalação via NuGet
```
Install-Package MSTest.TestFramework
Install-Package MSTest.TestAdapter
```

### Exemplo Completo de Teste para o Desafio 3 (Estoque Baixo)

```csharp
[TestClass]
public class StockAnalysisTests
{
    private List<Book> _books;
    private List<Category> _categories;
    
    [TestInitialize]
    public void Setup()
    {
        _books = new List<Book>
        {
            new Book { Id = 1, Title = "Livro A", CategoryId = 1, Stock = 5 },
            new Book { Id = 2, Title = "Livro B", CategoryId = 1, Stock = 12 },
            new Book { Id = 3, Title = "Livro C", CategoryId = 2, Stock = 8 },
            new Book { Id = 4, Title = "Livro D", CategoryId = 2, Stock = 3 },
            new Book { Id = 5, Title = "Livro E", CategoryId = 3, Stock = 15 }
        };
        
        _categories = new List<Category>
        {
            new Category { Id = 1, Name = "Ficção" },
            new Category { Id = 2, Name = "Não-Ficção" },
            new Category { Id = 3, Name = "Infantil" }
        };
    }
    
    [TestMethod]
    public void TestLowStockBooks()
    {
        // Execute sua consulta LINQ aqui
        // var result = ... sua consulta LINQ para o Desafio 3
        
        // Validações que devem passar:
        
        // 1. Deve haver 2 categorias com livros de estoque baixo
        Assert.AreEqual(2, result.Count());
        
        // 2. A categoria "Ficção" deve ter 1 livro com estoque baixo
        var ficcaoGroup = result.FirstOrDefault(g => g.Key == "Ficção");
        Assert.IsNotNull(ficcaoGroup);
        Assert.AreEqual(1, ficcaoGroup.Books.Count());
        Assert.AreEqual("Livro A", ficcaoGroup.Books.First().Title);
        
        // 3. A categoria "Não-Ficção" deve ter 2 livros com estoque baixo
        var naoFiccaoGroup = result.FirstOrDefault(g => g.Key == "Não-Ficção");
        Assert.IsNotNull(naoFiccaoGroup);
        Assert.AreEqual(2, naoFiccaoGroup.Books.Count());
        
        // 4. Os livros em cada grupo devem estar ordenados por estoque (ascendente)
        var naoFiccaoBooks = naoFiccaoGroup.Books.ToList();
        Assert.AreEqual("Livro D", naoFiccaoBooks[0].Title); // 3 unidades
        Assert.AreEqual("Livro C", naoFiccaoBooks[1].Title); // 8 unidades
    }
}
```

## Conclusão

Parabéns por completar este projeto prático de aprendizado de LINQ em C#! Ao resolver os desafios e criar testes unitários para validar suas soluções, você desenvolveu experiência com uma ampla gama de operadores LINQ e viu como eles podem ser aplicados em cenários do mundo real para manipulação eficiente de dados.

O processo de validação através de testes é uma habilidade fundamental para qualquer desenvolvedor, e ajuda a garantir que suas consultas LINQ estão realmente produzindo os resultados esperados.

Lembre-se que LINQ é uma ferramenta poderosa, mas como qualquer ferramenta, deve ser usada adequadamente. Considere sempre o desempenho e a legibilidade ao escrever consultas LINQ em seus projetos reais.

## Recursos Adicionais

- [Documentação oficial do LINQ (Microsoft)](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/)
- [101 Exemplos de LINQ](https://linqsamples.com/)
- [LINQPad](https://www.linqpad.net/) - Uma ferramenta excelente para testar consultas LINQ
- [Testes Unitários no .NET Core](https://docs.microsoft.com/pt-br/dotnet/core/testing/)
- [Melhores Práticas para Testes Unitários](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)

Bom aprendizado!