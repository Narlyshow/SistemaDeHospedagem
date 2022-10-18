using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeHospedagem.BackEnd.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
