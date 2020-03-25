using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Dados do Produto {p}");
            Console.WriteLine();
            
            Console.WriteLine("Digite quantos produtos adicionará ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados {p}");


            Console.WriteLine("Digite quantos produtos quer remover do estoque");
            int rem = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rem);
            Console.WriteLine($"Dados Atualizados {p}");

        }
    }
}
