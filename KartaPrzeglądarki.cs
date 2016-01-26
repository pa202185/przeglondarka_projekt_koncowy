using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class KartaPrzeglądarki : UserControl
    {
        public KartaPrzeglądarki()
        {
            InitializeComponent();
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            webPrzegladarka.GoBack();
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            webPrzegladarka.GoForward();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            webPrzegladarka.Refresh();
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                webPrzegladarka.Navigate(txtAdres.Text);
             
        }

        private void webPrzegladarka_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAdres.Text = webPrzegladarka.Url.ToString();
            (Parent as TabPage).Text = webPrzegladarka.Url.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webPrzegladarka.Navigate(txtAdres.Text);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AUTOR Miłosz Kraska INDEKS 202185 ROK 2016");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
