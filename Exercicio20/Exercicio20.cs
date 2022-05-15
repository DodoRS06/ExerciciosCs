using System;

class Exercicio20{

   static void Main(){
      
      int Numero;

      Console.Write("Digite um número inteiro: ");
      Numero = Convert.ToInt32(Console.ReadLine());

      if(Numero%2 == 0){
         Console.WriteLine("O número digitado é PAR.");
      }
      else{
         Console.WriteLine("O número digitado é ÍMPAR.");
      }
      
   }
}