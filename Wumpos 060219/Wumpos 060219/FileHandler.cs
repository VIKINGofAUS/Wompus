using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wumpos_060219
{
    class FileHandler
    {
        public bool openFileAndWriteNumber(string fileName, int buttonNumber)
        {
            // opens the specified file
            string path = @".\Example.txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                TextWriter tw = new StreamWriter(fileName);
                tw.WriteLine(buttonNumber);
                tw.Close();
            }
            else if (File.Exists(fileName))
            {
                TextWriter tw = new StreamWriter(fileName);
                tw.WriteLine(buttonNumber);
                tw.Close();
            }

            return true; //returns if the file has been opened or not
        }

        public bool createFile()
        {
            return false;
        }

    }
}
