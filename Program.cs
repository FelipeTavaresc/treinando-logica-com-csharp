// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Exercícios 01
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
//double a, b, c;
//double pi = 3.14159;
//string[] valoresTriangulo = Console.ReadLine().Split(' ');
//a = double.Parse(valoresTriangulo[0]);
//b = double.Parse(valoresTriangulo[1]);
//c = double.Parse(valoresTriangulo[2]);

//double areaTriangulo = (a * c ) / 2;
//double areaCirculo = pi * c * c;
//double areaTrapezio = ((a + b ) * c) / 2;
//double areaQuadrado = b * b;
//double areaRetangulo = a * b;
//Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
//Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
//Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
//Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
//Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");

//Exercícios 02 estrutura condicional

//Exercício 01 - Pula
//Exercício 02 - Pula

//Exercício 03
//int a, b;
//string[] valores = Console.ReadLine().Split(' ');
//a = int.Parse(valores[0]);
//b = int.Parse(valores[1]);

//if (a % b == 0 || b % a == 0)
//    Console.WriteLine("São Multiplos");
//else
//    Console.WriteLine("Não são Multiplos");

//Exercício 04
//int inicio, fim, duracao;
//string[] valores = Console.ReadLine().Split(' ');
//inicio = int.Parse(valores[0]);
//fim = int.Parse(valores[1]);

//if (inicio < fim)
//    duracao = (fim - inicio);
//else
//    duracao = 24 - inicio + fim;
//Console.WriteLine($"O JOGO DUROU {duracao} HORAS");

//Exercício 05
//int itemCodigo, quantidade;
//double total;
//string[] input = Console.ReadLine().Split(' ');
//itemCodigo = int.Parse(input[0]);
//quantidade = int.Parse(input[1]);

//if (itemCodigo == 1)
//    total = quantidade * 4.00;
//else if (itemCodigo == 2)
//    total = quantidade * 4.50;
//else if (itemCodigo == 3)
//    total = quantidade * 5.00;
//else if (itemCodigo == 4)
//    total = quantidade * 2.00;
//else if (itemCodigo == 5)
//    total = quantidade * 2.00;
//else if (itemCodigo == 6)
//    total = quantidade * 1.50;
//else
//    total = quantidade * 0;

//Console.WriteLine($"Total: R$ {total.ToString("F2")}");

//Exercício 06
//double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//if (valor > 0 && valor <= 25)
//    Console.WriteLine("Intervalor [0,25]");
//else if (valor > 25 && valor <= 50)
//    Console.WriteLine("Intervalor (25,50]");
//else if (valor > 50 && valor <= 75)
//    Console.WriteLine("Intervalor (50,75]");
//else if (valor > 75 && valor <= 100)
//    Console.WriteLine("Intervalor (75,100]");
//else
//    Console.WriteLine("Fora de intervalor");

//Exercício 07
string[] coordenadas = Console.ReadLine().Split(' ');
double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

if (x == 0.0 && y == 0.0)
    Console.WriteLine("Origem");
else if (x > 0.0 && y > 0.0)
    Console.WriteLine("Q1");
else if (x < 0.0 && y > 0.0)
    Console.WriteLine("Q2");
else if (x < 0.0 && y < 0.0)
    Console.WriteLine("Q3");
else if (x > 0.0 && y < 0.0)
    Console.WriteLine("Q4");
else if (x == 0)
    Console.WriteLine("Eixo X");
else if (y == 0)
    Console.WriteLine("Eixo Y");





