using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();//declaração de uma lista
            //add adciona item no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("BOb");
            list.Add("Ana");
            list.Insert(2, "Marco");//adciona item numa posição indicada

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);//faz a contagem de itens na lista

            string s1 = list.Find(Test);//função que chama outra função
            string s2 = list.Find(x => x[0] == 'B');//expressão lambda
            Console.WriteLine("First 'A' : " + s1);
            Console.WriteLine("First 'B': " + s2);

            string s3 = list.FindLast(x => x[0] == 'M');//encontra o ultimo elemento utilizando a função simplificada LAMBDA
            Console.WriteLine("Last 'M': " + s3);


            int posP = list.FindIndex(x => x[0] == 'A');//encontra a primeira posição com string iniciada com 'A'
            int posU = list.FindLastIndex(x => x[0] == 'A');//encontra a ultima posição com string iniciada com 'A'
            Console.WriteLine("Primeira posição 'A': " + posP);
            Console.WriteLine("Ultima posição: 'A': " + posU);

            //filtrar lista é criar uma nova lista com os itens já filtrados

            List<string> list2 = list.FindAll(x => x.Length == 5);//criando lista com nomes com 5 caracteres pegando os valores da lista anterior
            Console.WriteLine("-------------------");
            foreach (string obj in list2)//todos objetos em list2
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(2);//remover um item da lista através da sua posição
            Console.WriteLine("-------------------");
            foreach (string obj in list)//todos objetos em list2
            {
                Console.WriteLine(obj);

            }
            list.RemoveRange(2,2);//a partir da posição 2 ele remove 2 elementos
            Console.WriteLine("-------------------");
            foreach (string obj in list)//todos objetos em list2
            {
                Console.WriteLine(obj);

            }

            /*list.Remove("Alex");//remover um item da lista
            Console.WriteLine("-------------------");
            foreach (string obj in list)//todos objetos em list2
            {
                Console.WriteLine(obj);
            }*/


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------");
            Console.WriteLine("ITENS REMOVIDOS");
            foreach (string obj in list)//todos objetos em list2
            {
                Console.WriteLine(obj);
            }

            
            //funcao criada para s1
            static bool Test(string s)
            {
                return s[0] == 'A';
            }
        }
    }
}