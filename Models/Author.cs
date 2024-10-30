using System.Data.SqlClient;

namespace Phase_2_DB.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        
        public Author(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public static bool CreateAuthor(string Name)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryInsert = "INSERT INTO Author VALUES(@Name)";

                conn.Open();
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);
                command.Parameters.AddWithValue("Name",Name);
                command.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error in adding Author\n" + ex.Message);
                return false;
            }
        }

        public static Author[]? GetAuthors()
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryArrSize = "SELECT COUNT(*) FROM Author";

                string sqlQuerySelect = "SELECT * FROM Author";

                conn.Open();

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                SqlCommand ArrSize = new SqlCommand(sqlQueryArrSize, conn);

                int Size = (int)ArrSize.ExecuteScalar();
                int counter = 0;

                Author[] ArrAuthors = new Author[Size];
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Author obj = new Author((int)reader[0], reader[1].ToString());
                        ArrAuthors[counter] = obj;
                        counter++;
                    }

                }
                conn.Close();
                return ArrAuthors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Author model\n" + ex.Message);
                return null;
            }
        }

        public static void DeleteAuthor(Author TargetedAuthor)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryRemoveContain = "DELETE FROM Contain WHERE AuthorID = @ID1";
                string sqlQueryRemove = "DELETE FROM Author WHERE ID = @ID";
                conn.Open();

                SqlCommand command1 = new SqlCommand(sqlQueryRemoveContain, conn);

                command1.Parameters.AddWithValue("ID1", TargetedAuthor.ID);

                command1.ExecuteScalar();

                conn.Close();

                conn.Open();

                SqlCommand command = new SqlCommand(sqlQueryRemove, conn);

                command.Parameters.AddWithValue("ID", TargetedAuthor.ID);

                command.ExecuteScalar();

                conn.Close();

                MessageBox.Show("Author removed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in removing author\n" + ex.Message);
            }
        }
    }
}
