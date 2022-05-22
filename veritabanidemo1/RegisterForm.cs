using MaterialSkin.Controls;
using System.Data.SqlClient;
using veritabanidemo1.Services;


namespace veritabanidemo1
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }


        private static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-G8KPTIR;Initial Catalog=Kullanicilar;Integrated Security=True");
        private void materialButton1_Click(object sender, EventArgs e)
        {
            static string connectionString = "Data Source=DBHotel;Initial Catalof=Air;Trusted_Connection=True;";
            SqlConnection baglanti = new SqlConnection(connectionString);
            string insStmt = "insert into Customer(@Email,@Password)values(@Email,@Password)";
            using (SqlConnection cnn=new SqlConnection(connectionString))
            {
                cnn.Open();
                sqlco
            }
        }
       
    }
}
