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
            lblRemoveTitle.Text = "DELETE A CUSTOMER FROM DB";
            lblCodeDelete.Text = "Enter an ID Number or SSN";

            btnChange.Text = "Update";
            btnSelectActivity.Text = "Select Activity";
            btnPay.Text = "Pay";
            btnRegister.Text = "Register";
            btnDelete.Text = "Delete";

            cboSuscription.Items.Clear();
            cboSuscription.Items.Add("Premium");
            cboSuscription.Items.Add("Estándar");
            cboSuscription.Items.Add("Básica");

            cboFieldChange.Items.Clear();
            cboFieldChange.Items.Add("Apellido");
            cboFieldChange.Items.Add("Nombre");
            cboFieldChange.Items.Add("DNI");
            cboFieldChange.Items.Add("Correo");
            cboFieldChange.Items.Add("Telefono");
            cboFieldChange.Items.Add("FechaNacimiento");
            cboFieldChange.Items.Add("Suscripcion");

            cboCategoryChange.Items.Clear();
            cboCategoryChange.Items.Add("Premium");
            cboCategoryChange.Items.Add("Estándar");
            cboCategoryChange.Items.Add("Básica");

            txtChange.Enabled = false;
            cboCategoryChange.Enabled = false;
            dtpChange.Enabled = false;
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
            if (
                txtLastName.Text == "" ||
                txtName.Text == "" ||
                txtDNI.Text == "" ||
                txtEmail.Text == "" ||
                txtPhNumber.Text == "" ||
                dtpDOB.Value == DateTime.Now ||
                cboSuscription.SelectedIndex == -1
                )
            {
                MessageBox.Show("All fields must be filled", "Registration Form: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DH.CreateCustomer(
                txtLastName.Text,
                txtName.Text,
                txtDNI.Text,
                txtEmail.Text,
                long.Parse(txtPhNumber.Text),
                dtpDOB.Value,
                cboSuscription.Text
                );

            txtLastName.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhNumber.Text = string.Empty;
            cboSuscription.Text = string.Empty;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtIDChange.Text == "" || cboFieldChange.SelectedIndex == -1)
            {
                MessageBox.Show("An ID Number and a field to change are required", "Update Form: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cboFieldChange.Text == "FechaNacimiento")
                {
                    DH.UpdateCustomer(txtIDChange.Text, cboFieldChange.Text, dtpChange.Value.ToString());
                }
                else if (cboFieldChange.Text == "Suscripcion")
                {
                    DH.UpdateCustomer(txtIDChange.Text, cboFieldChange.Text, cboCategoryChange.Text);
                }
                else
                {
                    DH.UpdateCustomer(txtIDChange.Text, cboFieldChange.Text, txtChange.Text);
                }
            }           

            txtIDChange.Text = string.Empty;
            cboFieldChange.SelectedIndex = -1;
            dtpChange.Text = string.Empty;
            cboCategoryChange.SelectedIndex = -1;
            txtChange.Text = string.Empty;
        }

        private void cboFieldChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFieldChange.Text == "FechaNacimiento")
            {
                txtChange.Enabled = false;
                cboCategoryChange.Enabled = false;
                dtpChange.Enabled = true;
            }
            else if (cboFieldChange.Text == "Suscripcion")
            {
                txtChange.Enabled = false;
                cboCategoryChange.Enabled = true;
                dtpChange.Enabled = false;
            }
            else
            {
                txtChange.Enabled = true;
                cboCategoryChange.Enabled = false;
                dtpChange.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "")
            {
                MessageBox.Show("An ID Number is required", "Removal Form: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DH.DeleteCustomer(txtDelete.Text);
            }
            
            txtDelete.Text = string.Empty;
        }
    }
}
