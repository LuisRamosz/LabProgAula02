// // tipos de variáves
// int x = 10;
// double pi = 3.1415;
// char letra = 'A';
// bool isTrue = true;
// string texto = "Uma linda mensagem";

// double outroValor;
// // Conversão implícita
// outroValor = x;
// //Conversão explícita
// int valorInteiro = (int) pi;

// // Conversão explícita com a classe Convert
// //int y = Convert.ToInt32(texto);

// // Operadores aritiméticos
// // +, -, /, *, =, ==

// int numero;
// Console.WriteLine("Digite um número");
// numero = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("O usuário digitou : " + numero);

// //Interpolação de strings
// Console.WriteLine($"O dobro do que o usuário digitou é: {numero * 2}");


double numero;
double numero2;


Console.WriteLine("Insira o primeiro número");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo número");
numero2 = Convert.ToInt32(Console.ReadLine());

double soma = numero + numero2;
double subtracao = numero - numero2;
double multiplicacao = numero * numero2;
double divisao = numero / numero2;

Console.WriteLine("A soma dos valores informados é:" + soma); // Concatenação
Console.WriteLine($"A subtração dos valores informados é: {subtracao}"); // Interpolação

Console.WriteLine("A multiplição entre {0} e {1} é igual a {2}", numero, numero2, multiplicacao);

Console.WriteLine("A divisão entre {0} e {1} é igual a {2}", numero, numero2, divisao);

