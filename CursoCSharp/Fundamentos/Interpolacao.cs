using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Noteboook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Exemplos de Interpolação
            Console.WriteLine("O " + nome + " da " + marca + " Custa " + preco);
            Console.WriteLine("O {0} da {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"O {nome} da {marca} custa {preco}");
            Console.WriteLine($"1 + 1 = {1+1}");
        }
    }
}
