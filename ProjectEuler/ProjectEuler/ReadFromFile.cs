using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ReadFromFile
    {
        private string NumStr;
        public string NumberString
        {
            set
            {
                NumStr = value;
            }
            get
            {
                return NumStr;
            }
        }

        private string[] LineStr;
        public string[] LineString
        {
            set
            {
                LineStr = value;
            }
            get
            {
                return LineStr;
            }
        }
        public ReadFromFile()
        {

        }
        public ReadFromFile(string str)
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            string path = @"C:\git\CSharp\ProjectEuler\ProjectEuler\" + str + ".txt";
            string text = System.IO.File.ReadAllText(path);
            NumStr = text;

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of SomeText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(path);
            LineStr = lines;
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
