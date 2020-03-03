using System;
using System.IO;

namespace UsingBlock {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\file1.txt";

            try {
                //quando usamos o bloco using, nós
                //instanciamos os nossos recursos
                //e tudo que estiver dentro do bloco
                //será executado e logo após, na saída do bloco
                //todos os recursos serão fechados!
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    //podemos usar cascatas de blocos using. 
                    using (StreamReader sr = new StreamReader(fs)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }//final do subbloco using
                }//final do bloco using
            }
            catch (IOException e) {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
