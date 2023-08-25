using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_CORUJA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ATIVIDADE 1 CORUJA");
            int i_nro1 = 0;
            Console.Write("digite um numero inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("SEU ANTECESSOR É {0}", i_nro1 + 1);
           
            Console.WriteLine("SEU SUCESSOR É {0}", i_nro1 - 1);
            Console.ReadLine();

            
            Console.WriteLine("\n\nATIVIDADE 2 CORUJA");
            string s_nome = "";
            Console.Write("DIGITE SEU NOME: ");
            s_nome = Console.ReadLine();
            string s_endr = "";
            Console.Write("DIGITE SEU ENDEREÇO: ");
            s_endr = Console.ReadLine();
            string s_tele = "";
            Console.Write("DIGITE SEU TELEFONE: ");
            s_tele = Console.ReadLine();


            Console.WriteLine("\nNOME: {0}",s_nome);
            Console.WriteLine("ENDEREÇO: {0}", s_endr);
            Console.WriteLine("TELEFONE: {0}", s_tele);
            Console.ReadLine();
            

            Console.WriteLine("\n\nATIVIDADE 3 CISNEI");
            int i_nro3 = 0, i_nro2 = 0;
            Console.Write("digite um numero inteiro: ");
            i_nro3 = int.Parse(Console.ReadLine());
            Console.Write("digite outro numero inteiro: ");
            i_nro2 = int.Parse(Console.ReadLine());
            Console.WriteLine("SOMA DOS NUMEROS INTEIROS {0}", i_nro2 + i_nro3);
            Console.WriteLine("SOMA DOS NUMEROS INTEIROS {0}", i_nro2 - i_nro3);
            Console.WriteLine("MULTIPLICAÇAO DOS NUMEROS INTEIROS {0}", i_nro2 * i_nro3);
            Console.ReadLine();


            Console.WriteLine("\n\nATIVIDADE 4 CORUJA");
            double d_peso = 0, d_alt = 0;
            Console.Write("digite sua altura: ");
            d_alt = double.Parse(Console.ReadLine());
            Console.Write("digite seu peso: ");
            d_peso = double.Parse(Console.ReadLine());
            Console.Write("o valor do seu IMC é {0}", d_peso / Math.Pow(d_alt,2) );
            Console.ReadLine();




        }
    }
}
