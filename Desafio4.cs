using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] entradas1 = Console.ReadLine().Split(" ");
        int Ca = int.Parse(entradas1[0]);
        int Ba = int.Parse(entradas1[1]);
        int Pa = int.Parse(entradas1[2]);
        
        if(Ca < 0 || Ca > 100){
          Console.Write("Valor inválido!");
        }
        if(Ba < 0 || Ba > 100){
          Console.Write("Valor inválido!");
        }
        if(Pa < 0 || Pa > 100){
          Console.Write("Valor inválido!");
        }
        
        string[] entradas2 = Console.ReadLine().Split(" ");
        int Cr = int.Parse(entradas2[0]);
        int Br = int.Parse(entradas2[1]);
        int Pr = int.Parse(entradas2[2]);
        
        if(Cr < 0 || Cr > 100){
          Console.Write("Valor inválido!");
        }
        if(Br < 0 || Br > 100){
          Console.Write("Valor inválido!");
        }
        if(Pr < 0 || Pr > 100){
          Console.Write("Valor inválido!");
        }
        
        int resultado1 = Ca - Cr;
        int resultado2 = Ba - Br;
        int resultado3 = Pa - Pr;
        
        int[] passageiros = {resultado1, resultado2, resultado3};
        int resultadoTotal = 0;
        for(int i=0; i < 3; i++){
          if(passageiros[i] < 0){
            resultadoTotal += passageiros[i];
          }
        }
        Console.Write(resultadoTotal * -1);
        }
    }
}