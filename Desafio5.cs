// using System;
// class Desafio {
//     static void Main() {
//         int tempoS = int.Parse(Console.ReadLine());
        
//         if(tempoS < 0 || tempoS == -0){
//             Console.WriteLine("Número inválido.");
//         }
//         else if(0 <= tempoS && tempoS < 60) {
//             Console.WriteLine($"0:0:{tempoS}");
//         } 
//         else if(tempoS >= 60 && tempoS < 3600) {
//             int minutos = tempoS/60;
//             int segundos = tempoS%60;
//             Console.WriteLine($"0:{minutos}:{segundos}");
//         }
//         else {
//             int hora = tempoS/3600;
//             int restoHora = tempoS%3600;
//                 if(restoHora == 60 || restoHora > 60 ) {
//                     int minutos = restoHora/60;
//                     int segundos = restoHora%60;
//                     Console.WriteLine($"{hora}:{minutos}:{segundos}");
//                 }
//                 else{
//                     Console.WriteLine($"{hora}:{restoHora}:0");
//                 }
//         }
//     }
// }