using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_AGUIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("ATIVIDADE 1 AGUIA");
            int i_nro1 = 0;
            Console.Write("digite um numero inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\ntabuada do {0}", i_nro1);
            Console.WriteLine("{1} x 1 = {0}", i_nro1 * 1, i_nro1);
            Console.WriteLine("{1} x 2 = {0}", i_nro1 * 2, i_nro1);
            Console.WriteLine("{1} x 3 = {0}", i_nro1 * 3, i_nro1);
            Console.WriteLine("{1} x 4 = {0}", i_nro1 * 4, i_nro1);
            Console.WriteLine("{1} x 5 = {0}", i_nro1 * 5, i_nro1);
            Console.WriteLine("{1} x 6 = {0}", i_nro1 * 6, i_nro1);
            Console.WriteLine("{1} x 7 = {0}", i_nro1 * 7, i_nro1);
            Console.WriteLine("{1} x 8 = {0}", i_nro1 * 8, i_nro1);
            Console.WriteLine("{1} x 9 = {0}", i_nro1 * 9, i_nro1);
            Console.WriteLine("{1} x 10 = {0}", i_nro1 * 10,i_nro1);
            Console.ReadLine();
            #endregion

            
            Console.WriteLine("ATIVIDADE 2 AGUIA");
            double d_qua = 0;
            Console.WriteLine("Digite a quantidade de Laudas:");
            d_qua  = double.Parse(Console.ReadLine());

            double d_vl = 50.00;
            double d_vt = d_qua * d_vl;

            Console.WriteLine("Valor total encontrado: {0} R$  ",d_vt);

            int i_nu = 3;
            double d_vp = d_vt / i_nu;

            Console.WriteLine("Valor da parcela (em três iguais): {0} R$",d_vp);
            Console.ReadLine();
            

            Console.WriteLine("ATIVIDADE 3 AGUIA");
            string s_nome = "";
            Console.Write("DIGITE SEU NOME: ");
            s_nome = Console.ReadLine();
            Console.Write("Boas-vindas {0}",s_nome);
            Console.Write("\nTecle ENTER para finalizar");
            Console.ReadLine();
        }
    }
}
