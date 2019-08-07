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

            if (!File.Exists("hl.exe"))
            {
                MessageBox.Show("Фатальная ошибка: Файл hl.exe не найден. Поместите лаунчер в корень игры.");
                Term();
            }

            if (!Directory.Exists("valve"))
            {
                MessageBox.Show("Фатальная ошибка: Папка valve не найдена. Проверьте ваш дистрибутив игры.");
                Term();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherForm());
        }

        static void Term()
        {
            StreamReader sr = new StreamReader("debugmode.hla");
            int debug = Int32.Parse(sr.ReadToEnd());
            sr.Close();

            if (debug == 0)
            {
                Environment.Exit(0);    
            }
        }

    }
}
