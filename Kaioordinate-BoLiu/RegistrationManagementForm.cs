using System;
using System.Data;
using System.Windows.Forms;

namespace Kaioordinate_BoLiu
{
    public partial class RegistrationManagementForm : Form
    {

        private DataModule _dataModule;
        private MainForm _mainForm;

        private CurrencyManager _eventCurrencyManager;
        private CurrencyManager _whanauCurrencyManager;
        private CurrencyManager _registrationCurrencyManager;


        public RegistrationManagementForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;
            _mainForm = mainForm;
            InitializeComponent();

            _eventCurrencyManager=(CurrencyManager) this.BindingContext[_dataModule.dataSetKaioordinate,"event"];
            _whanauCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "whanau"];
           _registrationCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "eventRegister"];

            dataGridViewEvent.DataSource = _dataModule.dataSetKaioordinate;
            dataGridViewEvent.DataMember = "event";

            dataGridViewWhanau.DataSource = _dataModule.dataSetKaioordinate;
            dataGridViewWhanau.DataMember = "whanau";

            dataGridViewRegistrations.DataSource = _dataModule.dataSetKaioordinate;
            dataGridViewRegistrations.DataMember = "event.FK_EVENT_EVENTREGISTER";
        }

        private void locationReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkEventAndWhanauBtn_Click(object sender, EventArgs e)
        {
            var eventRecord = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];
            var whanauRecord = _dataModule.WhanauTable.Rows[_whanauCurrencyManager.Position];

            var eventId = eventRecord["eventId"];
            var whanauId = whanauRecord["whanauId"];

            DataRow[] anyExistingRow = _dataModule.EventRegisterTable.Select($"eventId={eventId} and whanauId= {whanauId}");

            if (anyExistingRow.Length != 0) {
                MessageBox.Show("Whanau can only be registered to an event once.", "Warning");
                return;
            }

            var newEntry = _dataModule.EventRegisterTable.NewRow();
            newEntry["eventId"] = eventId;
            newEntry["whanauId"] = whanauId;
            newEntry["KaiPreparation"] = checkBoxRegistrationHome.Checked;

            _dataModule.EventRegisterTable.Rows.Add(newEntry);
            _dataModule.UpdateEventRegisterTable();

            MessageBox.Show("Registrations added successfully", "Succeed");
            checkBoxRegistrationHome.Checked = false;
        }

        private void deleteEventAndWhanauBtn_Click(object sender, EventArgs e)
        {
            var registrationRecord = _dataModule.EventRegisterTable.Rows[_registrationCurrencyManager.Position];

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                registrationRecord.Delete();
                _dataModule.UpdateEventRegisterTable();
            }

        }

        private void dataGridViewEvent_SelectionChanged(object sender, EventArgs e)
        {
            var eventId = _dataModule.EventTable.Rows[_eventCurrencyManager.Position]["EventId"];

            _registrationCurrencyManager.Position = _dataModule.EventRegisterView.Find(eventId);
        }
    }
}
