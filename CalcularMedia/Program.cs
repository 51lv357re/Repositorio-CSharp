bool sistema = true;
while (sistema)
{

Console.WriteLine("\n       Calculadora\n=========================\nInsira o primeiro número"); 
double primeiro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha o operador: (+-/*)");
string operador = Convert.ToString(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
double segundo = Convert.ToDouble(Console.ReadLine());

double resultado = 0;


    if (operador == "+")
    {
        resultado = primeiro + segundo;
        Console.WriteLine($"\nO resultado é: {resultado}");

    }

    else if (operador == "-")
    {
        resultado = primeiro - segundo;
        Console.WriteLine($"\nO resultado é: {resultado}");
    }

    else if (operador == "*")
    {
        resultado = primeiro * segundo;
        Console.WriteLine($"\nO resultado é: {resultado}");
    }

    else if (operador == "/")
    {
        if (segundo != 0)
        {
            resultado = primeiro / segundo;
            Console.WriteLine($"\nO resultado é: {resultado}");
        }

        else
        {
            Console.WriteLine("\nErro: divisão por 0");
            sistema = false;
            resultado = 0;
        }
    }


    else
    {
        Console.WriteLine("\nOperador inválido");
        sistema = false;
        resultado = 0;
    }

    Console.WriteLine("\nDeseja continuar? n/s");
    var resposta = Console.ReadLine();

    if (resposta == "s")
    {
        sistema = true;
    }

    else
    {
        sistema = false;
    Console.WriteLine("\nPrograma encerrado! ");
    }
}

