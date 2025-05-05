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
    public partial class frmEnrollment : Form
    {
        clsDataHandler handler = new clsDataHandler();
        public frmEnrollment()
        {
            InitializeComponent();
        }

        private void frmEnrollment_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "ENROLLMENT FORM";
            lblSpace.Text = "Spaces available";
            lblHour.Text = "Time";
            lblID.Text = "ID Number o SSN";
            lblActivity.Text = "Activity";
            lblDate.Text = "Dates available";

            btnEnroll.Text = "Enroll";

            cboActivity.Items.Clear();
            cboActivity.Items.Add("Yoga");
            cboActivity.Items.Add("Spinning");
            cboActivity.Items.Add("Funcional");
            cboActivity.Items.Add("Pilates");
            cboActivity.Items.Add("Zumba");
            cboActivity.Items.Add("CrossFit");
            cboActivity.Items.Add("Boxeo");
            cboActivity.Items.Add("Estiramiento");
            cboActivity.Items.Add("HIIT");
            cboActivity.Items.Add("Entrenamiento");
        }

        private void cboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in handler.DS.Tables["Classes"].Rows)
            {
                if (row["Actividad"].ToString() == cboActivity.Text)
                {
                    cboDate.Items.Add(row["Fecha"]);
                }
            }
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (DataRow row in handler.DS.Tables["Classes"].Rows)
            {
                if (row["Actividad"].ToString() == cboActivity.Text && 
                    row["Fecha"].ToString() == cboDate.Text)
                {
                    cboHour.Items.Add(row["Hora"]);
                    //Console.WriteLine(row["Hora"]);
                }
            }
        }

        private void cboHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in handler.DS.Tables["Classes"].Rows)
            {
                if (row["Actividad"].ToString() == cboActivity.Text &&
                    row["Fecha"].ToString() == cboDate.Text &&
                    row["Hora"].ToString() == cboHour.Text
                    )
                {
                    cboSpace.Items.Add(row["Espacio"]);
                }
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            handler.AttendanceControl(txtDNI.Text, cboActivity.Text, cboDate.Text, cboHour.Text);
        }
    }
}
