using System;

class Exercicio49{

   static void Main(){
      
      int Valor=0, i=0, j=0;

      while(Valor < 6){
         Valor++;
         if(Valor%2 == 0){
            i++;
         }
         else{
            j++;
         }
      }

      Console.WriteLine("Há "+i+" números pares e "+j+" números ímpares.");
      
   }
}