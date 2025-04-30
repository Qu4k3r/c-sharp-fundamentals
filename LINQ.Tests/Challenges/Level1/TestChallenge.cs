using System;
using System.Collections.Generic;
using System.Linq;
using LINQ.Models;
using static LINQ.Challenges.Level1.Challenges;
using Xunit;

namespace LINQ.Tests.Challenges.Level1
{
    // xUnit não precisa de anotação para a classe de teste
    public class TestChallenge
    {
        // Dados de teste que serão utilizados em vários testes
        private readonly List<Book> _books;
        private readonly List<Author> _authors;
        private readonly List<Category> _categories;
        private readonly List<Customer> _customers;
        private readonly List<Sale> _sales;

        // Em xUnit, o construtor serve como método de inicialização
        public TestChallenge()
        {
            // Configure os dados de teste
            throw new Exception("Not implemented yet");
        }

        // Exemplo de teste para o Desafio 1
        [Fact]
        public void TestExpensiveBooks()
        {
            throw new Exception("Not implemented yet");
        }

        // Exemplo de teste para o Desafio 2
        [Fact]
        public void TestBrazilianAuthors()
        {
            throw new Exception("Not implemented yet");
        }

        // Teste para o Desafio 3
        [Fact]
        public void TestTotalStockValue()
        {
            throw new Exception("Not implemented yet");
        }

        // Teste para o Desafio 4
        [Fact]
        public void TestLowStockBooks()
        {
            throw new Exception("Not implemented yet");
        }

        // Teste para o Desafio 5
        [Fact]
        public void TestRecentSales()
        {
            throw new Exception("Not implemented yet");
        }
    }
}