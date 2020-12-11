using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empty_Click(object sender, EventArgs e)
        {

        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            lbl_empty.Text = tb_pesan.Text;
            {
                if (tb_pesan.Text == "hide")
                    lbl_empty.Hide();
                if (tb_pesan.Text == "shown")
                    lbl_empty.Show();
                if (tb_pesan.Text == "delete")
                    lbl_empty.Text = "[EMPTY]";
                if (tb_pesan.Text == "blue")
                    lbl_empty.ForeColor = Color.Blue;
                if (tb_pesan.Text == "red")
                    lbl_empty.ForeColor = Color.Red;
                if (tb_pesan.Text == "green")
                    lbl_empty.ForeColor = Color.Green;
            }
        }
    }
}
