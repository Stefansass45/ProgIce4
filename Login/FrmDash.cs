using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.models;

namespace Login
{
    public partial class FrmDash : Form
    {
        public FrmDash()
        {
            InitializeComponent();
        }

        private void FrmDash_Load(object sender, EventArgs e)
        {
            lblUserGreeting.Text = $"Greetings {LoginDB.currentLoggedOnUser.getUsername()}!";
            this.Text = $"Dashboard - {LoginDB.currentLoggedOnUser.getUsername()}";
        }

        private void NotImplemented_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented yet.","Feature Not Available",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
