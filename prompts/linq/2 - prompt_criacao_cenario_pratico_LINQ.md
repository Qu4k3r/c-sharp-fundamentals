# Prompt para Criação de Cenário Prático de Aprendizado LINQ em C#

## Contexto
Você deve criar um cenário prático de uso real para que desenvolvedores possam aprender LINQ em C# de forma aplicada. O cenário deve permitir o aprendizado progressivo dos conceitos de LINQ seguindo um plano de estudos estruturado.

## Instruções Gerais

1. **Crie um cenário de negócio realista** onde o uso de LINQ para manipulação de dados seja adequado e natural
2. **Não utilize banco de dados** - os dados devem ser fornecidos como arquivos .JSON ou .CSV dentro do projeto
3. **Gere dados fictícios** adequados ao contexto do cenário
4. **Forneça um passo a passo** de tarefas a serem executadas pelo aprendiz para resolver problemas usando LINQ
5. **Estruture o cenário progressivamente**, começando com operações básicas e avançando para consultas mais complexas

## Requisitos para o Cenário

### Dados e Contexto
- Crie um cenário de negócio envolvendo pelo menos 3-4 entidades relacionadas (ex: Produtos, Categorias, Clientes, Pedidos)
- Gere modelos de dados (classes) que representem essas entidades
- Prepare de 2 a 4 arquivos .JSON ou .CSV com dados fictícios realistas (mínimo 30-50 registros em cada arquivo)
- Forneça código de carregamento dos dados em coleções C# para manipulação com LINQ

### Problemas e Desafios
Desenvolva de 15 a 20 problemas/desafios que o aprendiz deve resolver usando LINQ, organizados nos seguintes níveis:

#### Nível 1: Fundamentos (5-6 problemas)
- Problemas envolvendo `Select` e `Where` para consultas básicas
- Filtragem de dados com critérios simples
- Projeção de dados em novos formatos
- Exemplos de conversão entre sintaxe de método e sintaxe de consulta

#### Nível 2: Intermediário (5-6 problemas)
- Ordenação com `OrderBy` e `OrderByDescending`
- Agrupamento com `GroupBy`
- Operações de agregação como `Count`, `Sum`, `Average`, `Min`, `Max`
- Trabalho com tipos anônimos para resultados personalizados

#### Nível 3: Avançado (5-8 problemas)
- Junções entre conjuntos de dados usando `Join` e `GroupJoin`
- Consultas aninhadas e subqueries
- Combinações de múltiplos operadores LINQ
- Cenários que representem desafios reais de processamento de dados
- Uso de LINQ com XML (opcional)

### Estrutura do Material Final
Para cada desafio proposto, inclua:

1. **Descrição do problema de negócio** a ser resolvido
2. **Dica inicial** com orientação para a abordagem recomendada (sem fornecer a solução completa)
3. **Resultado esperado** descrevendo o formato e tipo de dados que devem ser retornados
4. **Orientações para validação** explicando como o aprendiz pode verificar se sua solução está correta

## Exemplo de Formato para os Desafios

```
### Desafio 3: Encontrar produtos com estoque baixo por categoria

**Contexto de negócio:** O gerente de estoque precisa identificar rapidamente quais produtos estão com níveis críticos de estoque, agrupados por categoria, para priorizar novas compras.

**Tarefa:** Crie uma consulta LINQ que encontre todos os produtos com estoque abaixo de 10 unidades, agrupados por categoria, e ordenados por quantidade disponível (do menor para o maior).

**Dica:** Considere usar uma combinação de Where, GroupBy e OrderBy.

**Resultado esperado:** Uma listagem de categorias e seus respectivos produtos com estoque baixo, retornando para cada grupo o nome da categoria e uma coleção dos produtos com estoque crítico.

**Validação:** Crie um teste unitário que verifique se:
1. Apenas produtos com estoque menor que 10 foram incluídos
2. Os produtos estão corretamente agrupados por categoria
3. Em cada grupo, os produtos estão ordenados por quantidade em estoque (ascendente)
4. O teste deve verificar especificamente alguns valores conhecidos nos dados de exemplo
```

## Testes Unitários

Inclua uma seção dedicada a orientar o aprendiz sobre como criar testes unitários para validar as soluções LINQ. Para cada desafio, forneça orientações específicas de teste com:

1. **Framework de teste recomendado:** Sugira o uso de MSTest, NUnit ou xUnit
2. **Estrutura básica dos testes:** Forneça um template de classe de teste para os desafios
3. **Critérios de validação específicos para cada desafio**, incluindo:
   - Contagem esperada de resultados (baseada nos dados de exemplo)
   - Exemplos específicos de registros que devem estar nos resultados
   - Valores de agregação específicos (soma, média, etc.) que devem ser verificados
   - Ordem esperada dos resultados (quando aplicável)
   - Composição esperada dos grupos (quando aplicável)

Exemplo do formato esperado para as instruções de teste:

```
### Teste para Desafio 3: Encontrar livros com estoque baixo por categoria

**O que testar:**
1. **Contagem esperada**: Devem existir 3 categorias com livros de estoque baixo
2. **Validação da categoria "Ficção"**:
   - Deve conter 5 livros com estoque baixo
   - O primeiro livro deve ser "Título X" com estoque = 2
   - O último livro deve ser "Título Y" com estoque = 9
3. **Validação da ordenação**: 
   - Na categoria "Não-Ficção", verifique se "Livro A" (estoque = 3) aparece antes de "Livro B" (estoque = 7)
4. **Casos especiais**:
   - A categoria "Infantil" não deve aparecer nos resultados (não tem livros com estoque baixo)
```

Crie instruções de teste semelhantes para cada um dos desafios propostos, com valores concretos baseados nos dados fictícios que serão gerados.

### Configuração de Testes

Inclua também orientações sobre:
- Como configurar o ambiente de testes
- Como criar dados de teste representativos mas simplificados 
- Como usar Arrange-Act-Assert para estruturar os testes
- Como lidar com casos de borda (listas vazias, valores nulos, etc.)

Forneça pelo menos um exemplo completo de classe de teste para um dos desafios básicos, que o aprendiz possa usar como referência.

## Observações Adicionais
- Sugira a utilização do Visual Studio Community Edition ou LINQPad para executar os exercícios
- Mencione recursos para aprofundamento (documentação Microsoft, tutoriais recomendados)
- Explique como avaliar o desempenho das consultas LINQ em casos relevantes
- Destaque as vantagens de usar LINQ comparado a abordagens tradicionais em cada problema
- Incentive o uso de ambas as sintaxes (Query e Method) para melhor compreensão

Lembre-se que o objetivo final é criar um material prático que ajude desenvolvedores a dominar LINQ através da aplicação em cenários do mundo real, seguindo uma progressão lógica de aprendizado, sem fornecer as soluções prontas, mas dando todas as ferramentas necessárias para o aprendiz resolver os problemas e validar seu próprio progresso através de testes unitários.