// using System;
// using System.Globalization;

// class Desafio1 {
//     static void Main() {
        
//         string[] valores;
//         int tempo, velocidade;
//         double litrosGastos;

//         valores = Console.ReadLine().Split(" ");
//         tempo = int.Parse(valores[0]);
//         velocidade = int.Parse(valores[1]);

//         litrosGastos = ((double)velocidade * (double)tempo) / (double)12;
        
//         Console.WriteLine(Math.Round(litrosGastos,3 ));
//         Console.WriteLine(litrosGastos.ToString("N3", CultureInfo.InvariantCulture));
//     }
// }