using System.Data.SqlClient;

namespace Phase_2_DB.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string PublicationDate { get; set; }
        public Book(int iSBN, string title, string publicationDate)
        {
            ISBN = iSBN;
            Title = title;
            PublicationDate =publicationDate;
        }

        //the method can return null if there are no books
        public static Book[]? GetBooks(string Title = "")
        {
            try 
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryArrSize = "SELECT COUNT(*) FROM Book";
                string sqlQuerySelect = "SELECT * FROM Book";

                if (Title != string.Empty)
                {
                sqlQueryArrSize += " WHERE Title LIKE '%" + Title + "%'";

                sqlQuerySelect += " WHERE Title LIKE '%" + Title + "%'";

                }
                
                conn.Open();

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                SqlCommand ArrSize = new SqlCommand(sqlQueryArrSize, conn);

                int Size = (int)ArrSize.ExecuteScalar();
                int counter = 0;

                Book[] ArrBooks = new Book[Size];
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book obj = new Book((int)reader[0], reader[1].ToString(), reader[2].ToString());
                        ArrBooks[counter] = obj;
                        counter++;
                    }
            
                }   
                conn.Close();
                return ArrBooks;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Book model\n" + ex.Message);
                return null;
            }
        }

        public static void DeleteBook(Book BookObj)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryContainRemove = "DELETE FROM Contain WHERE bookISBN = @isbn1";
                SqlCommand command1 = new SqlCommand(sqlQueryContainRemove, conn);
                conn.Open();
                command1.Parameters.AddWithValue("isbn1", BookObj.ISBN);
                command1.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string sqlQueryRemoveCopy = "DELETE FROM Copy WHERE bookISBN = @isbn2";
                SqlCommand command2 = new SqlCommand(sqlQueryRemoveCopy,conn);
                command2.Parameters.AddWithValue("isbn2", BookObj.ISBN);
                command2.ExecuteNonQuery();
                conn.Close();

                string sqlQueryRemove = "DELETE FROM Book WHERE ISBN = @isbn";
                conn.Open();

                SqlCommand command = new SqlCommand(sqlQueryRemove, conn);
                command.Parameters.AddWithValue("isbn", BookObj.ISBN);
                command.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Book removed successfully");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error in removing book\n" + ex.Message);
            }
        }
        public static bool AddBook(string Title,string Date)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryInsert = "INSERT INTO Book VALUES(@Title,@PublicationYear)";

                conn.Open();

                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);
                command.Parameters.AddWithValue("Title", Title);
                command.Parameters.AddWithValue("PublicationYear", Date);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding book\n" + ex.Message);
                return false;
            }
        }

        public static bool UpdateBookDate(Book book,int NewYear)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string sqlQueryUpdate = "UPDATE Book SET PublicationYear = @newyear WHERE ISBN = @bookisbn";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);
                conn.Open();
                command.Parameters.AddWithValue("newyear",NewYear);
                command.Parameters.AddWithValue("bookisbn", book.ISBN);
                command.ExecuteNonQuery();
                conn.Close();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating book" + ex.Message);
                return false;
            }
        }
    }
}
