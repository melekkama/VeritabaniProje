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
