using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.BackEnd.Entities
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva() { }



        public Reserva(int diasReservados)
        {           
            DiasReservados = diasReservados;
        }
    
        /// <summary>
        /// Método para cadastras hospedes
        /// </summary>
        /// <param name="hospedes"></param>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade )
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hospedes maior do que a capacidade permitida!");
            }
        }
        
        /// <summary>
        /// Método para cadastrar suites
        /// </summary>
        /// <param name="suite"></param>
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        /// <summary>
        /// Método para obter a quantidade dos hospedes
        /// </summary>
        /// <returns></returns>
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
    
        /// <summary>
        /// Método para calcular o valor da diaria
        /// </summary>
        /// <returns></returns>
        public decimal CalcularValorDiaria()
        {
            decimal diaria = 0.00m;

            if (DiasReservados >= 10)
            {
                diaria = Suite.ValorDiaria - ((Suite.ValorDiaria / 100) * 10) ;

                diaria *= DiasReservados;
            }
            else
            {
                diaria = DiasReservados * Suite.ValorDiaria;
            }

            return Convert.ToDecimal(String.Format("{0:0.00}", diaria));
        }
    }
}
