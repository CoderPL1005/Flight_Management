using BusinessLayer;
using DevExpress.XtraEditors;
using FLIGHTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT.Support_Form
{
    public partial class frmChonThoiGianBay : DevExpress.XtraEditors.XtraForm
    {
        Panel panMain;
        public frmChonThoiGianBay(Panel panMain)
        {
            InitializeComponent();
            this.panMain = panMain;
        }
        List<string> city;
        AIRPORT _aiport;
        private bool isUpdatingComboBox = false;
        private void frmChonThoiGianBay_Load(object sender, EventArgs e)
        {
            txtKhoiHanh.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            txtTroVe.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            _aiport = new AIRPORT();
            city = _aiport.getAllCity();
            loadCity();
            cboLoaichuyenBay.Text = cboLoaichuyenBay.Items[0].ToString();
        }

        void loadCity()
        {
            foreach(var item in city)
            {
                cboDiemKhoiHanh.Items.Add(item);
                cboDiemDen.Items.Add(item);
            }
        }

        private void cboDiemKhoiHanh_Click(object sender, EventArgs e)
        {
            cboDiemKhoiHanh.Text = "";

        }

        private void cboDiemDen_Click(object sender, EventArgs e)
        {
            cboDiemDen.Text = "";
        }

        private void cboDiemKhoiHanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBox) return; // Bỏ qua nếu đang cập nhật

            try
            {
                isUpdatingComboBox = true; // Bắt đầu cập nhật
                string diemden = cboDiemDen.Text;

                cboDiemDen.Items.Clear();
                foreach (var item in city)
                {
                    if (item != cboDiemKhoiHanh.Text)
                    {
                        cboDiemDen.Items.Add(item);
                        if (item == diemden)
                        {
                            cboDiemDen.Text = item.ToString();
                        }
                    }
                }
            }
            finally
            {
                isUpdatingComboBox = false; // Kết thúc cập nhật
            }
        }

        private void cboDiemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBox) return; // Bỏ qua nếu đang cập nhật

            try
            {
                isUpdatingComboBox = true; // Bắt đầu cập nhật
                string diemkhoihanh = cboDiemKhoiHanh.Text;

                cboDiemKhoiHanh.Items.Clear();
                foreach (var item in city)
                {
                    if (item != cboDiemDen.Text)
                    {
                        cboDiemKhoiHanh.Items.Add(item);
                        if (item == diemkhoihanh)
                        {
                            cboDiemKhoiHanh.Text = diemkhoihanh;
                        }
                    }
                }
            }
            finally
            {
                isUpdatingComboBox = false; // Kết thúc cập nhật
            }
        }

        private void labSoKhachLoaiGhe_Click(object sender, EventArgs e)
        {
            if (panChonGhe.Visible == true)
            {
                panChonGhe.Visible = false;
            }
            else
            {
                panChonGhe.Visible = true;
                panChonGhe.BringToFront();
                frmSup_GiaoDienKhachHang frm = new frmSup_GiaoDienKhachHang(labSoKhachLoaiGhe, panChonGhe);
                frm.TopLevel = false;
                panChonGhe.Height = frm.Height;
                panChonGhe.Width = frm.Width;
                panChonGhe.Controls.Add(frm);
                frm.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(panThoiGian.Visible == false)
            {
                panThoiGian.Visible = true;
                panThoiGian.BringToFront();
                frmCalendar frm = new frmCalendar(cboLoaichuyenBay.Text, txtKhoiHanh, txtTroVe, panThoiGian);
                frm.TopLevel = false;
                panThoiGian.Height = frm.Height;
                panThoiGian.Width = frm.Width;
                panThoiGian.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                panThoiGian.Visible = false;
            }
        }

        private void cboLoaichuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaichuyenBay.Text == cboLoaichuyenBay.Items[0].ToString())
            {
                txtTroVe.Visible = true;
                labTroVe.Cursor = Cursors.Hand;
            }
            else
            {
                txtTroVe.Visible = false;
                labTroVe.Cursor = Cursors.Default;
            }
        }

        private void butTimkiem_Click(object sender, EventArgs e)
        {
            frmChonVe frm = new frmChonVe(cboLoaichuyenBay.Text, labSoKhachLoaiGhe.Text, cboDiemKhoiHanh.Text, cboDiemDen.Text, txtKhoiHanh.Text, txtTroVe.Text);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(frm);
            this.Close();
            frm.Show();
        }
    }
}