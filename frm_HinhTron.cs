using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCPTTKHT
{
    public partial class frm_HinhTron : Form
    {
        public frm_HinhTron()
        {
            InitializeComponent();
        }

        private void btn_DienTich_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double Dientich = 0;
            double bankinh = double.Parse(txt_BanKinh.Text);
            Dientich = bankinh * pi;
            txt_KetQua.Text = Dientich.ToString();
        }
    }
}
