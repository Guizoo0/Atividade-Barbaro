using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ATIVIDADE_CISNE
            
            Console.WriteLine("ATIVIDADE 1 CISNEI");
            int i_nro1 = 0, i_nro2 = 0;
            Console.Write("digite um numero inteiro: ");
                i_nro1 = int.Parse(Console.ReadLine());
            Console.Write("digite outro numero inteiro: ");
                i_nro2 = int.Parse(Console.ReadLine());
            Console.Write("SOMA DOS NUMEROS INTEIROS:  {0}", i_nro1 + i_nro2);
            Console.ReadLine();
            
            #endregion

            #region atividade2
            Console.WriteLine("ATIVIDADE 2 CISNEI");
            double x = 0;
            Console.Write("digite um numero REAL: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("A Terça parte desse numero é :  {0}", x / 3 );
            Console.ReadLine();
            #endregion
            
            #region atividade3

            Console.WriteLine("ATIVIDADE 3 CISNEI");
            double d_nro2 = 0;
            double d_nro1 = 0;
            Console.Write("Digite um numero REAL: ");
            d_nro1 = double.Parse(Console.ReadLine());
            Console.Write("Digite Outro numero REAL: ");
            d_nro2 = double.Parse(Console.ReadLine());
            Console.Write("A Media dos numeros REAL é {0}", ((d_nro1 + d_nro2)) / 2);
            Console.ReadLine();
            #endregion

            #region atividade4

            Console.WriteLine("ATIVIDADE 4 CISNEI");
            double x3 = 0;
            Console.Write("Digite um saldo: R$ ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("O reajuste do saldo será:  {0:c}", x3 * 1.01 );
            Console.ReadLine();
            #endregion

            #region atividade5
            Console.WriteLine("ATIVIDADE 5 CISNEI"); 
            double d_PROVA1 = 0;
            double d_PROVA2 = 0;
            double d_PROVA3 = 0;
            double d_PROVA4 = 0;
            Console.Write("Digite a nota da primeira prova: ");
            d_PROVA1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            d_PROVA2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            d_PROVA3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            d_PROVA4 = double.Parse(Console.ReadLine());
            Console.Write("A Media final é {0}", ((d_PROVA1 + d_PROVA2 + d_PROVA3 + d_PROVA4 )) / 4);
            Console.ReadLine();
            #endregion






        }
    }
}