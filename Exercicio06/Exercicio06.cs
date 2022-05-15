using System;

class Exercicio6{

   static void Main(){
      
      int Numero, Antecessor, Sucessor;

      Console.Write("Digite um número: ");
      Numero = Convert.ToInt32(Console.ReadLine());

      Antecessor = Numero - 1;
      Sucessor = Numero + 1;

      Console.WriteLine("O antecessor de "+Numero+" é "+Antecessor+".");
      Console.WriteLine("O sucessor de "+Numero+" é "+Sucessor+".");
   }
}