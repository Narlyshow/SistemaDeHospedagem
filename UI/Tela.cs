using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SistemaDeHospedagem.BackEnd.Entities;

namespace SistemaDeHospedagem.UI
{
    public class Tela
    {


        public void TelaInicial()
        {
            int op = 1;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("BEM VINDO AO SISTEMA DE RESERVAS!");
            Console.WriteLine();
            Console.WriteLine("A reserva que deseja fazer são para quantos hóspedes?");



            int n;
            var quantidadeHospedes = Console.ReadLine();
            bool result = Int32.TryParse(quantidadeHospedes, out n);


            if (result)
            {

            }
            else
            {
                Console.WriteLine("Opção inválida!\nDigite a quantidade de hóspedes ou digite 0 para sair!");
                try
                {
                    quantidadeHospedes = Console.ReadLine();
                    if (Convert.ToInt32(quantidadeHospedes) == 0)
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

            List<Pessoa> hospedes = new List<Pessoa>();

            for (int i = 1; i <= Convert.ToInt32(quantidadeHospedes); i++)
            {
                
                Console.Clear();
                
                Console.WriteLine($"Digite o nome do {i}º Hóspede:");
                string[] hospede = Console.ReadLine().Split(' ');
                string sobrenome = EditarNome(hospede);
                Pessoa p1 = new Pessoa(nome: hospede[0], sobrenome: sobrenome);
                hospedes.Add(p1);
            }






        }


        public string EditarNome(string[] hospede)
        {
            string sobrenome = string.Empty;
            
            for (int i = 1; i < hospede.Length; i++)
            {
                sobrenome += hospede[i] + " ";
            }
            

            return sobrenome.TrimEnd();
        }



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

    }
}
