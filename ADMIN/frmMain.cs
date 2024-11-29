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

        public frmMain(string IDChucVu)
        {
            InitializeComponent();
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
                    Style = ElementStyle.Group
                };
                var IsChild = func.getChild(pr.FUNC_CODE);
                foreach(var ch in IsChild)
                {
                    AccordionControlElement child = new AccordionControlElement
                    {
                        Text = ch.DESCRIPTION,
                        Tag = ch.FUNC_CODE,
                        Style = ElementStyle.Item
                    };
                    group.Elements.Add(child);
                }
                MainMenu.Elements.Add(group);
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
                            frmBooking frmbk = new frmBooking();
                            panMain.Controls.Clear();
                            frmbk.TopLevel = false;
                            frmbk.Height = panMain.Height;
                            frmbk.Width = panMain.Width;
                            panMain.Controls.Add(frmbk);
                            frmbk.Show();
                            break;
                        }
                    case "AIRCRAFT":
                        {
                            frmAircraft frma = new frmAircraft();
                            panMain.Controls.Clear();
                            frma.TopLevel = false;
                            frma.Height = panMain.Height;
                            frma.Width = panMain.Width;
                            panMain.Controls.Add(frma);
                            frma.Show();
                            break;
                        }
                }
            }
        }
    }
}