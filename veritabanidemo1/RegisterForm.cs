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
        string connectionString = "Data Source=MELEKPC;Initial Catalog=DBHotel;Integrated Security=true;";

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using var con = new SqlConnection(connectionString);
                con.Open();
                string command = "insert into Customer(Email,Password) values(@Email,@Password)";
                using SqlCommand cmd = new(command, con);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@Password", tb_password.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                //}
            }
            catch (SqlException ex)
            {
                string msg = "ınsert error:";
                msg += ex.Message;
            }

        }
    }
}
