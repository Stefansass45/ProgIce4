using System.Security.Cryptography;
using System.Text;

namespace wpfLogin
{
    public class User
    {
        private string username = "";
        private string password = "";

        public User(string username, string password, bool skipHashing = false)
        {
            if (skipHashing)
            {
                this.username = username;
                this.password = password;
            }
            else
            {
                this.username = username;
                setPassword(password);
            }
        }


        public string getUsername() { return username; }
        public string getPassword() { return password; }

        public string setPassword(string rawPassword)
        {

            string salt = "0CA7AD4D2C49F55334FC92150E72A024742B9EABCEC93C1077673004BD8CE69E";

            //Microsoft. 2024.SHA256 class (system.security.cryptography), 2024. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-8.0 [Accessed 20 March 2024].

            using (SHA256 sha256Instance = SHA256.Create())
            {
                byte[] rawPasswordBytes = Encoding.Default.GetBytes(rawPassword + salt);
                byte[] hashedPasswordBytes = sha256Instance.ComputeHash(rawPasswordBytes);
                string hashedPassword = "";
                foreach (byte currentByte in hashedPasswordBytes)
                {
                    hashedPassword += currentByte.ToString("X2");
                }

                password = hashedPassword;
            }

            return password;
        }

    }
}
