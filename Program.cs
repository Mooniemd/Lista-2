/*int x;
int y;

int total;
x = 10;
y = 20;

total = x + y;
Console.WriteLine("Sua soma é: " + total);*/

/* string nome = "Jónison";
int idade = 9 * 2;
Console.WriteLine("Olá, " + nome + ". Você tem " + idade + " anos!");
*/

/*output: Olá, Jónison. Você tem 18 anos!*/

/*
int n1 = 5;
int n2 = 7;

float media = (n1 + n2) / 2; /* Se eu trocar por % no lugar do / ele pega o resto (no caso, 0)

Console.WriteLine(media);
*/

/* Pra ver se é par ou impar, pode usar o mod (%) como por ex: N % 2, se der 0 é par, se der 1 é impar  */

/*Console.WriteLine("Me fale um número!");
  double num1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Digite um operador! (+), (-), (*) ou (/)");
  string? operador = Console.ReadLine();
Console.WriteLine("Agora me fale outro número!");
  double num2 = Convert.ToDouble(Console.ReadLine()!);

      if (operador == "+"){
        Console.WriteLine(num1 + num2);
      }
      else if (operador == "-"){
        Console.WriteLine(num1 - num2);
      }
      else if (operador == "*"){
        Console.WriteLine(num1 * num2);
      }
      else if (operador == "/"){
        Console.WriteLine(num1 / num2);
      }
*/

/*
1) ARESTA DO CUBO 
Console.WriteLine("Escreva o valor da aresta de seu cubo!");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 < 1){
  Console.WriteLine("Não existe aresta de valor 0 né mofio");
} else{
  Console.WriteLine("A aresta de seu cubo é de " + num1 * num1 * num1);
}*/

/*
2) MEDIA
Console.WriteLine("Escreva sua primeira nota!");
double nota1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Escreva sua segunda nota!");
double nota2 = Convert.ToDouble(Console.ReadLine()!);
double media = (nota1 + nota2) / 2;

  if (media < 5){
    Console.WriteLine("Sua media foi de: " + media + ", você foi reprovado!");
  } else{
    Console.WriteLine("Sua media foi de: " + media + ", você foi aprovado!");
  }
*/

/* 
3) NOME
Console.WriteLine("Ei, me diz qual o seu nome!");
string? nomeCompleto = Console.ReadLine();
Console.WriteLine("Ei, me diz que dia você nasceu!");
int diaNasc = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ei, me diz que mês você nasceu");
string? mesNasc = Console.ReadLine();
Console.WriteLine("Ei, me diz que ano você nasceu");
int anoNasc = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ei, me diz onde você nasceu");
string? localNasc = Console.ReadLine();
Console.WriteLine(nomeCompleto + " nasceu na cidade de " + localNasc + " no dia " + diaNasc + " de " + mesNasc + " de " + anoNasc);

//int dia = int.Parse(Console.ReadLine()!), string? nomeCompleto = Console.ReadLine();;
*/

/*
4) IDADE POR ANO
Console.WriteLine("Ei, me diz qual o seu nome!");
string? nomeCompleto = Console.ReadLine();
Console.WriteLine("Ei, me diz em qual ano você nasceu!");
int anoNasc = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ei, me diz em qual o ano atual!");
int anoAtual = int.Parse(Console.ReadLine()!);
int idade = anoAtual - anoNasc - 1;
Console.WriteLine("Ei, me diz onde você nasceu");
string? localNasc = Console.ReadLine();
Console.WriteLine(nomeCompleto + " possui " + idade + " anos e nasceu na cidade de " + localNasc);
*/

/*
5) IMC
Console.WriteLine("Qual o seu nome?");
string? nome = Console.ReadLine();
Console.WriteLine("Escreva seu peso!");
double peso = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Escreva seu sua altura!");
double altura = Convert.ToDouble(Console.ReadLine()!);
double imc = peso / (altura * altura);
Console.WriteLine("Olá, " + nome + " Você possui " + peso + " kg e " + altura + "m de altura. Seu IMC é de: " + imc);
*/
/*



                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */