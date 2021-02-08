using System;

namespace Fundamentals_of_Programming_Understanding_CS_
{
    class CalcVol
    {
        static void Main(string[] args)
        {
            //Declar e atribuir valor para consumo do carro.
            byte consumption = 12;

            //Ler do console o tempo (horas) e a velocidade média da viagem se parados por espaço.
            string[] trip = Console.ReadLine().Split(' ');
            byte time = byte.Parse(trip[0]);
            byte speed = byte.Parse(trip[1]);

            //Calcular distância percorrida na viagem.
            ushort dist = (ushort)(speed * time);

            //Calcular quantidade de combustível (litros) gasta na viagem.
            float vol = ((float) dist / consumption);
            Console.WriteLine(vol);
            
            //Imprimir no console a quantidade de combustível (litros) gasto na viagem.
            Console.WriteLine(Math.Round(vol, 3));

        }
    }
}