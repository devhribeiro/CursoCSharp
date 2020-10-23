using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " Wolrd!").Replace("Wolrd!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste ".Length);

            // Usar ? para verificar se a variavel não está nula para avitar erros
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
