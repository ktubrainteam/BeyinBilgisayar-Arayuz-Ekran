using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainTeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timersorular.Enabled = true;

        }
        
        private void btn_sonuc_goster_Click(object sender, EventArgs e)
        {
            Form1 soruekrani = new Form1();
            soruekrani.Close();
            Form2 analizformu = new Form2();
            analizformu.Show();
            this.Hide();
           
        }

        private void timersorular_Tick(object sender, EventArgs e)
        {
            lbl_sorular.Text = lbl_sorular.Text.Substring(1) + lbl_sorular.Text.Substring(0, 1);
        }

        
    }
}
