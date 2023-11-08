using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAgregação
{
    class Pessoa
    {
        public int Id { get; set; }
        public string NomePessoa { get; set;}
        public string Cpf { get; set;}
        public string Email { get; set;}
        public string Telefone { get; set; }

        public Pessoa() { }
        public Pessoa(int id, string nomePessoa, string cpf, string email, string telefone)
        {
            Id = id;
            NomePessoa = nomePessoa;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }
    }
}
