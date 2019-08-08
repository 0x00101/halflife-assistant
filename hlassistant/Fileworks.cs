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
    }
}
