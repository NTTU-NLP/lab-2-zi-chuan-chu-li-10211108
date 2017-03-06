using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\..\Data\Input.txt"))
            {
                int a = 0, b = 0, c = 0;
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (!Char.IsWhiteSpace(ch))
                        {
                            if(ch=='.'){
                               Console.Write(ch + "\n");
                               a++;
                            }
                            else if (ch == '?')
                            {
                                Console.Write(ch + "\n");
                                b++;
                            }
                            else if (ch == '!')
                            {
                                Console.Write(ch + "\n");
                                c++;
                            }
                            else
                            {
                                Console.Write(ch);
                            }
                            //Console.Write(ch);
                        }
                        else
                        {
                            Console.Write(ch);
                        }
                    }                    
                }
                //Console.Write('\n' + ". =" + a + '\n' + "? =" + b + '\n' + "! =" + c);
            }
            //Console.Read();
        }
    }
}
