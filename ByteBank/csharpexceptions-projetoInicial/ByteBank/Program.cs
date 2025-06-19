using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException e)
			{
                Console.WriteLine("Ocorreu uma execao do tipo ArgumentException: ");
                Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
                Console.Write(e.Message);
			}

            



            Console.WriteLine("Execucao finalizada.");
            Console.ReadLine();
        }
    }
}
