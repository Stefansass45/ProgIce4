using Login.models;

namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlWelcome.Visible = !pnlWelcome.Visible;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            bool userLoginVerified = false;

            if ((txtLoginUsername.Text != String.Empty) && (txtLoginPassword.Text != string.Empty))
            {
                userLoginVerified = LoginDB.verifyUser(new User(txtLoginUsername.Text, txtLoginPassword.Text));
                txtLoginUsername.Clear();
                txtLoginPassword.Clear();
            }

            if (userLoginVerified)
            {
                FrmDash formDash = new FrmDash();
                this.Hide();
                formDash.ShowDialog();
                LoginDB.currentLoggedOnUser = null;
                this.Show();
                pnlLogin.Visible = !pnlLogin.Visible;
                pnlWelcome.Visible = !pnlWelcome.Visible;
            }
            else
            {
                MessageBox.Show("Invalid login details provided", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = !pnlRegister.Visible;
            pnlLogin.Visible = !pnlLogin.Visible;
            txtRegisterUsername.Clear();
            txtRegisterPassword.Clear();
        }

        private void lblRegisterLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = !pnlLogin.Visible;
            pnlRegister.Visible = !pnlLogin.Visible;
            txtLoginUsername.Clear();
            txtLoginPassword.Clear();
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            if (LoginDB.isUsernameAvailable(txtRegisterUsername.Text))
            {
                User newUser = new User(txtRegisterUsername.Text, txtRegisterPassword.Text);
                txtRegisterUsername.Clear();
                txtRegisterPassword.Clear();

                if (LoginDB.addNewUser(newUser) == newUser)
                {
                    LoginDB.SaveToCSVFile("users.csv");
                    MessageBox.Show($"Registration completed!\nUsername : {newUser.getUsername()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoginUsername.Clear();
                    txtLoginPassword.Clear();
                    pnlLogin.Visible = !pnlLogin.Visible;
                    pnlRegister.Visible = !pnlRegister.Visible;

                }
                else
                {
                    MessageBox.Show("Unable to complete registration...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Username has already been used\nPlease use another username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = pnlWelcome.Location;
            pnlRegister.Location = pnlWelcome.Location;

            try
            {
                LoginDB.LoadFromCSVFile("users.csv");
            }
            catch (FileNotFoundException)
            {
                var messageBoxResult = MessageBox.Show("No user database file exists.\nDo you want to create a default admin account?", "No user database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBoxResult == DialogResult.Yes)
                {
                    LoginDB.addNewUser(new User("admin", "admin"));
                    LoginDB.SaveToCSVFile("users.csv");
                    MessageBox.Show("Default admin created:\nUsername: admin\nPassword: admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
    }
}
