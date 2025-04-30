# Estudo de LINQ em C#

## Sobre este projeto

Este é um projeto de estudo sobre Language Integrated Query (LINQ) em C#. O LINQ é uma poderosa ferramenta de consulta que permite manipular dados de várias fontes (coleções, XML, SQL, etc.) de forma unificada e tipo-segura.

O projeto simula um sistema de gerenciamento para uma livraria online chamada "BookVerse", permitindo aplicar LINQ em cenários realistas.

## Estrutura do Projeto

```
LINQ/
├── README.md
├── Program.cs              # Ponto de entrada da aplicação
├── Data/                   # Diretório com dados em JSON
│   ├── books.json
│   ├── authors.json
│   ├── categories.json
│   ├── customers.json
│   └── sales.json
├── Models/                 # Classes de modelo para os dados
│   ├── Book.cs
│   ├── Author.cs
│   ├── Category.cs
│   ├── Customer.cs
│   └── Sale.cs
├── Challenges/             # Desafios de LINQ organizados por nível
│   ├── Level1/             # Fundamentos
│   ├── Level2/             # Intermediário
│   └── Level3/             # Avançado
└── Tests/                  # Testes unitários para validar soluções
    ├── Level1Tests.cs
    ├── Level2Tests.cs
    └── Level3Tests.cs
```

## Plano de Estudo

Este projeto segue um plano de estudo estruturado para LINQ:

### Nível 1: Fundamentos
- Filtrar dados com `Where`
- Projetar dados com `Select`
- Calcular valores com operadores de agregação (`Sum`, `Count`, etc.)
- Combinar dados com operações simples de `Join`

### Nível 2: Intermediário
- Agrupar dados com `GroupBy`
- Ordenar dados com `OrderBy` e `OrderByDescending`
- Calcular estatísticas com operadores de agregação avançados
- Limitar resultados com `Take` e `Skip`

### Nível 3: Avançado
- Consultas complexas combinando múltiplos operadores
- Junções avançadas entre conjuntos de dados
- Análises de dados com agrupamentos e subqueries
- Manipulações de conjuntos com `Union`, `Intersect`, etc.

## Como começar

1. Clone o repositório
2. Abra a solução no Visual Studio ou editor de sua preferência
3. Implemente os modelos em `Models/`
4. Analise os arquivos JSON em `Data/`
5. Siga os desafios em ordem progressiva em `Challenges/`
6. Valide suas soluções com os testes em `Tests/`

## Desafios

O projeto contém 15 desafios organizados em 3 níveis de dificuldade:

- **Nível 1 (Fundamentos)**: Desafios 1-5
- **Nível 2 (Intermediário)**: Desafios 6-10
- **Nível 3 (Avançado)**: Desafios 11-15

Cada desafio possui:
- Contexto de negócio
- Tarefa a ser realizada com LINQ
- Dicas para resolução
- Resultados esperados
- Orientações para teste

## Recursos adicionais

- [Documentação oficial do LINQ (Microsoft)](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/)
- [101 Exemplos de LINQ](https://linqsamples.com/)
- [LINQPad](https://www.linqpad.net/) - Uma ferramenta para testar consultas LINQ
- [Testes Unitários no .NET Core](https://docs.microsoft.com/pt-br/dotnet/core/testing/)

## Considerações finais

LINQ é uma ferramenta poderosa, mas deve ser usada adequadamente. Sempre considere o desempenho e a legibilidade ao escrever consultas LINQ em projetos reais. 