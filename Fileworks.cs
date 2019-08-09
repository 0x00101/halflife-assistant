using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace hlassistant
{
    class Fileworks
    {
        public string ReadStr(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            return sr.ReadToEnd().ToString();
        }

        public int ReadInt(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            return Int32.Parse(sr.ReadToEnd());
        }

        public void WriteString(string filename, string content)
        {
            FileStream aFile = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            // aFile.Seek(0, SeekOrigin.End);
            sw.Write(content);
            sw.Close();
        }

    }
}
