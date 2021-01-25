// // Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.
// // Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

// // Entrada
// // A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

// // Saída
// // Imprima o nome do animal correspondente à entrada fornecida.

// Exemplos de Entrada	            Exemplos de Saída
// vertebrado
// mamifero
// onivoro                          homem

// vertebrado
// ave
// carnivoro                        aguia

// // invertebrado
// // anelideo
// // onivoro                       minhoca

using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  opcao1; //declare as suas variaveis
        String  opcao2;
        String  opcao3;

        opcao1 = Console.ReadLine(); //insira suas variaveis
        // opcao2 = Console.ReadLine();
        // opcao3 = Console.ReadLine();

        if(opcao1 == "vertebrado") { opcao2 = Console.ReadLine();
            
            if(opcao2 == "ave"){ opcao3 = Console.ReadLine();
            
                if(opcao3 == "carnivoro"){ Console.WriteLine("aguia\n"); }
                
                else if(opcao3 == "onivoro"){ Console.WriteLine("pomba\n"); }

                else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}

            }

            else if(opcao2 == "mamifero"){ opcao3 = Console.ReadLine();
            
                if(opcao3 == "onivoro"){ Console.WriteLine("homem\n"); } 
                
                else if( opcao3 == "herbivoro"){ Console.WriteLine("vaca\n"); } 
                
                else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}

            } else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}
        }
        else if(opcao1 == "invertebrado"){ opcao2 = Console.ReadLine();
           
           if(opcao2 == "inseto"){ opcao3 = Console.ReadLine();
            
                if(opcao3 == "hematofago"){ Console.WriteLine("pulga\n"); }
                
                else if(opcao3 == "herbivoro"){ Console.WriteLine("lagarta\n"); }

                else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}
            }

            else if(opcao2 == "anelideo"){ opcao3 = Console.ReadLine();
            
                if(opcao3 == "hematofago"){ Console.WriteLine("sanguessuga\n"); } 
                
                else if( opcao3 == "onivoro"){ Console.WriteLine("minhoca\n"); }

                else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}
            
            } else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}
        
        } else {Console.WriteLine("[ERRO] - Você digitou uma palavra inválida!");}
  }
}
