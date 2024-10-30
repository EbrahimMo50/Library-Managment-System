using System.Data.SqlClient;


namespace Phase_2_DB.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Person(int iD, string name, string email, string password, string role)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }

        public static Person ActiveUser;
        public static bool Login(string Email, string Pass)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);
                conn.Open();

                string SqlQuerySelect = "SELECT * FROM Person WHERE email = @email AND password = @password";

                using (SqlCommand command = new SqlCommand(SqlQuerySelect, conn))
                {
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@password", Pass);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login success");

                            reader.Read();
                            if ((string)reader["Role"] == "admin")
                            {
                                ActiveUser = new Person
                                    (
                                    (int)reader["ID"],
                                    (string)reader["Fname"] + " " + (string)reader["Lname"],
                                    (string)reader["email"],
                                    (string)reader["password"],
                                    "admin"
                                    );
                            }
                            else
                            {
                                ActiveUser = new Person
                                    (
                                    (int)reader["ID"],
                                    (string)reader["Fname"] + " " + (string)reader["Lname"],
                                    (string)reader["email"],
                                    (string)reader["password"],
                                    "student"
                                    );
                            }
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Login failed \nWrong cerdintials");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed \n" + ex.Message);
            }

            return false;
        }

        public static void Register(string Fname, string Lname, string Email, string Pass, bool Role)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string InsertQuery = "INSERT INTO Person VALUES (@Fname, @Lname, @Email, @Pass, @Role);";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Fname", Fname);
                    cmd.Parameters.AddWithValue("@Lname", Lname);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Pass", Pass);
                    cmd.Parameters.AddWithValue("@Role", Role ? "admin" : "student");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration success");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed \n" + ex.Message);
            }
        }

        public static void LogOut(Form CurrentForm)
        {
            CurrentForm.Close();
            Form Form1 = new Form1();
            Form1.Show();
        }
    }
}