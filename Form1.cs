using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.resultsTableAdapter.Fill(this.vetClinicDataSet.Results);
            this.servicesTableAdapter.Fill(this.vetClinicDataSet.Services);
            this.vaccinesTableAdapter.Fill(this.vetClinicDataSet.Vaccines);
            this.beastsTableAdapter.Fill(this.vetClinicDataSet.Beasts);
            this.ownersTableAdapter.Fill(this.vetClinicDataSet.Owners);
            this.doctorsTableAdapter.Fill(this.vetClinicDataSet.Doctors);
        }
        private void dgDoctors_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.doctorsTableAdapter.Update(this.vetClinicDataSet.Doctors);
        }

        private void dgOwners_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.ownersTableAdapter.Update(this.vetClinicDataSet.Owners);
        }

        private void dgVaccines_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.vaccinesTableAdapter.Update(this.vetClinicDataSet.Vaccines);
        }

        private void dgBeasts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.beastsTableAdapter.Update(this.vetClinicDataSet.Beasts);
        }

        private void dgServices_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.servicesTableAdapter.Update(this.vetClinicDataSet.Services);
        }

        private void dgResult_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.resultsTableAdapter.Update(this.vetClinicDataSet.Results);
        }
    }
}
