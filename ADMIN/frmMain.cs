using BusinessLayer;
using DataLayer;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string IDTAIKHOAN;
        public frmMain(string IDTAIKHOAN)
        {
            InitializeComponent();
            this.IDTAIKHOAN = IDTAIKHOAN;
        }
        FUNC func;
        private void frmMain_Load(object sender, EventArgs e)
        {
            func = new FUNC();
            LoadLeftMenu();
        }

        private void LoadLeftMenu()
        {
            var IsParent = func.getParent();
            foreach(var pr in IsParent)
            {
                AccordionControlElement group = new AccordionControlElement
                {
                    Text = pr.DESCRIPTION,
                    Style = ElementStyle.Group,
                    Image = imageList1.Images[0]
                };
                var IsChild = func.getChild(pr.FUNC_CODE);
                foreach(var ch in IsChild)
                {
                    AccordionControlElement child = new AccordionControlElement
                    {
                        Text = ch.DESCRIPTION,
                        Tag = ch.FUNC_CODE,
                        Style = ElementStyle.Item,
                        Image = imageList1.Images[1]
                    };
                    group.Elements.Add(child);
                }
                MainMenu.Elements.Add(group);
                MainMenu.ExpandAll();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_ElementClick(object sender, ElementClickEventArgs e)
        {
            if(e.Element.Style == ElementStyle.Item) {
                string clickedText = e.Element.Tag.ToString();
                switch (clickedText)
                {
                    case "BOOKINGS":
                        {
                            frmBooking frm = new frmBooking();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "AIRCRAFT":
                        {
                            frmAircraft frm = new frmAircraft();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "AIRPORTS":
                        {
                            frmAirports frm = new frmAirports();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "FLIGHT_SCHEDULES":
                        {
                            frmFlight_Schedules frm = new frmFlight_Schedules();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "NHANVIEN":
                        {
                            frmNhanVien frm = new frmNhanVien();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "Member":
                        {
                            frmMember frm = new frmMember();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "FLIGHT":
                        {
                            frmFlight frm = new frmFlight();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "DOIMK":
                        {
                            frmDoiMatKhauAdmin frm = new frmDoiMatKhauAdmin(IDTAIKHOAN);
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "TAIKHOANNHANVIEN":
                        {
                            frmTaiKhoanNhanVien frm = new frmTaiKhoanNhanVien();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "SEATS":
                        {
                            frmSeats frm = new frmSeats();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "AIRCRAFTSEATS":
                        {
                            frmAirCraftSeats frm = new frmAirCraftSeats();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                    case "CHECKINS":
                        {
                            frmVedat frm = new frmVedat();
                            panMain.Controls.Clear();
                            frm.TopLevel = false;
                            frm.Height = panMain.Height;
                            frm.Width = panMain.Width;
                            panMain.Controls.Add(frm);
                            frm.Show();
                            break;
                        }
                }
            }
        }
    }
}