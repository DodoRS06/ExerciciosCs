using System;

class Exercicio18{

   static void Main(){
      
      double AnoAtual, AnoNasc, MesAtual, MesNasc, AnoTotal;

      Console.Write("Digite o ano que você nasceu: ");
      AnoNasc = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite o ano em que você se encontra: ");
      AnoAtual = Convert.ToDouble(Console.ReadLine());

      AnoTotal = AnoAtual - AnoNasc;

      if(AnoTotal < 16){
         Console.WriteLine("Você não pode votar.");
      }
      else if(AnoTotal == 16){
         Console.Write("Digite o mês que você nasceu: ");
         MesNasc = Convert.ToDouble(Console.ReadLine());
         Console.Write("Digite o mês em que você se encontra: ");
         MesAtual = Convert.ToDouble(Console.ReadLine());
         
         if(MesAtual>MesNasc)
         Console.WriteLine("Você tem 16 anos e já pode votar.");
         else
            Console.WriteLine("Você não pode votar.");
      }
      if(AnoTotal > 16){
         Console.WriteLine("Você tem mais de 16 anos e já pode votar");
      }
   }
}