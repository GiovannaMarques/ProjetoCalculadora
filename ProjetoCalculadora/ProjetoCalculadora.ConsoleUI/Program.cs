using System;

namespace ProjetoCalculadora.ConsoleUI
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Você quer somar, subtrair, dividir ou multiplicar? " +
                "+, -, / ou * ");
            string resultadoPergunta = Console.ReadLine();

            switch (resultadoPergunta)
            {
                case "+":
                case "somar":
                    int resultadoSoma = Somar();
                    Console.WriteLine($"O resultado da soma é {resultadoSoma}");
                    break;
                case "-":
                    int resultadoSubtracao = Subtrair();
                    Console.WriteLine($"O resultado da subtração é {resultadoSubtracao}");
                    break;
                case "/":
                    int resultadoDivisao = Divisao();
                    Console.WriteLine($"O resultado da divisão é {resultadoDivisao}");
                    break;
                case "*":
                    int resultadoMultiplicacao = Multiplicacao();
                    Console.WriteLine($"O resultado da multiplicação é {resultadoMultiplicacao}");
                    break;
            }
            Console.ReadLine();
        }
        // int.TryPase

        public static int Somar()
        {
            Console.WriteLine("Qual o primeiro número que você quer somar?");
            string numeroInput = Console.ReadLine();
            int numeroConvertido = 0;
            bool conversaoDeuCerto = int.TryParse(numeroInput, out numeroConvertido);

            if (conversaoDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            Console.WriteLine("Qual o segundo número que você quer somar?");
            string numeroDoisInput = Console.ReadLine();
            int numeroDoisConvertido = 0;
            bool conversaoDoisDeuCerto = int.TryParse(numeroDoisInput, out numeroDoisConvertido);

            if (conversaoDoisDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            int soma = numeroConvertido + numeroDoisConvertido;

            return soma;
        }

        public static int Subtrair()
        {
            Console.WriteLine("Qual o primeiro número que você quer subtrair?");
            string numeroInput = Console.ReadLine();
            int numeroConvertido = 0;
            bool conversaoDeuCerto = int.TryParse(numeroInput, out numeroConvertido);

            if (conversaoDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            Console.WriteLine("Qual o segundo número que você quer subtrair?");
            string numeroDoisInput = Console.ReadLine();
            int numeroDoisConvertido = 0;
            bool conversaoDoisDeuCerto = int.TryParse(numeroDoisInput, out numeroDoisConvertido);

            if (conversaoDoisDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            int subtracao = numeroConvertido - numeroDoisConvertido;

            return subtracao;
        }

        public static int Divisao()
        {
            Console.WriteLine("Qual o primeiro número que você quer dividir?");
            string numeroInput = Console.ReadLine();
            int numeroConvertido = 0;
            bool conversaoDeuCerto = int.TryParse(numeroInput, out numeroConvertido);

            if (conversaoDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            Console.WriteLine("Qual o segundo número que você quer dividir?");
            string numeroDoisInput = Console.ReadLine();
            int numeroDoisConvertido = 0;
            bool conversaoDoisDeuCerto = int.TryParse(numeroDoisInput, out numeroDoisConvertido);

            if (conversaoDoisDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }


            int dividir = numeroConvertido / numeroDoisConvertido;

            return dividir;
        }

        public static int Multiplicacao()
        {
            Console.WriteLine("Qual o primeiro número que você quer multiplicar?");
            string numeroInput = Console.ReadLine();
            int numeroConvertido = 0;
            bool conversaoDeuCerto = int.TryParse(numeroInput, out numeroConvertido);

            if (conversaoDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            Console.WriteLine("Qual o segundo número que você quer multiplicar?");
            string numeroDoisInput = Console.ReadLine();
            int numeroDoisConvertido = 0;
            bool conversaoDoisDeuCerto = int.TryParse(numeroDoisInput, out numeroDoisConvertido);

            if (conversaoDoisDeuCerto == false)
            {
                Console.WriteLine("Número não reconhecido, desconsiderando conta...");
            }

            int multiplicacao = numeroConvertido * numeroDoisConvertido;

            return multiplicacao;
        }
    }
}
