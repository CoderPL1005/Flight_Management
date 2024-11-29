using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FLIGHT
{
    public partial class frmKetNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public frmKetNoiDB()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";");
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txtServer.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text);
            try
            {
                con.Open();
                MessageBox.Show("Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cboDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cboDatabase.Items.Clear();
            string conn = "server=" + txtServer.Text + ";User ID=" + txtUsername.Text + "; pwd=" + txtPassword.Text + ";";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string qr = "SELECT NAME FROM SYS.DATABASES";
            SqlCommand cmd = new SqlCommand(qr, con);
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboDatabase.Items.Add(dr[0].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            string usEncrypt = Encryptor.Encrypt(txtUsername.Text, "qwertyuiop", true);
            string pasEncrypt = Encryptor.Encrypt(txtPassword.Text, "qwertyuiop", true);
            string dbEncrypt = Encryptor.Encrypt(cboDatabase.Text, "qwertyuiop", true);
            connect cn = new connect(svEncrypt, usEncrypt, pasEncrypt, dbEncrypt);
            cn.SaveFile();
            MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmKetNoiDB_Load(object sender, EventArgs e)
        {

        }
    }
}