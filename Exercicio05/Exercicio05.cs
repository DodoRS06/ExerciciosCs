using System;

class Exercicio5{

   static void Main(){
      
      double Nota1, Nota2, Media;

      Console.Write("Digite sua primeira nota: ");
      Nota1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite sua segunda nota: ");
      Nota2 = Convert.ToDouble(Console.ReadLine());
      
      Media = (Nota1 + Nota2)/2;

      Console.WriteLine("A média entre a nota "+Nota1+" e a nota "+Nota2+" é de "+Media+".");
   }
}