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
        public PatientInfoForm()
        {
            InitializeComponent();
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
