using System;

class Program
{
    static void Main(string[] args)
    {
        char operador;

        // Loop infinito para continuar recebendo entradas do usuário
        while (true)
        {
            Console.WriteLine("Digite o operador (+, -, *, /) ou 'q' para sair:");
            operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Verifica se o usuário deseja sair
            if (operador == 'q')
                break;

            switch (operador)
            {
                case '+':
                    Console.WriteLine("Tabuada da Adição (+):");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} + {j} = {i + j}");
                        }
                    }
                    break;

                case '-':
                    Console.WriteLine("Tabuada da Subtração (-):");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} - {j} = {i - j}");
                        }
                    }
                    break;

                case '*':
                    Console.WriteLine("Tabuada da Multiplicação (*):");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                    break;

                case '/':
                    Console.WriteLine("Tabuada da Divisão (/):");
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (j != 0) // Evita divisão por zero
                                Console.WriteLine($"{i} / {j} = {i / (float)j}");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Operador inválido. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
