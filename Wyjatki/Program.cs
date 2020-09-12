using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                int i = 10, j = 1, k;
                k = i / j;
                sbyte result;
                sbyte x = Convert.ToSByte(Console.ReadLine());
                sbyte y = Convert.ToSByte(Console.ReadLine());
                result = (sbyte)(x + y);
                if (result  < 0 )
                {
                    throw new Exception("Wartosc mniejsza od 0");
                }
            }
            catch (OverflowException exc)
            {
                Console.WriteLine("Przepelnienie: {0} ", exc.Message);
            }
            catch (ArithmeticException exc)
            {
                Console.WriteLine("Wystąpił błąd: {0}", exc.Message);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Zły format: {0}",exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Inne wyjątki: {0}", exc.Message);
                    throw;
            }
            finally
            {
                // zawsze się wykona
                Console.WriteLine("To zawsze sie wykona");
            }
            
            
            Console.ReadKey();
        }
    }
}
