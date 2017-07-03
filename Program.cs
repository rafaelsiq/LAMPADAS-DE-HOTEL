using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace OLP2016_HOTEL
{
    class Program
    {
        static void Main(string[] args)
        {
            int IA=0, IB = 0, FA = 0, FB = 0, C1=0, C2=0;
            FileStream arq = new FileStream("ENTRADA.txt", FileMode.Open);
            String linha;
            StreamReader ler = new StreamReader(arq);
            
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    String[] quebra = linha.Split(' ','.',',',';',':','-');

                    IA = Convert.ToInt32(quebra[0]);
                    IB = Convert.ToInt32(quebra[1]);
                    FA = Convert.ToInt32(quebra[2]);
                    FB = Convert.ToInt32(quebra[3]);
                }
            } while (linha != null);
            ler.Close();

                                                    while (IB != FB)
                                                    {
                                                        IB = (-1 * IB + 1);
                                                        IA = (-1 * IA + 1);
                                                        C2++;
                                                    }
                                                    while (IA != FA)
                                                    {
                                                         IA = (-1 * IA+  1);
                                                         C1++;
                                                    }

            FileStream SAIDA = new FileStream("SAIDA.txt", FileMode.Create);
            StreamWriter escrever = new StreamWriter(SAIDA);
            escrever.WriteLine(C1+C2);
            escrever.Close();
        }
    }
}
