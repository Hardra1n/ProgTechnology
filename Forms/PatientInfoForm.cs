using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PatientInfoForm : Form
    {
        ControlService _service;
        Patient _patient;

        public PatientInfoForm()
        {
            InitializeComponent();
        }

        public PatientInfoForm(ControlService service, Patient patient)
        {
            InitializeComponent();
            _service = service;
            _patient = patient;
            label6.Text = patient.name;
            label7.Text = patient.surname;
            label8.Text = patient.fathername;
            label9.Text = patient.age.ToString();
            label10.Text = patient.sex;

        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void addResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientReaserchForm addPatientReaserchForm = new AddPatientReaserchForm();
            addPatientReaserchForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPatientResearchForm startPatientResearchForm = new StartPatientResearchForm();
            startPatientResearchForm.Show();
        }
    }
}
