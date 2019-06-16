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
    public partial class frm_HinhChuNhat : Form
    {
        public frm_HinhChuNhat()
        {
            InitializeComponent();
        }

        private void frm_HinhChuNhat_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            int DienTich = 0;
            int chieudai = int.Parse(txt_ChieuDai.Text);
            int chieurong = int.Parse(txt_ChieuRong.Text);
            DienTich = chieudai * chieurong;
            txt_KetQua.Text = DienTich.ToString();
        }
    }
}
