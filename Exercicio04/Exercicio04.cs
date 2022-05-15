using System;

class Exercicio4{

   static void Main(){
      
      double Num1, Num2, Total;

      Console.Write("Digite um número: ");
      Num1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite outro número: ");
      Num2 = Convert.ToDouble(Console.ReadLine());

      Total = Num1 + Num2;

      Console.WriteLine("A soma entre "+Num1+" e "+Num2+" é "+Total+".");
   }
}