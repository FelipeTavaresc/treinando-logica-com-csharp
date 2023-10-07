﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Exercício 01
// int valorA = int.Parse(Console.ReadLine());
// int valorB = int.Parse(Console.ReadLine());
// int soma = valorA + valorB;
// Console.WriteLine($"SOMA = {soma}");

//Exercício 02
// double pi = 3.14159;
// double raio = double.Parse(Console.ReadLine());
// double area = pi * raio * raio;
// Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

//Exercício 03
// int a, b, c, d;
// a = int.Parse(Console.ReadLine());
// b = int.Parse(Console.ReadLine());
// c = int.Parse(Console.ReadLine());
// d = int.Parse(Console.ReadLine());
// int diff = (a * b - c * d);
// Console.WriteLine($"DIFERENÇA = {diff}");

//Exercício 04
// int numeroFuncionario = int.Parse(Console.ReadLine());
// int horasTrabalhadas = int.Parse(Console.ReadLine());
// double valorHora = double.Parse(Console.ReadLine());
// double salario = horasTrabalhadas * valorHora;
// Console.WriteLine($"NUMBER = {numeroFuncionario}");
// Console.WriteLine($"SALARY = U${salario:F2}");

//Exercício 05
// string[] linha1 = Console.ReadLine().Split(' ');
// int codigoPeca1 = int.Parse(linha1[0]);
// int quantidadePecas1 = int.Parse(linha1[1]);
// double valorUnitarioPeca1 = double.Parse(linha1[2]);
// Console.WriteLine(valorUnitarioPeca1);

// string[] linha2 = Console.ReadLine().Split(' ');
// int codigoPeca2 = int.Parse(linha2[0]);
// int quantidadePecas2 = int.Parse(linha2[1]);
// double valorUnitarioPeca2 = double.Parse(linha2[2]);
// Console.WriteLine(valorUnitarioPeca2);

// double valorAPagar = (quantidadePecas1 * valorUnitarioPeca1) + (quantidadePecas2 * valorUnitarioPeca2);
// Console.WriteLine(valorAPagar);
// Console.WriteLine($"VALOR A PAGAR R$ {valorAPagar.ToString("F2")}");

//Exercício 06
double a, b, c;
double pi = 3.14159;
string[] valoresTriangulo = Console.ReadLine().Split(' ');
a = double.Parse(valoresTriangulo[0]);
b = double.Parse(valoresTriangulo[1]);
c = double.Parse(valoresTriangulo[2]);

double areaTriangulo = (a * c ) / 2;
double areaCirculo = pi * c * c;
double areaTrapezio = ((a + b ) * c) / 2;
double areaQuadrado = b * b;
double areaRetangulo = a * b;
Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");