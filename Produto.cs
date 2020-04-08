using System;
using System.Collections.Generic;
using System.Text;

namespace Mercearia
{
    class Produto
    {

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Id { get; set; }

        public int Quantidade { get; set; }

        public void Salvar()
        {
            Produto.produtos.Add(this);
        }

        public void Remover()
        {
            Produto.produtos.Remove(this);
        }

        public static List<Produto> produtos = new List<Produto>();

        public static List<Produto> ListaProdutos()
        {
            return Produto.produtos;

        }

        
    public static Produto BuscaPorId(int id)
    {
        foreach (var item in Produto.ListaProdutos())
        {
            if (id == item.Id)
            {
                return item;
            }

        }

        return null;
    }
    }

}

    





