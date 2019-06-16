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
    public partial class frm_HinhVuong : Form
    {
        public frm_HinhVuong()
        {
            InitializeComponent();
        }

        private void frm_HinhVuong_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            int DienTich = 0;
            int canh = int.Parse(txt_Canh.Text);
            DienTich = canh * canh;
            txt_KetQua.Text = DienTich.ToString();
        }
    }
}
