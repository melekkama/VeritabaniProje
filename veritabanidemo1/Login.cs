using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanidemo1
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            Services.DefaultMaterialFormTheme.UseTheme(this);
        }

        private void btn_forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen emailinize gelen bağlantıya tıklayarak parolanızı sıfırlayınız.", "Parola Sıfırlama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_go_register_Click(object sender, EventArgs e)
        {
            RegisterForm rgf = new RegisterForm();
            rgf.Show();
            this.Hide();
        }
    }
}
