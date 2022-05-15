using System;

class Exercicio34{

   static void Main(){
      
      double Peso, Altura, IMC;

      Console.Write("Digite seu peso em kg: ");
      Peso = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite sua altura em metros: ");
      Altura = Convert.ToDouble(Console.ReadLine());

      IMC = Peso/Math.Pow(Altura, 2);

      if(IMC < 18.5){
         Console.WriteLine("Seu IMC é "+IMC+" e você está abaixo do peso.");
      }
      else if(18.5 <= IMC && IMC < 25){
         Console.WriteLine("Seu IMC é "+IMC+" e você está no peso ideal.");
      }
      else if(25 <= IMC && IMC < 30){
         Console.WriteLine("Seu IMC é "+IMC+" e você está no sobrepeso.");
      }
      else if(30 <= IMC && IMC < 40){
         Console.WriteLine("Seu IMC é "+IMC+" e você está com obesidade.");
      }
      else{
         Console.WriteLine("Seu IMC é "+IMC+" e você está com obesidade mórbida.");
      }

   }
}