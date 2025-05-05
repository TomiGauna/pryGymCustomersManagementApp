using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymCustomersManagementApp
{
    public partial class frmMain : Form
    {
        clsDataHandler DH = new clsDataHandler();

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "REGISTER NEW GYM MEMBER";
            lblLastName.Text = "Last Name";
            lblName.Text = "First Name";
            lblEmail.Text = "E-mail";
            lblPhoneNumber.Text = "Phone Number";
            lblDNI.Text = "ID Number or SSN";
            lblDOB.Text = "Date Of Birth";
            lblSuscription.Text = "Type of Subscription";
            lblPayOption.Text = "Are you already registered? You can pay here";
            lblActivityOffer.Text = "Do you know what to do? Pick an activity";
            lblChangeTitle.Text = "MODIFY CUSTOMER INFORMATION";
            lblChangeField.Text = "Choose the field";
            lblChangeID.Text = "ID Number or SSN";
            lblChangeData.Text = "Enter new data";

            btnChange.Text = "Update";
            btnSelectActivity.Text = "Select Activity";
            btnPay.Text = "Pay";
            btnRegister.Text = "Register";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.ShowDialog();
        }

        private void btnSelectActivity_Click(object sender, EventArgs e)
        {
            frmActivity frm = new frmActivity();
            frm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DH.CreateCustomer(
                txtLastName.Text,
                txtName.Text,
                txtDNI.Text,
                txtEmail.Text,
                int.Parse(txtPhNumber.Text),
                dtpDOB.Value,
                cboSuscription.Text
                );
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cboFieldChange.Text == "Fecha")
            {
                DH.UpdateCustomer(txtIDChange.Text, cboFieldChange.Text, dtpChange.Value.ToString());
            }
            else
            {
                DH.UpdateCustomer(txtIDChange.Text, cboFieldChange.Text, txtChange.Text);
            }

        }
    }
}
