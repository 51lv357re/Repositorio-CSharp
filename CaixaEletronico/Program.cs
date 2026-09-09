bool sistema = true;
double saldo = 500;

while (sistema) 
{
    {
        Console.WriteLine($"Caixa eletrônico\n================\nSaldo atual: {saldo}! Qual valor deseja retirar?\n");
    }

    double extrato = Convert.ToDouble(Console.ReadLine());

    if ( extrato > saldo)
    {
        Console.WriteLine("A quantia a ser retirada é maior do que a que você possui. Tentar mais uma vez? s/n");
        string resposta = Console.ReadLine();

        if ( resposta == "s")
        {
            sistema = true;
        }

        else
        {
            sistema = false;
        }
    }

    else if (extrato <= 0)
    {
        Console.WriteLine("Saldo insuficiente ou valor 0. Tentar mais uma vez? s/n");
        string resposta = Console.ReadLine();

        if (resposta == "s")
        {
            sistema = true;
        }

        else
        {
            sistema = false;
        }
    }

    else
    {
        saldo = saldo - extrato;

        Console.WriteLine($"Seu saldo atual é de {saldo}! Deseja continuar? s/n");

        string resposta = Console.ReadLine();

        if (resposta == "s")
        {
            sistema = true;
        }

        else
        {
            sistema = false;
        }
    }

}