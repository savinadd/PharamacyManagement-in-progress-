using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyApp
{
    public partial class IntroAppPage : Form
    {
        public IntroAppPage()
        {
            InitializeComponent();
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
