using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordongusu4_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyaz_Click(object sender, EventArgs e)
        {lbsayilar.Items.Clear();

            int baslankıç = Convert.ToInt32(txtBaslanınc.Text);
            int bitis =Convert.ToInt32(txtBıtıs.Text);

            for (int İ = baslankıç;İ <= bitis; İ++ ) 
            {
                lbsayilar.Items.Add(İ);
            }
        }
    }
}
