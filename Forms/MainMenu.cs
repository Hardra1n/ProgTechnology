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
    public partial class MainMenu : Form
    {
        ControlService _service;
        public MainMenu()
        {
            InitializeComponent();
            _service = new ControlService();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(_service);
            addPatientForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientInfoForm patientInfoForm = new PatientInfoForm();
            patientInfoForm.Show();
        }
    }
}
