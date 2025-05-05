using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymCustomersManagementApp
{
    public partial class frmPayment : Form
    {
        clsDataHandler handler = new clsDataHandler();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblIDNumber.Text = "ID Number or SSN";
            lblAmount.Text = "Payment Amount";
            lblMethod.Text = "Payment Method";
            lblTitle.Text = "PAY FOR YOUR MEMBERSHIP";
            btnPay.Text = "Pay";

            cboMethod.Items.Clear();
            cboMethod.Items.Add("Debit Card");
            cboMethod.Items.Add("Credit Card");
            cboMethod.Items.Add("Cash");
            cboMethod.Items.Add("Wire Electronic Transfer");
            cboMethod.Items.Add("Virtual Wallet");
            cboMethod.Items.Add("ACH Transfer");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            handler.createPayment(txtIDNumber.Text, double.Parse(txtAmount.Text), cboMethod.Text);
        }
    }
}
