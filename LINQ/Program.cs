// Estudo de LINQ em C# - BookVerse
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using LINQ.DTO;
using LINQ.Models;
using static LINQ.Challenges.Level1.Challenges;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== BookVerse - Estudo de LINQ ==");

            // Corrigido: caminho relativo para books.json a partir do diretório do projeto LINQ
            List<Book> books = LoadData<Book>(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "books.json"));
            Console.WriteLine("Total books: " + books.Count);

            // authors
            List<Author> authors = LoadData<Author>(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "authors.json"));
            Console.WriteLine("Total authors: " + authors.Count);

            // categories
            List<Category> categories = LoadData<Category>(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "categories.json"));
            Console.WriteLine("Total categories: " + categories.Count);

            // customers
            List<Customer> customers = LoadData<Customer>(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "customers.json"));
            Console.WriteLine("Total customers: " + customers.Count);

            // sales
            List<Author> sales = LoadData<Author>(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "sales.json"));
            Console.WriteLine("Total sales: " + sales.Count);


            // Escolha um nível para trabalhar ou comente/descomente conforme necessário
            RunLevel1Challenges(books);
            // RunLevel2Challenges();
            // RunLevel3Challenges();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        // TODO: Implemente métodos para carregar dados JSON
        static List<T> LoadData<T>(string filename)
        {
            // Verifica se o arquivo existe
            if (!File.Exists(filename))
            {
                throw new Exception($"Erro: O arquivo {filename} não foi encontrado.");
            }

            // Lê todo o conteúdo do arquivo
            string jsonString = File.ReadAllText(filename);

            // Desserializa o JSON para uma lista de objetos do tipo T
            List<T>? items = JsonSerializer.Deserialize<List<T>>(jsonString);
            // Verifica se a lista desserializada é nula ou vazia
            if (items == null || items.Count < 1)
            {
                throw new Exception($"Erro: Nenhum dado foi carregado do arquivo {filename}.");
            }

            return items;
        }

        static void RunLevel1Challenges(List<Book> books)
        {
            Console.WriteLine("\n=== Nível 1: Fundamentos ===\n");
            List<ExpensiveBookDTO> expensiveBooks = GetExpensiveBooks(books);

            expensiveBooks.ForEach(book => Console.WriteLine($"{book.Title}: R$ {book.Price}. Category: {book.CategoryId}"));
        }

        // static void RunLevel2Challenges()
        // {
        //     Console.WriteLine("\n=== Nível 2: Intermediário ===\n");

        //     // Implemente os desafios do Nível 2 aqui
        // }

        // static void RunLevel3Challenges()
        // {
        //     Console.WriteLine("\n=== Nível 3: Avançado ===\n");

        //     // Implemente os desafios do Nível 3 aqui
        // }
    }
}
