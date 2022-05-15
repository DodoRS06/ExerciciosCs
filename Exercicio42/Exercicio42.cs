using System;

class Exercicio42{

   static void Main(){
      
      int Valor, i=0;

      Console.Write("Digite um valor: ");
      Valor = Convert.ToInt32(Console.ReadLine());

      while(i < Valor){
         i++;
         Console.Write(i+" ");
      }
      Console.WriteLine("Acabou!");
      
   }
}