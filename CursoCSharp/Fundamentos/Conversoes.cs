using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Converter double em int sem dar erro
            double nota = 9.7;
            int notatruncada = (int)nota;
            Console.WriteLine("Nota truncada " + notatruncada);

            // Converter string em inteiro, mais se tiver algum char pode apresentar erro.
            Console.WriteLine("Digite sua idade ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            // Converter String em numero sem dar erro
            Console.Write("Digite um numero: ");
            string palavra = Console.ReadLine();
            
            // Tenta converter a string em int caso não consiga usa o valor default == 0;
            int numero1;
            int.TryParse(palavra, out numero1);

            Console.WriteLine($"Resultado1: {numero1}");

            // Converter String em numero sem dar erro
            Console.Write("Digite um numero: ");
            // Tenta converter a string em int caso não consiga usa o valor default == 0; usando performace
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado2: {numero2}");
        }
    }
}
