# Desafio Técnico Morada.ai: Caixa Eletrônico API

Este projeto foi desenvolvido como parte de um desafio técnico, onde o objetivo é calcular a menor quantidade de cédulas necessárias para um determinado valor de saque.

## Descrição

O programa consiste em um método que recebe um valor de saque e calcula a menor combinação de cédulas de R$100, R$50, R$20, R$10, R$5 e R$2 que soma exatamente o valor do saque. O resultado é retornado em formato JSON, mostrando quantas cédulas de cada valor foram utilizadas.

## Principais Desafios

O principal desafio deste projeto foi implementar a lógica utilizando recursividade para encontrar todas as combinações possíveis de cédulas.

## Tecnologias Utilizadas

- ASP.NET Web API: Framework utilizado para construir a API que realiza o cálculo das cédulas.
- C#: Linguagem de programação utilizada para implementar a lógica de cálculo das cédulas.
- Visual Studio (ou Visual Studio Code): IDEs utilizadas para desenvolver e testar o projeto.
  
## Instruções para Executar o Projeto

Para executar o projeto localmente, siga os passos abaixo:

1. Clone este repositório para o seu ambiente local.
   
2. Abra o projeto em sua IDE preferida (por exemplo, Visual Studio, Visual Studio Code).
   
3. Verifique se você tem suporte para executar projetos ASP.NET Web API na sua máquina local. Caso não tenha o suporte instalado, você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
   
4. Compile e execute o projeto.

5. Para calcular as cédulas necessárias para um determinado valor de saque, faça uma requisição para o endpoint https://localhost:7297/api/CaixaEletronico do Swagger UI.

![image](https://github.com/Davidsb04/CaixaEletronico/assets/121972361/be4ab12a-b6c4-4641-97df-d1893a97fe68)
