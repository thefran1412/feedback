using System;
using System.Web.UI;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class login_Default : System.Web.UI.Page
{
    protected void RegisterUser(object sender, EventArgs e)
    {
        UserNameValidation.Text = "";
        EmailValidator.Text = "";

        int userId = 0;
        string constr = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("Insert_User"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    var prueba = HashStrings.GetHashedString(txtPassword.Text.Trim());

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", HashStrings.GetHashedString(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Hash", HashStrings.GetHashedString(txtEmail.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Verified", 1);
                    cmd.Connection = con;
                    con.Open();
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            string message = string.Empty;
            switch (userId)
            {
                case -1:
                    UserNameValidation.Text = "El nombre de usuario ya existe.";
                    break;
                case -2:
                    EmailValidator.Text = "El eMail introducido ya existe";
                    break;
                default:
                    break;
            }
        }
        if (Page.IsValid)
        {
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }
}