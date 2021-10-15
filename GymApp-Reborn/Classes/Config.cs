using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp_Reborn
{
    public class Config
    {
        public static string sFilePath { get; set; }

        public static void Load()
        {
            try
            {
                string[] lines = File.ReadAllLines("gymapp.cfg");
                sFilePath = lines[0];
            }

            catch(Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }

        public static void Save(int lastDay)
        {
            try 
            { 
                string[] lines = new string[2];
                lines[0] = sFilePath;
                File.WriteAllLines("gymapp.cfg", lines);
            }

            catch(Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }
    }
}
