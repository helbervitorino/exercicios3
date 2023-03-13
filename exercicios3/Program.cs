using System;

public class Program
{
    private static bool _continuar = true;
    public static void Main()
    {
        while (_continuar)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Tarefa 1");
            Console.WriteLine("2 - Tarefa 2");
            Console.WriteLine("3 - Tarefa 3");
            Console.WriteLine("0 - Encerrar");

            int opcao = int.Parse(Console.ReadLine() ?? "");

            switch (opcao)
            {
                case 1:
                    ModificarArray();
                    break;

                case 2:
                    AnalisarQuerySql();
                    break;

                case 3:
                    SomarConjunto();
                    break;

                case 0:
                    _continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            }

            if (_continuar)
            {
                Console.WriteLine("Deseja escolher outra opção? (S/N)");

                if (Console.ReadLine()?.ToUpper() != "S")
                    _continuar = false;
            }
        }
    }

    #region Tarefa 1

    public static void ModificarArray()
    {
        int[] arrayOriginal = { 7, 5, 3, 9, 6, 4, 1 };
        int[] arrayModificado = arrayOriginal;

        Console.Write("O array original é: ");
        arrayOriginal.ToList().ForEach(p => Console.Write(p.ToString()));

        for (int i = 6; i < arrayModificado.Length; i++)
        {
            arrayModificado[3] = 5;
        }

        int valorRemover = 5;
        arrayModificado = arrayOriginal.Where((source, index) => index != valorRemover).ToArray();

        Console.WriteLine(" ");

        Console.Write("O array Modificado é: ");
        arrayModificado.ToList().ForEach(p => Console.Write(p.ToString()));

        Console.WriteLine(" ");

        Console.WriteLine($"A soma do array Modificado é: {arrayModificado.Sum()}");
    }

    #endregion

    #region Tarefa 2

    public static void AnalisarQuerySql()
    {
        Console.WriteLine("Ao analisar o anunciado da Tarefa 2, podemos observar que no 1º " +
        " exemplo trouxe a quantidade total de 100 registros, no 2º trouxe o resultado igual ao que foi passado na " +
        " condição WHERE = 123, então na query do questionamento, onde o resultado tem que ser diferente do valor 123, " +
        " será mostrado um total de 85 registros.");

    }

    #endregion

    #region Tarefa 3

    public static void SomarConjunto()
    {
        int[] ints = { 2, 7, 11, 15 };
        List<int> nums_digitados = new();

        while (_continuar)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (nums_digitados.Contains(valor))
            {
                Console.WriteLine("Este numero ja foi utilizado antes. Tente novemente. ");
                continue;
            }
            else
                nums_digitados.Add(valor);

            var dicionario = new Dictionary<int, int>();

            for (int i = 0; i < ints.Length; i++)
            {
                int complemento = valor - ints[i];

                if (dicionario.ContainsKey(complemento))
                {
                    Console.WriteLine($"Índice dos numeros que somam {valor}: [ {dicionario[complemento]}, {i} ]");
                    continue;
                }

                dicionario[ints[i]] = i;
            }

            Console.WriteLine($"Não foi possivel encontrar dois numero que somam {valor}");

            Console.WriteLine("Deseja continuar? (S/N)");

            if (Console.ReadLine()?.ToUpper() != "S")
                _continuar = false;
        }

        _continuar = true;
    }

    #endregion
}