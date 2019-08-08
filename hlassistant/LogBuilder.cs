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
            bool writeinitline = true;

            if (File.Exists(filename))
                writeinitline = false;

            string version = fw.ReadStr("hla_base/version.txt");

            FileStream aFile = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            if (writeinitline == true)
            {
                sw.WriteLine("Half-Life Assistant (version: " + version + ")");
                sw.WriteLine("Log started on " + DateTime.Now);
                sw.WriteLine("");
            }
            sw.Close();

            
            if (File.Exists("hla_base/CurrentInitializedLogFile.txt"))
            {
                File.Delete("hla_base/CurrentInitializedLogFile.txt");
                fw.WriteString("hla_base/CurrentInitializedLogFile.txt", filename);
            }
            
        }

        public void AddLine(string whatshappened, string filename = "nullname13", bool PrintCurrentTime = true)
        {
            //говнокод (такие конструкции надо делать в сишарпе что-бы это работало :/) 
            string InsidedFilename = filename;
            if (filename == "nullname13")
                InsidedFilename = fw.ReadStr("hla_base/CurrentInitializedLogFile.txt");

            FileStream aFile = new FileStream(InsidedFilename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            string DT = ""; 
            if (PrintCurrentTime == true)
            {
                DT = "[" + DateTime.Now + "] ";
            }

            sw.WriteLine(DT + whatshappened);
            sw.Close();
        }

        // это было жестко. но я справился.
    }
}
