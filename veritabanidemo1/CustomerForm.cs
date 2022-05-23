using MaterialSkin.Controls;
using veritabanidemo1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace veritabanidemo1
{
    public partial class CustomerForm : MaterialForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        SqlConnection baglan = new SqlConnection("Data Source = 176.53.65.202\\MSSQLSERVER2019; Initial Catalog = senrecep_veritabaniproje; User ID = senrecep_recepsen; Password=Lq~406nj");

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DateTime startdate = Convert.ToDateTime(dtp_checkin.Text);
            DateTime enddate = Convert.ToDateTime(dtp_checkout.Text); 
            TimeSpan fark = enddate - startdate;
            MessageBox.Show(fark.ToString());
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Customer (FirstName , LastName , IdentityNumber) VALUES ('" + tb_firstName.Text.ToString() + "','" + tb_lastName.Text.ToString() + "','" + tb_IDnumber.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
    }

    
}