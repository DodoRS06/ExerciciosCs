using System;

class Exercicio27{

   static void Main(){
      
      double Nota1, Nota2, Media;

      Console.Write("Digite sua primeira nota: ");
      Nota1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite sua segunda nota: ");
      Nota2 = Convert.ToDouble(Console.ReadLine());

      Media = (Nota1 + Nota2) /2;

      if(Media < 4.9){
         Console.WriteLine("Sua média foi "+Media+" pontos, você está REPROVADO.");
      }
      else if(Media >= 7){
         Console.WriteLine("Sua média foi "+Media+" pontos, você está APROVADO.");
      }
      else{
         Console.WriteLine("Sua média foi "+Media+" pontos, você está de RECUPERAÇÃO.");
      }
   }
}