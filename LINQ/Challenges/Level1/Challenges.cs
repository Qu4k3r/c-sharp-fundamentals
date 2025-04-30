using System;
using System.Collections.Generic;
using System.Linq;
using LINQ.Models;
using LINQ.DTO;

namespace LINQ.Challenges.Level1
{
    // Esta classe contém os desafios do Nível 1 (Fundamentos)
    public class Challenges
    {
        /*
         * Desafio 1: Listar livros com preço acima de um determinado valor
         * 
         * Contexto de negócio: A equipe de marketing quer criar uma promoção especial 
         * para livros premium e precisa de uma lista de todos os livros com preço acima de R$35,00.
         *
         * Tarefa: Use LINQ para filtrar e retornar todos os livros com preço superior a R$35,00. 
         * Mostre o título, preço e ID da categoria.
         */
        public static List<ExpensiveBookDTO> GetExpensiveBooks(List<Book> books)
        {
            return [.. books
                .Where(book => book.Price > 35)
                .Select(book => new ExpensiveBookDTO{
                    Title = book.Title,
                    Price = book.Price,
                    CategoryId = book.CategoryId,
                })];
        }

        /*
         * Desafio 2: Encontrar autores de um determinado país
         * 
         * Contexto de negócio: Para um evento literário focado em autores brasileiros, 
         * precisamos identificar todos os autores do Brasil.
         *
         * Tarefa: Use LINQ para encontrar todos os autores do Brasil e retornar seus 
         * nomes e datas de nascimento, ordenados alfabeticamente.
         */
        public static List<AuthorDTO> GetAuthorsByCountry(List<Author> authors, string country)
        {
            throw new Exception("Not implemented yet");
        }

        /*
         * Desafio 3: Calcular o valor total do estoque
         * 
         * Contexto de negócio: O departamento financeiro precisa fazer um balanço do 
         * valor total em livros no estoque.
         *
         * Tarefa: Use LINQ para calcular o valor total do estoque (preço × quantidade em 
         * estoque para cada livro).
         */
        public static decimal GetTotalStockValue(List<Book> books)
        {
            throw new Exception("Not implemented yet");
        }

        /*
         * Desafio 4: Encontrar livros com estoque baixo
         * 
         * Contexto de negócio: O gerente de estoque precisa identificar quais livros 
         * precisam ser reabastecidos.
         *
         * Tarefa: Use LINQ para listar todos os livros com estoque menor que 10 unidades, 
         * mostrando o título, estoque atual e categoria.
         */
        public static List<LowStockBookDTO> GetLowStockBooks(List<Book> books, List<Category> categories)
        {
            throw new Exception("Not implemented yet");
        }

        /*
         * Desafio 5: Listar vendas recentes
         * 
         * Contexto de negócio: O time de vendas precisa analisar as vendas do último mês.
         *
         * Tarefa: Use LINQ para listar todas as vendas dos últimos 30 dias, mostrando o 
         * título do livro vendido, data da venda e quantidade.
         */
        public static List<RecentSaleDTO> GetRecentSales(List<Sale> sales, List<Book> books, DateTime referenceDate)
        {
            throw new Exception("Not implemented yet");
        }
    }
}