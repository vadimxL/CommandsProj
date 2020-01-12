using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Commands
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create a new sorted dictionary of strings, with string keys
            SortedDictionary<string, Command> cmds =
                new SortedDictionary<string, Command>();

            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
            string path = @"CDHD -Commands.txt";
            if ( File.Exists(path) )
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(path);
                char delimiter = ',';

                foreach (string line in lines)
                {
                    // Add some elements to the dictionary. There are no 
                    // duplicate keys, but some of the values are duplicates.
                    string[] words = line.Split(delimiter);
                    Command cmd = new Command(words);
                    cmds.Add(words[0], cmd);

                }
            }


            Form1 form1 = new Form1();

            form1.SetCmdNameComboBox(ref cmds);

            Application.Run(form1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}
