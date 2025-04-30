using System;
using System.Collections.Generic;
using System.Linq;
using LINQ.Models;

namespace LINQ.Challenges.Level3
{
    // Esta classe contém os desafios do Nível 3 (Avançado)
    public class Challenges
    {
        /*
         * Desafio 11: Análise de vendas por categoria e mês
         * 
         * Contexto de negócio: A diretoria quer entender quais categorias têm melhor 
         * desempenho em cada mês.
         *
         * Tarefa: Use LINQ para criar um relatório que mostre, para cada mês do último ano, 
         * a categoria com maior volume de vendas.
         * 
         * TODO: Implemente o método abaixo:
         */
        
        // public static IEnumerable<object> GetTopCategoryByMonth(
        //     List<Sale> sales, 
        //     List<Book> books, 
        //     List<Category> categories, 
        //     int year)
        // {
        //     // Sua implementação LINQ aqui
        // }

        /*
         * Desafio 12: Recomendação de livros
         * 
         * Contexto de negócio: Queremos implementar um sistema simples de recomendação 
         * que sugira livros com base nas compras anteriores dos clientes.
         *
         * Tarefa: Para um cliente específico, encontre outros clientes que compraram os 
         * mesmos livros e, baseado nisso, recomende livros que o cliente original ainda não comprou.
         * 
         * TODO: Implemente o método abaixo:
         */
        
        // public static IEnumerable<Book> GetBookRecommendations(
        //     int customerId, 
        //     List<Sale> sales, 
        //     List<Book> books, 
        //     int maxRecommendations = 5)
        // {
        //     // Sua implementação LINQ aqui
        // }

        /*
         * Desafio 13: Análise de estoque vs vendas
         * 
         * Contexto de negócio: O gerente de estoque quer otimizar os níveis de estoque 
         * com base na velocidade de venda de cada livro.
         *
         * Tarefa: Crie uma análise que compare o nível atual de estoque com a média mensal 
         * de vendas de cada livro, para identificar possíveis problemas de excesso ou falta de estoque.
         * 
         * TODO: Implemente o método abaixo:
         */
        
        // public static IEnumerable<object> AnalyzeStockVsSales(
        //     List<Book> books, 
        //     List<Sale> sales, 
        //     int lookbackMonths = 6)
        // {
        //     // Sua implementação LINQ aqui
        // }

        /*
         * Desafio 14: Clientes inativos
         * 
         * Contexto de negócio: A equipe de marketing quer reativar clientes que não 
         * fizeram compras recentemente.
         *
         * Tarefa: Use LINQ para identificar todos os clientes que não fizeram compras 
         * nos últimos 6 meses, ordenados pelo tempo de inatividade.
         * 
         * TODO: Implemente o método abaixo:
         */
        
        // public static IEnumerable<object> GetInactiveCustomers(
        //     List<Customer> customers, 
        //     List<Sale> sales, 
        //     DateTime referenceDate, 
        //     int inactiveMonths = 6)
        // {
        //     // Sua implementação LINQ aqui
        // }

        /*
         * Desafio 15: Análise de popularidade por autor e categoria
         * 
         * Contexto de negócio: Para melhorar as recomendações e o layout da loja, 
         * queremos entender quais combinações de autor e categoria são mais populares.
         *
         * Tarefa: Use LINQ para analisar a quantidade de vendas por combinação de autor 
         * e categoria, e liste as 10 combinações mais populares.
         * 
         * TODO: Implemente o método abaixo:
         */
        
        // public static IEnumerable<object> GetPopularAuthorCategoryPairs(
        //     List<Sale> sales, 
        //     List<Book> books, 
        //     List<Author> authors, 
        //     List<Category> categories, 
        //     int topCount = 10)
        // {
        //     // Sua implementação LINQ aqui
        // }
    }
} 