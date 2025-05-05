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
    public partial class frmActivity : Form
    {
        clsDataHandler DH = new clsDataHandler();
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SCHEDULE YOUR ACTIVITY";
            lblIDNumber.Text = "Class given by:";
            lblActivity.Text = "Activity";
            lblHour.Text = "Time";
            lblDate.Text = "Date";
            lblSpace.Text = "Place";
            lblParticipate.Text = "Do you want to enroll in one the activities?";

            btnParticipate.Text = "Enroll";
            btnSchedule.Text = "Set Up Activity";

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

            cboSpace.Items.Clear();
            cboSpace.Items.Add("Sala 1");
            cboSpace.Items.Add("Sala 2");
            cboSpace.Items.Add("Sala 3");
            cboSpace.Items.Add("Sala 4");
            cboSpace.Items.Add("Patio");
            cboSpace.Items.Add("Gimnasio");

            cboHour.Items.Clear();
            for (int i = 6; i < 24; i++)
            {
                cboHour.Items.Add($"{i}:00 hs");
            }

        }

        private void btnParticipate_Click(object sender, EventArgs e)
        {
            frmEnrollment form = new frmEnrollment();
            form.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            DH.createActivity(
                cboActivity.Text,
                cboSpace.Text,
                cboHour.Text,
                dtpSchedule.Value,
                txtProvider.Text
                );
        }
    }
}
