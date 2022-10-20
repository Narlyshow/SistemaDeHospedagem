using SistemaDeHospedagem.BackEnd.Entities;
using SistemaDeHospedagem.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {


            Tela tela = new Tela();
            tela.TelaInicial();
              

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 9);
            reserva.CadastrarSuite(suite);
            //reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}
