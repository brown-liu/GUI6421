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
        public MainForm()
        {
            InitializeComponent();
            _dataModule = new DataModule();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var report = new ReportForm();
            report.ShowDialog();
        }

        private void whanauBtn_Click(object sender, EventArgs e)
        {
            var whanau = new WhanauManagementForm();
            whanau.ShowDialog();

        }

        private void kai_Click(object sender, EventArgs e)
        {
            var kaiForm = new KaiMaintenanceForm(_dataModule,this);
            kaiForm.ShowDialog();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            var events = new EventManagementForm();
            events.ShowDialog();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            var location = new LocationManagementForm();
            location.ShowDialog();
        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            var registration = new RegistrationManagementForm();
            registration.ShowDialog();
        }

        private void homeExistBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
