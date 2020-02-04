using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Program
    {   
        static void Main(string[] args)
        {
            char[,] Tábla=new char[10,10];
            Feltöltés(Tábla);
            Kirajzoló(Tábla);
            
            Console.ReadKey();

        }
        static void Feltöltés(char[,]Tábla)
        {
            for (int sor = 0; sor < Tábla.GetLength(0); sor++)
			{
                for (int oszlop = 0; oszlop < Tábla.GetLength(1); oszlop++)
			    {
                    Tábla[sor,oszlop]= '_';
                }
			} 
            Random gép= new Random();
            int x2;
            int x;
            for (int sor = 0; sor < 10; sor++)
			{
                 do
	             {
                    x=gép.Next(1,10);
                    x2=gép.Next(1,10);
	             } while (Tábla[x,x2]=='B');
                Tábla[x,x2]='B';
			}

        }
        static void Kirajzoló(char[,]Tábla)
        {  
            Console.BackgroundColor=ConsoleColor.DarkBlue;
            Console.ForegroundColor=ConsoleColor.White;
            for (int sor = 0; sor <Tábla.GetLength(0); sor++)
			{
                for (int oszlop = 0; oszlop < Tábla.GetLength(1); oszlop++)
			    {
                    Console.Write($"{Tábla[sor,oszlop]}|");

			    }
                Console.WriteLine();
			}
        
        
        }
    }
}
