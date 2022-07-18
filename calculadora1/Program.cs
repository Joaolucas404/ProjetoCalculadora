﻿using System;

namespace calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {                       
            Console.WriteLine("Olá Mallu, informe a operação a ser executada");
            Console.WriteLine(" 1 - soma +");
            Console.WriteLine(" 2 - subtração - ");
            Console.WriteLine(" 3 - Multiplicação * ");
            Console.WriteLine(" 4 - Divisão / ");
            int operacao = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            int valor = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine().ToString());
            double resultadoOperacao = 0;
            switch (operacao)
            {
                case 1:
                    resultadoOperacao = soma(valor, valor2);
                    break;
                case 2:
                    resultadoOperacao = subtracao(valor, valor2);
                    break;
                case 3:
                    resultadoOperacao = mult(valor, valor2);
                    break;
                case 4:
                    resultadoOperacao = divisao(valor, valor2);
                    break;
                default:
                    break;
            }


            Console.WriteLine($"O resultado da operação foi: {resultadoOperacao}");
        }
        public static double soma(int valor, int valor2) => valor + valor2;
        public static double subtracao(int valor, int valor2) => valor - valor2;
        public static double mult(int valor, int valor2) => valor * valor2;
        public static double divisao(int valor, int valor2) => valor / valor2;
    }

    }




