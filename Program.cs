using System;
using System.Collections.Generic;

namespace array
{
    class Program{
    
        static void Main(string[] args)
        {
            String situacao ="";
            int q;
            char continua = 's';
            Double peso, altura;
            int quantidade;

            string nome;
            double imc;
            Console.WriteLine("Digite a quantidade de pacientes:");
            quantidade = Convert.ToInt16(Console.ReadLine());

            while (continua == 's');
                q = 0;
            do
            {
                Console.WriteLine("Digite o nome do paciente:");
                nome.Add(Console.ReadLine());
                Console.WriteLine("Digite a altura do paciente:");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o peso do paciente:");
                peso = Convert.ToDouble(Console.ReadLine());
                imc.Add(peso / (altura*altura));
                continua = Convert.ToChar(Console.ReadLine());
            }
            while (continua == 's');
            q = 0;

            for (int y = 0; y < quantidade; y++)
            {
                if (imc <=20)
                {
                    situacao = "Abaixo do peso";
                }
                else
                {
                    if (imc >20 && imc <25)
                    {
                    situacao = "Peso normal";
                    }
                    else
                    {
                        if (imc >=25)
                        {
                    situacao = "Acima do peso";
                        }
                }
            Console.WriteLine(nome[q] + " o seu IMC é " + imc + " e a sua situação é " + situacao); 
            q++;  
            }
        }
    }
}
}