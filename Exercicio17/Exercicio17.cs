using System;

class Exercicio17{

   static void Main(){
      
      double Velocidade, Multa, Valor;

      Console.Write("Digite a velocidade do carro em km/h: ");
      Velocidade = Convert.ToDouble(Console.ReadLine());

      if(Velocidade>80){
         Multa = Velocidade - 80;
         Valor = Multa * 5;
         Console.WriteLine("Você ultrapassou "+Multa+"km/h do permitido, sua multa é de R$"+Valor+".");
      }
      else{
         Console.WriteLine("Você não foi multado.");
      }
   }
}