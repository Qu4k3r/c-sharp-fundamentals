# Passo a Passo: Criando Testes Unitários em C# para Estudos de LINQ

Este guia mostra como adicionar e estruturar testes unitários no seu projeto de estudos de LINQ, utilizando o framework xUnit.

---

## 1. Pré-requisitos
- Projeto principal já criado (veja o passo a passo anterior).
- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

---

## 2. Criar um Projeto de Testes
No terminal, na raiz do seu projeto, execute:

```bash
dotnet new xunit -n LINQ.Tests
```

Isso criará uma pasta chamada `LINQ.Tests` com a estrutura básica de testes.

---

## 3. Adicionar Referência ao Projeto Principal
Ainda na raiz, execute:

```bash
dotnet add LINQ.Tests reference LINQ
```

Assim, os testes poderão acessar o código do seu projeto principal.

---

## 4. Estrutura Sugerida para os Testes
- Crie um arquivo de teste para cada assunto do seu plano de estudo, por exemplo:
  - `TestSelectWhere.cs` para testes de Select/Where
  - `TestOrderByGroupBy.cs` para testes de ordenação e agrupamento
  - `TestAgregacoes.cs` para testes de agregações
  - E assim por diante...

---

## 5. Exemplo de Teste Unitário com xUnit
```csharp
using Xunit;
using System.Linq;

public class TestSelectWhere
{
    [Fact]
    public void Where_DeveFiltrarElementosCorretamente()
    {
        // Arrange
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Act
        var pares = numeros.Where(n => n % 2 == 0).ToArray();

        // Assert
        Assert.Equal(new[] { 2, 4 }, pares);
    }
}
```

---

## 6. Executar os Testes
No terminal, dentro da raiz do projeto, execute:

```bash
dotnet test
```

O .NET irá compilar e rodar todos os testes, mostrando o resultado no terminal.

---

## 7. Dicas
- Crie métodos de teste pequenos e focados em um único comportamento.
- Nomeie os métodos de teste de forma descritiva.
- Consulte a documentação do [xUnit](https://xunit.net/docs/getting-started/netcore/cmdline) para mais exemplos e recursos. 