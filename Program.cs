using System;

namespace Mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo Joao! Voçê tem: " + Produto.ListaProdutos().Count + "Produtos. O que voçe deseja fazer? ");

            while (true)
            {
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Remover");
                Console.WriteLine("3- Listar");
                Console.WriteLine("4- Sair");
                Console.WriteLine("Selecione a opçao");
                var opcao = Convert.ToInt16(Console.ReadLine());
                if (opcao == 4) break;
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastre o nome do produto");
                        var prod = new Produto();
                        prod.Nome = Console.ReadLine();
                        Console.WriteLine("Cadastre o preco do produto");
                        prod.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Cadastre o id do produto");
                        prod.Id = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Cadastre a quantidade do produto");
                        prod.Quantidade = Convert.ToInt16(Console.ReadLine());

                        prod.Salvar();
                        break;

               
                    case 2:
                        MostraLista();
                        Console.WriteLine("Digite o Id do produto que deseja excluir");
                        var lixo = Convert.ToInt16(Console.ReadLine());

                        var produto = Produto.BuscaPorId(lixo);
                        if (produto != null) produto.Remover();
                        else Console.WriteLine("Produto não encontradao");
                        break;

                    case 3:

                        MostraLista();
                        Console.ReadLine();
                        break;
                }
            } Console.Clear();
        }
private static  void MostraLista()
{
                        var lista = Produto.ListaProdutos();
                        foreach (var item in lista)
                        {
                            Console.WriteLine("Nome: "  + item.Nome);
                            Console.WriteLine("Preco: " + item.Preco);
                            Console.WriteLine("id: " + item.Id);
                            Console.WriteLine("Quantidade: " + item.Quantidade);
                            Console.WriteLine("=============================");
                        }

}
    }
}
