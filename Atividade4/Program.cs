using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior = 0, menor = 0;
            double media = 0;
            double participante1 = 0;
            double participante2 = 0;
            double participante3 = 0;
            double participante4 = 0;
            double participante5 = 0;

            Console.WriteLine("Digite a idade dos 5 participantes.");
            Console.Write("Informe a idade do primeiro participante: ");
            participante1 = Convert.ToDouble(Console.ReadLine());
            maior = participante1;
            menor = participante1;
            Console.Write("Informe a idade do segundo participante: ");
            participante2 = Convert.ToDouble(Console.ReadLine());
            if (participante2 > maior)
            {
                maior = participante2;
            }
            else if (participante2 < menor)
            {
                menor = participante2;
            }

            Console.Write("Informe a idade do terceiro participante: ");
            participante3 = Convert.ToDouble(Console.ReadLine());
            if (participante3 > maior)
            {
                maior = participante3;
            }
            else if (participante3 < menor)
            {
                menor = participante3;
            }
            Console.Write("Informe a idade do quarto participante: ");
            participante4 = Convert.ToDouble(Console.ReadLine());
            if (participante4 > maior)
            {
                maior = participante4;
            }
            else if (participante4 < menor)
            {
                menor = participante4;
            }
            Console.Write("Informe a idade do quinto participante: ");
            participante5 = Convert.ToDouble(Console.ReadLine());
            if (participante5 > maior)
            {
                maior = participante5;
            }
            else if (participante5 < menor)
            {
                menor = participante5;
            }
            Console.WriteLine("O maior valor informado é: " + maior);
            Console.WriteLine("O menor valor informado é: " + menor);
            {
                media = (participante1 + participante2 + participante3 + participante4 + participante5) / 5;
            }
            Console.WriteLine("O valor médio entre os participantes é: " + media);

        }
    }
}