using System.Data.SqlClient;

namespace Phase_2_DB.Models
{
    public class Copy
    {
        public int ID {  get; set; }
        public int BookISBN { get; set; }
        public bool IsAvilable { get; set; }
        public string BorrowedDate { get; set; }
        public string ReturnDate { get; set; }
        public int OwnerID { get; set; }
        public Copy(int iD, int bookISBN, bool isAvilable, string borrowedDate, string returnDate, int ownerID)
        {
            ID = iD;
            BookISBN = bookISBN;
            IsAvilable = isAvilable;
            BorrowedDate = borrowedDate;
            ReturnDate = returnDate;
            OwnerID = ownerID;
        }
        public static bool SetCopies(Book BookObj,int NumberCopies)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string bookISBN = "SELECT ISBN FROM Book WHERE Title ='" + BookObj.Title + "' AND PublicationYear =" + BookObj.PublicationDate; 
                conn.Open();
                string BookISBNInit;
                SqlCommand commandSelect = new SqlCommand(bookISBN, conn);
                using (SqlDataReader reader = commandSelect.ExecuteReader())
                {
                    reader.Read();
                    BookISBNInit = reader[0].ToString();
                }   

                string sqlQueryInsert = "INSERT INTO Copy(bookISBN,IsAvailable) VALUES(" + BookISBNInit +",1);";
                SqlCommand command = new SqlCommand(sqlQueryInsert,conn);


                while (NumberCopies-- > 0)
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in creating copy\n" + ex.Message);
                return false;
            }
        }

        public static bool BorrowBook(Book Book)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(Program.connString);

                string IsBookAvilable = "SELECT COUNT(*) FROM Copy WHERE bookISBN = @bookisbn AND IsAvailable = 1";
                SqlCommand command = new SqlCommand(IsBookAvilable,conn);
                conn.Open() ;
                command.Parameters.AddWithValue("bookisbn", Book.ISBN);
                if ((int)command.ExecuteScalar() == 0)
                {
                    string AddToWaitingList = "INSERT INTO WaitingList VALUES(@userid,@bookisbn)";
                    command = new SqlCommand(AddToWaitingList,conn);
                    command.Parameters.AddWithValue("userid",Person.ActiveUser.ID);
                    command.Parameters.AddWithValue("bookisbn",Book.ISBN);
                    command.ExecuteNonQuery();
                    conn.Close();
                    return false;
                }
                string UpdateCopy = "UPDATE TOP(1) Copy " +
                    "SET IsAvailable = 0, OwnerID = @ownerid, BorrowedDate = GETDATE(), ReturnDate = GETDATE()+14 " +
                    "WHERE bookisbn = @isbn AND IsAvailable = 1;";

                command = new SqlCommand(UpdateCopy,conn);
                command.Parameters.AddWithValue("ownerid",Person.ActiveUser.ID);
                command.Parameters.AddWithValue("isbn",Book.ISBN);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in finding copy\n" + ex.Message);
                return false;
            }
        }

        public static bool ReturnCopy(Copy Copy)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Program.connString);
                string UpdateQuery = "UPDATE TOP(1) Copy SET isAvailable = 1, OwnerID = null, ReturnDate = null WHERE ID = @copyid";
                conn.Open();
                SqlCommand command = new SqlCommand(UpdateQuery,conn);
                command.Parameters.AddWithValue("copyid" , Copy.ID);
                command.ExecuteNonQuery();

                string CheckRequesters = "SELECT TOP(1) * FROM WaitingList WHERE bookISBN = @isbn ORDER BY Pattern";
                command = new SqlCommand(CheckRequesters,conn);
                command.Parameters.AddWithValue("isbn",Copy.BookISBN);

                int RequesterID;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return true;
                    }
                    reader.Read();
                    RequesterID = (int)reader["UserID"];
                }

                string AddToRequester = "UPDATE TOP(1) Copy " +
                "SET IsAvailable = 0, OwnerID = @ownerid, BorrowedDate = GETDATE(), ReturnDate = GETDATE()+14 " +
                "WHERE bookisbn = @isbn AND IsAvailable = 1;";

                command = new SqlCommand(AddToRequester,conn);
                command.Parameters.AddWithValue("ownerid",RequesterID);
                command.Parameters.AddWithValue("isbn", Copy.BookISBN);
                command.ExecuteNonQuery();


                string RemoveFromWaitingList = "DELETE TOP(1) FROM WaitingList WHERE bookISBN = @isbn AND UserID = @userid";

                command = new SqlCommand(RemoveFromWaitingList, conn);
                command.Parameters.AddWithValue("isbn", Copy.BookISBN);
                command.Parameters.AddWithValue("userid", RequesterID);
                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in returning copies\n" + ex.Message);
                return false;
            }
        }
    }
}
