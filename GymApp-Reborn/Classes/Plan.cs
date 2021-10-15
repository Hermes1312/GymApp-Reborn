using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GymApp_Reborn
{
    public class Plan
    {
        public static Root Load(string path)
        {
            try 
            { 
                Root deserialized = JsonConvert.DeserializeObject<Root>(File.ReadAllText(path));
                return deserialized;
            }

            catch (Exception e)
            {
                Main.ErrorMsg("Spróbuj usunąć plik konfiguracyjny\n\n" + e.ToString());
                Environment.Exit(1);
                return null;
            }
        }

        public static void Save(Root plan, bool saveAs = false)
        {
            try
            {
                string json = JsonConvert.SerializeObject(plan);
                string path = default;

                if (saveAs)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    if (sfd.ShowDialog() == DialogResult.OK)
                        path = sfd.FileName;
                }
                else
                    path = Config.sFilePath;

                File.WriteAllText(path, json);
            }

            catch (Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }

        public class Day
        {
            public string name { get; set; }
            public List<object> workouts { get; set; }
        }

        public class Root
        {
            public List<Day> days { get; set; }
        }
    }
}
