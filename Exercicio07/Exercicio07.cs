using System;

class Exercicio7{

   static void Main(){
      
      double Numero, Dobro, Terca;

      Console.Write("Digite um número: ");
      Numero = Convert.ToDouble(Console.ReadLine());

      Dobro = Numero * 2;
      Terca = Numero / 3;

      Console.WriteLine("O dobro de "+Numero+" é "+Dobro+".");
      Console.WriteLine("A terça parte de "+Numero+" é "+Terca+".");
   }
}