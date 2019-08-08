using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace hlassistant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogBuilder lb = new LogBuilder();
            lb.Init("hla_base/log/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " " + DateTime.Now.Hour + "-" + DateTime.Now.Minute + ".log");

            if (!File.Exists("hl.exe"))
            {
                MessageBox.Show("Фатальная ошибка: Файл hl.exe не найден. Поместите лаунчер в корень игры.");
                lb.AddLine("[fatal_error] File hl.exe isn't exists. ");
                Term();
            }

            if (!Directory.Exists("valve"))
            {
                MessageBox.Show("Фатальная ошибка: Папка valve не найдена. Проверьте ваш дистрибутив игры.");
                lb.AddLine("[fatal_error] valve folder isn't exists. ");
                Term();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherForm());
        }

        static void Term(bool printinlogbuilder = true)
        {
            Fileworks fw = new Fileworks();
            LogBuilder lb = new LogBuilder();
            int debug = fw.ReadInt("hba_base/DebugMode.parm");

            if (debug == 0)
            {
                if (printinlogbuilder == true)
                {
                    lb.AddLine("Terminating...");
                }

                Environment.Exit(0);    
            }
        }

    }
}
