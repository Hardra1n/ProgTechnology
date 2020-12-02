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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientInfoForm patientInfoForm = new PatientInfoForm();
            patientInfoForm.Show();
        }
    }
}
