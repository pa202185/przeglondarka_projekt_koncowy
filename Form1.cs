using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabKarty_Click(object sender, EventArgs e)
        {
            if (tabKarty.SelectedTab == tabDodaj)
            {
                KartaPrzeglądarki karta = new KartaPrzeglądarki();
                TabPage page = new TabPage();

                karta.Dock = DockStyle.Fill;

                page.Controls.Add(karta);
                tabKarty.Controls.Add(page);

                tabKarty.TabPages.Remove(tabKarty.SelectedTab);
                tabKarty.TabPages.Add(tabDodaj);

                tabKarty.SelectedIndex = tabKarty.TabCount - 2;
            }

        }
    }
}
