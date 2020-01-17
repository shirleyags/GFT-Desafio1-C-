using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("EcoSport", "Ford", "DMK5425", "Vermelho", 100.0, true, 50, 60, 50000.0);

            veiculo.ligar();
            veiculo.acelerar();
            veiculo.abastecer(200);
            veiculo.frear();

            veiculo.pintar("verde");
            

            Console.ReadLine();
        }
    }
}
