using System;

class Exercicio8{

   static void Main(){
      
      double metros;

      Console.Write("Digite uma distância em metros: ");
      metros = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("A distância "+metros+"m equivale a "+metros/1000+"km.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros/100+"Hm.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros/10+"Dam.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros+"m.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros*10+"Dm.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros*100+"Cm.");
      Console.WriteLine("A distância "+metros+"m equivale a "+metros*1000+"Mm.");
   }
}