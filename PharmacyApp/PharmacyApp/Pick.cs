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
    public partial class Pick : Form
    {
        public Pick()
        {
            InitializeComponent();
        }

        private void Pick_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var form2 = new MedicalStock();
            form2.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            var form3 = new MainPage();
            form3.Show();
            this.Hide();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
