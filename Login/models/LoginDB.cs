namespace Login.models
{
    public static class LoginDB
    {
        private static List<User> usersDB = new List<User>();
        public static User currentLoggedOnUser { get; set; }

        public static bool verifyUser(User unverifiedUser)
        {

            int counter = 0;
            bool userIsVerified = false;

            while (counter < usersDB.Count)
            {
                if (usersDB[counter].getUsername() == unverifiedUser.getUsername())
                {
                    if (usersDB[counter].getPassword() == unverifiedUser.getPassword())
                    {
                        userIsVerified = true;
                        currentLoggedOnUser = usersDB[counter];
                        break;
                    }
                }
                counter++;
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

        public static User addNewUser(User newUser)
        {
            //Check if username already exists
            if (isUsernameAvailable(newUser.getUsername()))
            {
                usersDB.Add(newUser);
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
