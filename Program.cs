using System;

namespace calculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar as variáveis = tipo nome; | Regras: não conter caracteres especiais exceto _ ; nome_aluno ou nomeAluno; deve iniciar com a letra


            double n1, n2, res;
            //Saída de dados
            
            Console.WriteLine("Digite o primeiro número: ");
            //Leitura de dados
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            res = n1 + n2;
            Console.WriteLine("Resultado da Soma é: " + res.ToString());

            //Subtração
            res = n1 - n2;
            Console.WriteLine("Resultado da Subtração é: " + res.ToString());

            //Multiplicação
            res = n1 * n2;
            Console.WriteLine("Resultado da Multiplicação é: " + res.ToString());

            //Divisão
            res = n1 / n2;
            Console.WriteLine("Resultado da Divisão é: " + res.ToString());

            /* Operadores Aritiméticos
             + - 
             ++ (incremento/ decremento)
            */

            int x = 1;
            res = x + 3;
            x++;
            x--;


        }
    }
}
