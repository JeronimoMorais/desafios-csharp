using System;
using System.Linq;
class Program {
  
  static void Main(string[] args) {
    
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    // int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhas];

            int N = numeroDeFigurinhas;
            // int M = numeroDeFigurinhasCompradas;
            
            // if(N >= 1 && N <= 100 && M >= 1 && M <= 300){
            if(N > 0 && N <= 100){ 
                
                int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
                int M = numeroDeFigurinhasCompradas;
                // int contador = 0;

                if(M > 0 && M <= 300){
                    for (int i = 0; i < M; i++) {
                        int X = int.Parse(Console.ReadLine());
                            if(X > 0  && X <= N){
                                if (!albumDeFigurinha.Contains(X)) {                                
                                    // Console.WriteLine("Passou! " +i);
                                    albumDeFigurinha[i] = X;
                                    numeroDeFigurinhas -= 1;
                                    totalDeFigurinhas = numeroDeFigurinhas;
                                    // Console.WriteLine("Valor de totalfigurinhas: " +totalDeFigurinhas);
                                    if( numeroDeFigurinhas == 0 ) { 
                                        continue; 
                                    }
                                }
                            
                            } else { Console.WriteLine("[ERRO] - Você digitou um número de figurinha inválido!"); break; }    
                            
                    } Console.WriteLine(totalDeFigurinhas); //está falhando nos testes 4, 5 e 6.

                } else {Console.WriteLine("[ERRO] - Você digitou um valor inválido!");}

            } else {Console.WriteLine("[ERRO] - Você digitou um valor inválido!");}
    }
}

// TEXTO
// Desafio
// A Copa do Mundo de Futebol é um dos maiores eventos esportivos do Planeta Terra, e o álbum de figurinhas oficial é sempre um grande 
// sucesso entre os amantes dessa competição. O álbum contém espaços numerados de 1 a N para colar as figurinhas; cada figurinha, também numerada de 1 a N,
//  é uma pequena foto de um jogador de uma das seleções que jogará a Copa do Mundo. O objetivo é colar todas as figurinhas nos respectivos espaços no álbum, 
// de modo a completar o álbum, ou seja, não deixar nenhum espaço sem a correspondente figurinha.

// As figurinhas são vendidas em envelopes fechados, de forma que o comprador não sabe quais figurinhas está comprando, 
// e pode ocorrer de comprar uma figurinha que ele já tenha colado no álbum.

// Para ajudar os usuários, a empresa responsável pela venda do álbum e das figurinhas quer criar um aplicativo que permita gerenciar 
// facilmente as figurinhas que faltam para completar o álbum e está solicitando a sua ajuda.

// Dados o número total de espaços e figurinhas do álbum, e uma lista das figurinhas já compradas (que pode conter figurinhas repetidas), 
// o seu desafio é determinar quantas figurinhas faltam para completar o álbum.

// OBJETIVO
// A primeira linha contém um inteiro N (1 ≤ N ≤ 100) indicando o número total de figurinhas e espaços no álbum. 
// A segunda linha contém um inteiro M (1 ≤ M ≤ 300) indicando o número de figurinhas já compradas. Cada uma das M linhas seguintes 
// contém um número inteiro X (1 ≤ X ≤ N) indicando uma figurinha já comprada.
// Seu programa deve produzir uma única linha contendo um inteiro representando o número de figurinhas que falta para completar o álbum.

// exemplos de saída: 10 (total figurinhas), 3 (figurinhas já compradas), 5 / 8 / 3 (números das figurinhas compradas) // 7 (qtd restante)