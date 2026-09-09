bool sisitema = true;
while (sisitema)
{
    Console.WriteLine("Insira o média de notas dos 4 bimestres que eu te direi a média final. Ela precisa ser 7\nInsira a nota do primeiro bimestre");
    double primeiroBimestre = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nInsira a nota do segundo bimestre");
    double segundoBimestre = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nInsira a nota do terceiro bimestre");
    double terceiroBimestre = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nInsira a nota do quarto bimestre");
    double quartoBimestre = Convert.ToDouble(Console.ReadLine());

    var media = (primeiroBimestre + segundoBimestre + terceiroBimestre + quartoBimestre) / 4.0;

    if (media >= 7)
    {
        Console.WriteLine($"\nSua média é: {media}, você passou!");
    }

    else
    {
        Console.WriteLine($"\nSua é média é: {media}, você reprovou!");
    }

    Console.WriteLine("Deseja calcular sua média novamente? s/n");
    string resposta = Console.ReadLine();

    if (resposta == "S" || resposta == "s")
    {
        sisitema = true;
    }

    else
    {
        sisitema = false;
    }

}