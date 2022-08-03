

using ConsoleApp3;
using ConsoleApp3.basicas;

Console.WriteLine("Olá, Boas Vindas ao Programa Calculador!\n\n");
Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor da Soma é: " + operacoes.Soma.Calcular(10, 10));
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("O valor da Subtração é: " + operacoes.Subtracao.Calcular(30, 15));
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("O valor da Divisão é: " + operacoes.Divisao.Calcular(657, 98));
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("O valor da Multiplicaçção é: " + operacoes.Multiplicacao.Calcular(9, 48));
Console.WriteLine("-------------------------------------------------------");

Console.ReadKey();