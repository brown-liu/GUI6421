using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate_BoLiu
{
    public partial class MainForm : Form
    {
        private DataModule _dataModule;
        private ReportForm _reportForm;
        private WhanauManagementForm whanauManagementForm;
        private KaiMaintenanceForm kaiMaintenanceForm;
        private EventManagementForm eventManagementForm;
        private LocationManagementForm locationManagement;
        private RegistrationManagementForm registrationManagementForm;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //create the data module and load the dataset
            _dataModule = new DataModule();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            _reportForm = new ReportForm();
            _reportForm.ShowDialog();
        }

        private void whanauBtn_Click(object sender, EventArgs e)
        {
            whanauManagementForm = new WhanauManagementForm(_dataModule, this);
            whanauManagementForm.ShowDialog();

        }

        private void kai_Click(object sender, EventArgs e)
        {
            if (kaiMaintenanceForm == null)
            { 
                kaiMaintenanceForm = new KaiMaintenanceForm(_dataModule, this);
            }
           
            kaiMaintenanceForm.ShowDialog();
        }

 

        private void locationBtn_Click(object sender, EventArgs e)
        {
            locationManagement = new LocationManagementForm(_dataModule, this);
            locationManagement.ShowDialog();
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            registrationManagementForm = new RegistrationManagementForm(_dataModule, this);
            registrationManagementForm.ShowDialog();
        }

        private void homeExistBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {  
            eventManagementForm = new EventManagementForm(_dataModule, this);
        eventManagementForm.ShowDialog();

        }
    }
}
