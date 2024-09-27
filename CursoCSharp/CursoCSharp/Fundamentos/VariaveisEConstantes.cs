﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar() {

            // Área da Circunferencia

            double raio = 4.5;

            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A Area é " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;

            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!

            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" +populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7600000000;
            Console.WriteLine("População Mundial " + populacaoMundial);


            // Numeros Reais, com pontos decimais

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " +precoComputador);

            double valorDeMercadoApple = 1_000_000_000.00; //Mais usado dos reais!!

            Console.WriteLine("Valor Apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra é " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine("String " + texto);


            

        
        }
    }
}
