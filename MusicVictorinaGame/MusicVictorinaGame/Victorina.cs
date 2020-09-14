using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace MusicVictorinaGame
{
    static class Victorina
    {
        public static List<string> list =new List<string>();
        public static int gameDuration = 60;
        public static int musicDuration = 10;
        public static bool randomStart = false;
        public static string lastFolder = "";
        public static bool allDirectories = false;
        public static string answer = "Показать ответ";

        public static void ReadMusic()
        {
            try
            {
                string[] musicList = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musicList);
            }
            catch
            {
            }
        }
        // Запись параметров в реестр
        private static string regKeyName = "Software\\MyCompanyName\\MusicVictorinaGame";

        public static void WriteOption()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if(rk != null) rk.Close();
            }
        }
        public static void ReadOption()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder= (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    gameDuration= (int)rk.GetValue("GameDuration");
                    musicDuration= (int)rk.GetValue("MusicDuration");
                    allDirectories= Convert.ToBoolean(rk.GetValue("AllDirectories"));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
