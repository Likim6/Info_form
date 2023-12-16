using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtYearofbirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSangkat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string yearofbirth = txtYearofbirth.Text;
            string no = txtNo.Text;
            string sangkat = txtSangkat.Text;
            string khan = txtKhan.Text;
            string st = txtSt.Text;

            txtOutput.Text = "Name: " + name + "\n" + "Year of birth: " + yearofbirth + "\n" + "No: " + no + "\n" + "Sangkat: " + sangkat + "\n" + "Khan: " + khan + "\n" + "St: " + st;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtYearofbirth.Text = string.Empty;
            txtNo.Text = string.Empty;
            txtSangkat.Text = string.Empty;
            txtKhan.Text = string.Empty;
            txtSt.Text = string.Empty;
            txtOutput.Text = string.Empty;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
        }
    }
}
