using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe a primeira nota: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota: ");
        double n3 = double.Parse(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        Console.WriteLine("A média é " + media);

        if(media>=7){
          Console.WriteLine("Aprovado por média.");
        }else if(media<3){
          Console.WriteLine("Reprovado.");   
        }else{
          Console.WriteLine("De recuperação.");
        }

    }
}