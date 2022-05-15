using System;

class Exercicio3{

   static void Main(string []args){
      
      string nome;
      double salario;

      Console.Write("Digite seu nome: ");
      nome = Console.ReadLine();
      Console.Write("Digite seu salário: ");
      salario = Convert.ToDouble(Console.ReadLine());

      Console.Write("O funcionário "+nome+" tem um salário de R$"+salario+" reais.");
   }
}