using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            int idade;
            


           Console.WriteLine(" Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($" Agora digite seu SEGUNDO nome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine($" Digite sua idade");
            idade = Int32.Parse(Console.ReadLine());
            

            Console.WriteLine($"Seja bem-vindo {nome} {sobrenome}");
            Console.WriteLine($" Você tem {idade} anos!");


            Console.ReadKey();


        }   
        
        
        
        
        
        
        
        
        


         void Atividade()
        {
            float hamburguer = 2.00f;
            float salsicha = 1.50f;
            float lanche = 8.00f;
            float requeijão = 1.50f;
            float bacon = 2.00f;

            float soma = hamburguer + bacon + salsicha + lanche;
            float soma2 = requeijão + salsicha + salsicha + lanche;
            float soma3 = hamburguer + salsicha + requeijão + bacon + lanche;

            float total = soma + soma2 + soma3;

            Console.WriteLine(" Bem vindo ao catálago digital do Conradito Lanches");
            Console.WriteLine(" Confira os valores \n ");
            Console.WriteLine($" X-Tudo: hamburguer, bacon e salsicha -  R${soma}");

            Console.WriteLine($" Cachorro-quente cremoso: 2 salsichas e requeijão -  R${soma2} ");
            Console.WriteLine($" A moda da casa: salsicha, hamburguer, requeijão e bacon - R${soma3} \n ");
            Console.WriteLine($" X-Tudo + Cachorro-quente cremoso + A moda da casa - R${total} ");
























            Console.ReadKey();
        }
    }
}
