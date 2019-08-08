using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace hlassistant
{
    class LogBuilder
    {
        Fileworks fw = new Fileworks();
        public void Init(string filename)
        {
            string version = fw.ReadStr("hla_base/version.txt");

            FileStream aFile = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine("Half-Life Assistant" + version);
            sw.Close();
        }
    }
}
