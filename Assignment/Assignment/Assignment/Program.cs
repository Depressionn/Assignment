using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment {
    class Program {
        static void Main(string[] args) {

            const string PATH = "C:\\Users\\Potatoe\\Desktop\\sch stuff\\MRT.txt";
            if (!File.Exists(PATH)) {
                Console.WriteLine("File does not exists...\nExiting...");
                Console.ReadKey();
                return;
            }
            string[] lines = File.ReadAllLines(PATH);
            //puts each line into one element of line array
            
            for(int count = 0; count <= lines.Length - 1; count++) {
                Console.WriteLine(lines[count]);
            }

            Console.ReadKey();
        }//end main

    }//end class

}
