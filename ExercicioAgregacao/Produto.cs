using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAgregação
{
    class Produto
    {
        public int Id { get; set; }
        public string DescricaoProduto { get; set;}

        public Produto() { }
        public Produto(int id, string descricaoProduto)
        {
            Id = id;
            DescricaoProduto = descricaoProduto;
        }
    }
}
