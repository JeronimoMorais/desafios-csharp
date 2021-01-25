// using System;



// class Desafio3 {

//   static void Main() {

//     string[] entradas = Console.ReadLine().Split(" ");

//     int N = int.Parse(entradas[0]);

//     int D = int.Parse(entradas[1]);

//     bool possivel = false;
    
//     string data = "";

//     int qtd = 0;

     

//     for (int dt=0; dt<D; dt++){

//      qtd = 0;

//      string[] dados = Console.ReadLine().Split(" ");

//       data = dados[0];

//      for (int p=1; p<N+1; p++){

//       qtd += int.Parse(dados[p]);

//      } //for p

//       possivel = ( qtd == N);

//      if (possivel) { break; }

//     } //for dt

     

//     if (achou) { Console.Write(data); }

//     else { Console.Write("Pizza antes de FdA"); }

//   }

// }