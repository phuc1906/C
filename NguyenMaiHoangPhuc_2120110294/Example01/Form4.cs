using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);
            int kq = x + y;
            tbKetQua.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}