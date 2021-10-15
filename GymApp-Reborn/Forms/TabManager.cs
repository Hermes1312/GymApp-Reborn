using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp_Reborn
{
    public partial class TabManager : Form
    {
        int         action      = default, addDir = default;
        TabPage     page        = default;
        TabControl  tabControl  = default;
        public TabManager(int _action, TabPage _page = null, TabControl _tabControl = null, int _addDir = 0)
        {
            InitializeComponent();

            action      = _action;
            page        = _page;
            tabControl  = _tabControl;
            addDir      = _addDir;
        }

        private void ChangeName()
        {
            page.Text = guna2TextBox1.Text;
        }

        private void AddNew()
        {
            // 0 przed - 1 po

            TabPage aPage = new TabPage();
            aPage.Text = guna2TextBox1.Text;
            aPage.Controls.Add(GymAppControls.DataGridView());

            int i = addDir == 0 ? tabControl.SelectedIndex : tabControl.SelectedIndex + 1;

            tabControl.TabPages.Insert(i, aPage);
        }

        private void exitControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case 0:
                    ChangeName();
                    Close();
                    break;

                case 1:
                    AddNew();
                    Close();
                    break;
                    
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
