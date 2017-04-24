using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kod_and_Dekod19._04._17
{
    class Program
    {
        static char[,] Kod(string text)
        {
            Random x = new Random();

            char[] arra = new char[text.Length];
            int[,] erre = new int[text.Length,2];
            char[,] trrt = new char[text.Length,2];


            for (int i = 0; i < text.Length; i++)
            {
                arra[i] = Convert.ToChar(text[i]);
            }

            for (int i = 0; i < arra.Length; i++)
            {
                erre[i,0] = (int)arra[i];
                erre[i,1] = x.Next(10) ;
                erre[i, 0] = erre[i, 0] + erre[i, 1];
            }

            for (int i = 0; i < text.Length; i++)
            {
                trrt[i,0] = Convert.ToChar(erre[i,0]);
                trrt[i, 1] = Convert.ToChar(erre[i,1]);
            }
        
            return trrt;
            
        }



        static char[] Dekod(char[,] Kod)
        {
            int[] erre = new int[Kod.Length/2];
            char[] trrt = new char[Kod.Length/2];

             for (int i = 0; i < Kod.Length / 2; i++)
            {
               // erre[i,0] = (int)Kod[i,0];
                erre[i] = (int)Kod[i, 0] - (int)Kod[i, 1];
            }

            for (int i = 0; i < Kod.Length / 2; i++)
            {
                trrt[i] = Convert.ToChar(erre[i]);
            }

            return trrt;
        }



        static void Main(string[] args)
        {
            // string text = File.ReadAllText(@"C:\Users\student\Desktop\Kolobok.txt");

            string text = "колобок";

            Console.WriteLine((text));

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(Kod(text)[i, 0]);
            }

            Console.Write("\r\n");

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(Dekod(Kod(text))[i]);
            }

            Console.ReadKey();
            }
    }
}
