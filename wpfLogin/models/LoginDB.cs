using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace wpfLogin
{
    public static class LoginDB
    {
        private static string dbstring = "server=labVMH8OX\\SQLEXPRESS;database =progice4; Integrated Security = true;";
        
        private static List<User> usersDB = new List<User>();
        public static User currentLoggedOnUser { get; set; }

        public static bool verifyUser(User unverifiedUser)
        {

            int counter = 0;
            bool userIsVerified = false;

            DataTable loginTable = GETUserFromSQLDB(unverifiedUser.getUsername());

            if (loginTable.Rows[0].ItemArray[1].ToString() == unverifiedUser.getUsername())
            {
                if (loginTable.Rows[0].ItemArray[2].ToString() == unverifiedUser.getPassword())
                {
                    userIsVerified = true;
                    currentLoggedOnUser = new User(loginTable.Rows[0].ItemArray[1].ToString(), loginTable.Rows[0].ItemArray[2].ToString());
                    return userIsVerified;
                }
            }

            return userIsVerified;
        }

        public static bool isUsernameAvailable(string username)
        {
            bool existingUsernameFound = false;
            foreach (User currentUserRecord in usersDB)
            {
                if (currentUserRecord.getUsername() == username)
                {
                    existingUsernameFound = true;
                }
            }
            return !existingUsernameFound;

        }

        public static void AddUserToSQLDB (string username, string password) {            

            using (SqlConnection _con = new SqlConnection(dbstring))
            {
                string queryStatement = $"insert into tbllogin (ID,username,password) values(2,'{username}', '{password}')";

                _con.Open();

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _cmd.CommandType = CommandType.Text;
                    _cmd.ExecuteNonQuery();

                }

                _con.Close();
            }
        }

        public static DataTable GETUserFromSQLDB(string username)
        {
            DataTable loginTable;

            using (SqlConnection _con = new SqlConnection(dbstring))
            {
                string queryStatement = $"select * from tbllogin where username = '{username}'";

                _con.Open();

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _cmd.CommandType = CommandType.Text;

                    loginTable = new DataTable("LoginTable");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _dap.Fill(loginTable);

                }

                _con.Close();
            }
            return loginTable;
        }

        public static User addNewUser(User newUser)
        {
            //Check if username already exists
            if (isUsernameAvailable(newUser.getUsername()))
            {
                usersDB.Add(newUser);
                AddUserToSQLDB(newUser.getUsername(), newUser.getPassword());
                return newUser;
            }
            else
            {
                throw new Exception("Username invalid or not unique");
            }

        }

        public static bool deleteUser(string username)
        {

            bool userDeleted = false;

            for (int i = 0; i < usersDB.Count; i++)
            {
                if (usersDB[i].getUsername() == username)
                {
                    usersDB.RemoveAt(i);
                    userDeleted = true;
                    break;
                }
            }

            return userDeleted;

        }

        public static void LoadFromCSVFile(string PathToCSVFile, string delimiter = ",", bool FileHasHeaders = true)
        {
            int totalRowsIngested = 0;
            using (StreamReader readerEngine = new StreamReader(PathToCSVFile))
            {
                string currentRow;
                while ((currentRow = readerEngine.ReadLine()) != null)
                {
                    //Use if to skip the header row
                    if (totalRowsIngested > 0)
                    {
                        string[] currentRowColumns = currentRow.Split(delimiter);

                        if (currentRowColumns.Length == 2)
                        {
                            addNewUser(new User(currentRowColumns[0], currentRowColumns[1], true));
                        }
                    }

                    totalRowsIngested++;
                }
            }

        }

        public static void SaveToCSVFile(string PathToCSVFile, string delimiter = ",", bool IncludeHeaders = true)
        {

            string Headers = $"username{delimiter}password";

            using (StreamWriter writerEngine = new StreamWriter(PathToCSVFile))
            {
                if (IncludeHeaders)
                {
                    writerEngine.WriteLine(Headers);
                }

                foreach (User currentUser in usersDB)
                {
                    writerEngine.WriteLine(currentUser.getUsername() + delimiter + currentUser.getPassword());
                }
            }

        }

    }
}
