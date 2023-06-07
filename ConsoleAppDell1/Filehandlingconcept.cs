using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDell1
{
    internal class Filehandlingconcept
    {
        static void Main()
        {

            //FileInfo f1 = new FileInfo("C:\\var\\auscalamf_Cporder\\New Text Document");
            //Console.WriteLine(f1.FullName);
            //Console.WriteLine(f1.Extension); 
            //Console.WriteLine(f1.CreationTime.ToString());
            //Console.ReadLine();

            //string roo1 = "C:\\var\\auscalamf_Cporder";
            //string[] filenames=Directory.GetFiles(roo1);
            //foreach (string fnames in filenames) {
            //Console.WriteLine(fnames);
            //    Console.ReadLine();

                string dir= Directory.GetCurrentDirectory();

                string filename = dir + "//data.txt";
                if (File.Exists(filename)) 
                {
                    Console.WriteLine(filename+"exist");
                }
                else
                {
                    Console.WriteLine(filename + "not exist");
                }
                



                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine("first line");
                    sw.WriteLine("second line");
                    sw.WriteLine("third line");
                }

                Console.WriteLine(filename+ "created");
                Console.ReadLine();
            string[] lines=File.ReadAllLines(filename); 
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


            Console.ReadLine();

            string lines2=File.ReadAllText(filename);
            Console.WriteLine(lines2);
            Console.ReadLine();


           
        }
             
        }
    }

