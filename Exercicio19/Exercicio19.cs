using System;

class Exercicio19{

   static void Main(){
      
      double Nota1, Nota2, Media;

      Console.Write("Digite sua primeira nota: ");
      Nota1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite sua segunda nota: ");
      Nota2 = Convert.ToDouble(Console.ReadLine());

      Media = (Nota1 + Nota2)/2;

      if(Media < 7){
         Console.WriteLine("O aluno obteve uma média de "+Media+" pontos e não obteve um bom rendimento.");
      }
      else{
         Console.WriteLine("O aluno obteve uma média de "+Media+" pontos e obteve um bom rendimento.");
      }
      
   }
}