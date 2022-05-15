using System;

class Exercicio26{

   static void Main(){
      
      int Num1, Num2;

      Console.Write("Digite um número: ");
      Num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Digite outro número: ");
      Num2 = Convert.ToInt32(Console.ReadLine());

      if(Num1 > Num2){
         Console.WriteLine("O primeiro valor é maior.");
      }
      else if (Num1 == Num2){
         Console.WriteLine("Não existe valor maior, os dois são iguais.");
      }
      else{
         Console.WriteLine("O segundo valor é maior.");
      }
   }
}