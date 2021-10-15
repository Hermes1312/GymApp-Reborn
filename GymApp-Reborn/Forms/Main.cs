using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.IO;

namespace GymApp_Reborn
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
            public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public int mouseLeave = 0;

        Color appColor = Color.FromArgb(33, 42, 57);
        public Plan.Root plan = default;

        public static void SetTabText(TabPage page, string text) => page.Text = text;

        public Main()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            try
            {
                foreach (TabPage nPage in tabControl.TabPages)
                    tabControl.TabPages.Remove(nPage);
            }

            catch (Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }

        private void NewPlan()
        {
            try
            {
                ClearForm();

                TabPage page = new TabPage();
                page.Text = "Nowy dzień";
                page.Controls.Add(GymAppControls.DataGridView());

                tabControl.TabPages.Add(page);
            }

            catch (Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }

        private void LoadPlanIntoForm()
        {
            try
            {

                for (int i = 0; i < plan.days.Count; i++)
                {
                    tabControl.TabPages.Add(plan.days[i].name);
                    //tabControl.TabPages[i].MouseClick
                    Guna2DataGridView gridView = GymAppControls.DataGridView();

                    for (int j = 0; j < plan.days[i].workouts.Count; j++)
                    {
                        JArray wrk = (JArray)plan.days[i].workouts[j];
                        gridView.Rows.Add(new[] { wrk[0], wrk[1], wrk[2], wrk[3] });
                    }

                    tabControl.TabPages[i].Controls.Add(gridView);
                }
            }

            catch (Exception e)
            {
                Main.ErrorMsg(e.ToString());
            }
        }

        private Plan.Root PlanFromForm()
        {
            try
            {
                Plan.Root sPlan = new Plan.Root();
                sPlan.days = new List<Plan.Day>();

                for (int i = 0; i < tabControl.TabPages.Count; i++)
                {
                    Guna2DataGridView sGridView = (Guna2DataGridView)tabControl.TabPages[i].Controls[0];

                    Plan.Day sDay = new Plan.Day();
                    sDay.name = tabControl.TabPages[i].Text;

                    List<object> sWorkouts = new List<object>();

                    for (int j = 0; j < sGridView.Rows.Count; j++)
                        sWorkouts.Add(new[] { sGridView.Rows[j].Cells[0].Value, sGridView.Rows[j].Cells[1].Value, sGridView.Rows[j].Cells[2].Value, sGridView.Rows[j].Cells[3].Value });

                    sDay.workouts = sWorkouts;

                    sPlan.days.Add(sDay);
                }

                return sPlan;
            }

            catch (Exception e)
            {
                ErrorMsg(e.ToString());
                return null;
            }
        }

        private void MoveTab(int direction)
        {
            if (direction == 0)
            {
                int index = tabControl.SelectedIndex;
                TabPage cTab = tabControl.SelectedTab;


                if (index > 0)
                {
                    tabControl.TabPages.Remove(cTab);
                    tabControl.TabPages.Insert(index - 1, cTab);
                    tabControl.TabPages[index - 1].Select();
                }
            }

            else
            {
                int index = tabControl.SelectedIndex;
                TabPage cTab = tabControl.SelectedTab;


                if (index < tabControl.TabPages.Count - 1)
                {
                    tabControl.TabPages.Remove(cTab);
                    tabControl.TabPages.Insert(index + 1, cTab); 
                    tabControl.TabPages[index + 1].Select();
                }
            }

        }

        #region Events
        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists("gymapp.cfg"))
            {
                Config.Load();
                plan = Plan.Load(Config.sFilePath);
                LoadPlanIntoForm();
            }

            else
            {
                NewPlan();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e) => Environment.Exit(-1);

        private void minimizeControl_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selected = (sender as Guna.UI2.WinForms.Guna2ComboBox).SelectedIndex;

                switch (selected)
                {
                    // new
                    case 1:
                        menu.SelectedIndex = 0;
                        NewPlan();
                        break;

                    // load
                    case 2:
                        menu.SelectedIndex = 0;
                        OpenFileDialog ofd = new OpenFileDialog();

                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            plan = Plan.Load(ofd.FileName);

                            File.WriteAllText("gymapp.cfg", $"{ofd.FileName}");
                            Config.Load();


                            ClearForm();
                            LoadPlanIntoForm();
                        }
                        break;

                    // save
                    case 3:
                        menu.SelectedIndex = 0;
                        DialogResult result = MessageBox.Show($"Czy napewno chcesz zapisać do pliku {Config.sFilePath}?", "GymApp", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                            Plan.Save(PlanFromForm());

                        break;

                    // save as
                    case 4:
                        menu.SelectedIndex = 0;
                        Plan.Save(PlanFromForm(), true);
                        break;
                }
            }

            catch (Exception ex)
            {
                Main.ErrorMsg(ex.ToString());
            }
        }

        public static void ErrorMsg(string text) => MessageBox.Show(text, "GymApp - Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void daysContext_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {

                int indx = tabControl.SelectedIndex;

                switch (e.ClickedItem.Name)
                {
                    case "toolChangeName":
                        new TabManager(0, tabControl.TabPages[indx]).Show();
                        break;

                    case "toolUp":
                        MoveTab(0);
                        break;

                    case "toolDown":
                        MoveTab(1);
                        break;

                    case "toolRemove":
                        tabControl.TabPages.Remove(tabControl.TabPages[indx]);
                        break;

                    case "toolAddBefore":
                        new TabManager(1, tabControl.TabPages[indx], tabControl, 0).Show();
                        break;

                    case "toolAddAfter":
                        new TabManager(1, tabControl.TabPages[indx], tabControl, 1).Show();
                        break;
                }
            }

            catch (Exception ex)
            {
                Main.ErrorMsg(ex.ToString());
            }
        }

       
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //loadingCircle.Hide();
           //loadingLabel.Hide();

            bar.Size = new Size(913, 32);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e) { }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tabControl.TabPages[1].Select();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void exitControl_MouseEnter(object sender, EventArgs e)
        {
            (sender as Guna2ControlBox).FillColor = ColorTranslator.FromHtml("#A70C00");
        }

        private void exitControl_MouseLeave(object sender, EventArgs e)
        {
            (sender as Guna2ControlBox).FillColor = appColor;
        }

        #endregion

        private void gymappLabel_MouseClick(object sender, MouseEventArgs e)
        {
            menu.Show();
        }
    }
}
