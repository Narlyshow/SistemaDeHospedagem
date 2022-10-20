﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SistemaDeHospedagem.BackEnd.Entities;

namespace SistemaDeHospedagem.UI
{
    public class Tela
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        Reserva reserva = new Reserva();

        public void TelaInicial()
        {
            int op = 1;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("BEM VINDO AO SISTEMA DE RESERVAS!");
            Console.WriteLine();
            Console.WriteLine("A reserva que deseja fazer são para quantos hóspedes?");



            int n;
            var entradaTeclado = Console.ReadLine();
            bool result = Int32.TryParse(entradaTeclado, out n);
            string etapa = "tela1";
            
            ValidacaoDeOpcoes(ref entradaTeclado, result, etapa);


           

            for (int i = 1; i <= Convert.ToInt32(entradaTeclado); i++)
            {
                
                Console.Clear();
                
                Console.WriteLine($"Digite o nome do {i}º Hóspede:");
                string[] hospede = Console.ReadLine().Split(' ');
                string sobrenome = EditarNome(hospede);
                Pessoa p1 = new Pessoa(nome: hospede[0], sobrenome: sobrenome);
                hospedes.Add(p1);
                
            }


            etapa = "tela2";
            Console.WriteLine(TelaEscolherSuite());
            entradaTeclado = Console.ReadLine();
            result = Int32.TryParse(entradaTeclado, out n);
            ValidacaoDeOpcoes(ref entradaTeclado, result, etapa);


            
           





        }

        
        public void CriarSuite(int entradaTeclado)
        {
            string suite = String.Empty;
            int capacidade = 0;
            decimal valorDiaria = 0;

            switch (entradaTeclado)
            {
                case 1:
                    suite = "Premium";
                    capacidade = 5;
                    valorDiaria = 100.00m;
                    break;
                case 2:
                    suite = "Convencional";
                    capacidade = 10;
                    valorDiaria = 70.00m;
                    break;
                case 3:
                    suite = "Família";
                    capacidade = 2;
                    valorDiaria = 150.00m;
                    break;
                case 4:
                    suite = "Individual";
                    capacidade = 1;
                    valorDiaria = 50.00m;
                    break;
                default:
                    break;
            }

            new Suite(suite, capacidade, valorDiaria);
        
        }
        
        /// <summary>
        /// Metodo para montar o nome completo
        /// </summary>
        /// <param name="hospede"></param>
        /// <returns></returns>
        public string EditarNome(string[] hospede)
        {
            string sobrenome = string.Empty;
            
            for (int i = 1; i < hospede.Length; i++)
            {
                sobrenome += hospede[i] + " ";
            }
            

            return sobrenome.TrimEnd();
        }


        /// <summary>
        /// Metodo para sair do programa
        /// </summary>
        public void Exit()
        {
            Console.WriteLine("Encerrando sessão em...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

    
        /// <summary>
        /// Metodo para exibir na tela a escolha da suite
        /// </summary>
        /// <returns></returns>
        public string TelaEscolherSuite()
        {
            StringBuilder sb = new StringBuilder();
            Console.Clear();
            sb.AppendLine("Escolha o tipo da suíte que deseja reservar:");
            sb.AppendLine(" 1 - TIPO: Premium CAPACIDADE: 5 Pessoas PREÇO DIÁRIA: R$ 100,00");
            sb.AppendLine(" 2 - TIPO: Convencional CAPACIDADE: 2 Pessoas PREÇO DIÁRIA: R$ 70,00");
            sb.AppendLine(" 3 - TIPO: Família CAPACIDADE: 10 Pessoas PREÇO DIÁRIA: R$ 150,00");
            sb.AppendLine(" 4 - TIPO: Individual CAPACIDADE: 01 Pessoa PREÇO DIÁRIA: R$ 50,00");

            return sb.ToString();
        }
    
        
        /// <summary>
        /// Método para validar as opções do usuário
        /// </summary>
        /// <param name="entradaTeclado"></param>
        /// <param name="result"></param>
        /// <param name="etapa"></param>
        /// <returns></returns>
        public ref string ValidacaoDeOpcoes(ref string entradaTeclado, bool result, string etapa)
        {
            
            
            if (etapa == "tela1")
            {
                if (result)
                {

                }
                else
                {
                    Console.WriteLine("Opção inválida!\nDigite a quantidade de hóspedes ou digite 0 para sair!");
                    try
                    {
                        entradaTeclado = Console.ReadLine();
                        if (Convert.ToInt32(entradaTeclado) == 0)
                        {
                            Console.Clear();
                            Exit();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERRO FATAL " + ex.Message);
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        TelaInicial();

                    }
                }
            }
            else
            {
                if (result)
                {

                }
                else
                {
                    Console.WriteLine("Opção inválida!\nDigite uma das opções disponíveis ou digite 0 para sair!");
                    try
                    {
                        entradaTeclado = Console.ReadLine();
                        if (Convert.ToInt32(entradaTeclado) == 0)
                        {
                            Console.Clear();
                            Exit();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERRO FATAL " + ex.Message);
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(TelaEscolherSuite());

                    }
                }
            }


            return ref entradaTeclado;
        }
    
    }
}
