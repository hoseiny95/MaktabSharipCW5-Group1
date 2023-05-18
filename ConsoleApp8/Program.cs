// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // See https://aka.ms/new-console-template for more information
            string text = Console.ReadLine();
            string check = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (check == "encoding")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        char ch = (char)(((int)text[i] +
                                    num - 65) % 26 + 65);
                        //Console.WriteLine("if  " +ch);
                        Console.Write(ch);

                    }
                    else
                    {
                        char ch = (char)(((int)text[i] +
                                   num - 97) % 26 + 97);
                        //Console.WriteLine("else " + ch);

                        Console.Write(ch);
                    }
                }
            }
            if (check == "decoding")

            {
                
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsUpper(text[i]))
                    {
                        
                        char ch = (char)(((int)text[i] +
                                    26-num - 65) % 26 + 65);
                        
                        Console.Write(ch);

                    }
                    else
                    {
                        
                        char ch = (char)(((int)text[i] +
                                  26- num - 97) % 26 + 97);
                        

                        Console.Write(ch);
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            




        }

    }
}