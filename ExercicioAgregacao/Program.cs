using System.Drawing;
using System;
using System.Globalization;
using System.Data;
using System.IO;

namespace ExercicioAgregação
{
    class Program
    {
        static void Main(string[] args)
        {
            listaProduto();
            colecaoChave();
            Console.ReadKey();
        }

        static void colecaoChave()
        {
            /* Criar uma coleção com chave do tipo string recebendo o nome de uma 
             pessoa e no valor armazenar um objeto do tipo pessoa. */

            Pessoa nome1 = new Pessoa()
            {
                Id = 1,
                NomePessoa = "Karina",
                Cpf = "088.254.449-74",
                Email = "karina@gmail.com",
                Telefone = "(47)99616-1518"
            };

            Pessoa nome2 = new Pessoa()
            {
                Id = 2,
                NomePessoa = "Luana",
                Cpf = "254.256.215-00",
                Email = "luana@gmail.com",
                Telefone = "(47)98452-2356"
            };

            SortedList<string, Pessoa> nomes = new SortedList<string, Pessoa>();
            nomes.Add(nome1.NomePessoa, nome1);
            nomes.Add(nome2.NomePessoa, nome2);

            Console.WriteLine(nomes.Keys.ToArray()[0]);
            Console.WriteLine(nomes.Keys.ToArray()[1]);
            Console.WriteLine("");

            Object[] pessoascadastradas = nomes.Values.ToArray();
            for (int i = 0; i < pessoascadastradas.Length; i++)
            {
                Pessoa pessoa = (Pessoa)pessoascadastradas[i];
                Console.WriteLine($"Id: {pessoa.Id}");
                Console.WriteLine($"Nome: {pessoa.NomePessoa}");
                Console.WriteLine($"CPF: {pessoa.Cpf}");
                Console.WriteLine($"E-mail: {pessoa.Email}");
                Console.WriteLine($"Telefone: {pessoa.Telefone}");
                Console.WriteLine("");
            }
        }

        static void listaProduto()
        {
            /* Criar uma coleção que armazena uma lista de produtos. Não deve permitir informar produtos duplicados. */

            List<Produto> listaproduto = new List<Produto>();
            listaproduto.Add(new Produto() { Id = 1, DescricaoProduto = "Maria" });
            
        }

        static void categoriaProduto()
        {
            /* Criar uma coleção que permita informar a categoria de um produto como chave e armazenar uma lista de produtos da respectiva categoria. */


        }
    }
}