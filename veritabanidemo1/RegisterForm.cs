using MaterialSkin.Controls;
using veritabanidemo1.Services;
using System.Data;
using System.Data.SqlClient;


namespace veritabanidemo1
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }
        SqlConnection baglanti;


        private static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-G8KPTIR;Initial Catalog=Kullanicilar;Integrated Security=True");
        private void materialButton1_Click(object sender, EventArgs e)
        {
           

        }
       
    }
}
