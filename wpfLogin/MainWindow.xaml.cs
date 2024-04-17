using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (LoginDB.isUsernameAvailable(RegUsername.Text))
            {
                User newUser = new User(RegUsername.Text.ToString(), RegPassword.Text);
                RegUsername.Clear();
                RegPassword.Clear();

                if (LoginDB.addNewUser(newUser) == newUser)
                {
                    LoginDB.SaveToCSVFile("users.csv");
                    MessageBox.Show($"Registration completed!\nUsername : {newUser.getUsername()}", "Success");
                    logUsername.Clear();
                    logPassword.Clear();
                    loginPanel.Visibility = Visibility.Visible;
                    registerPanel.Visibility = Visibility.Hidden;

                }
                else
                {
                    MessageBox.Show("Unable to complete registration...", "Failure");

                }
            }
            else
            {
                MessageBox.Show("Username has already been used\nPlease use another username", "Invalid Username");
            }

        }

        private void lblReg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            loginPanel.Visibility = Visibility.Visible;
            registerPanel.Visibility = Visibility.Hidden;
            logUsername.Clear();
            logPassword.Clear();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            bool userLoginVerified = false;

            if ((logUsername.Text != String.Empty) && (logPassword.Text != string.Empty))
            {
                userLoginVerified = LoginDB.verifyUser(new User(logUsername.Text, logPassword.Text));
                logUsername.Clear();
                logPassword.Clear();
            }

            if (userLoginVerified)
            {
                MessageBox.Show($"Welcome {LoginDB.currentLoggedOnUser.getUsername()}", "Login Success");
                /*FrmDash formDash = new FrmDash();
                this.Hide();
                formDash.ShowDialog();*/
                LoginDB.currentLoggedOnUser = null;
                this.Show();
                loginPanel.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Invalid login details provided", "Login Failed");
            }
        }

        private void lblLog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            registerPanel.Visibility = Visibility.Visible;
            loginPanel.Visibility = Visibility.Hidden;
            RegUsername.Clear();
            RegPassword.Clear();
        }
    }
}