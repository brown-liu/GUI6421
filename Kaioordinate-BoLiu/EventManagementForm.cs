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

    public partial class EventManagementForm : Form
    {

        private DataModule _dataModule;
        private MainForm _mainForm;
        private CurrencyManager _locationCurrencyManager;
        private CurrencyManager _eventCurrencyManager;
        public EventManagementForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;
            _mainForm = mainForm;
            InitializeComponent();

            _locationCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "Location"];
            _eventCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "EVENT"];


            displayEventId.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Event.EventId");
            eventDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Event.EventName");
            displayLocationName.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Location.LocationName");
            displayEventDate.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Event.EventDate");

            eventListBox.DataSource = _dataModule.dataSetKaioordinate;
            eventListBox.DisplayMember = "Event.EventName";
            eventListBox.ValueMember = "Event.EventName";

            comboBoxLocations.DataSource = _dataModule.dataSetKaioordinate;
            comboBoxLocations.DisplayMember = "Location.LocationName";
            comboBoxLocations.ValueMember = "Location.LocationId";
        }




        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var locationId = _dataModule.EventTable.Rows[_eventCurrencyManager.Position]["LocationId"];
            _locationCurrencyManager.Position = _dataModule.LocationView.Find(locationId);
        }

        private void eventDownBtn_Click(object sender, EventArgs e)
        {
            if (_eventCurrencyManager.Position < _eventCurrencyManager.Count - 1)
                _eventCurrencyManager.Position++;
        }


        private void eventUpBtn_Click(object sender, EventArgs e)
        {
            if (_eventCurrencyManager.Position > 0)
                _eventCurrencyManager.Position--;
        }

        private void eventReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void EnableSubMenuButton(bool ifEnableBtns)
        {
            eventUpBtn.Enabled = ifEnableBtns;
            eventDownBtn.Enabled = ifEnableBtns;
            eventUpdateBtn.Enabled = ifEnableBtns;
            eventDeleteBtn.Enabled = ifEnableBtns;
            eventReturnBtn.Enabled = ifEnableBtns;
            eventAddBtn.Enabled = ifEnableBtns;
        }

        private void eventAddBtn_Click(object sender, EventArgs e)
        {
            EnableSubMenuButton(false);

            panelAddEvent.Visible = true;
            eventListBox.Visible = false;

            panelAddEventName.Text = "";

            panelUpdateEvent.Visible = false;
            panelAddEventSaveBtn.Visible = true;

        }

        private void addEventCancelBtn_Click(object sender, EventArgs e)
        {
            EnableSubMenuButton(true);

            panelAddEvent.Visible = false;
            eventListBox.Visible = true;


        }

        private void addEventSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(panelAddEventName.Text))
            {
                MessageBox.Show("Please enter event name", "Idiot control !!!!!!!!!");
                return;
            }

            DataRow newEventRecord = _dataModule.EventTable.NewRow();

            newEventRecord["eventName"] = panelAddEventName.Text;
            newEventRecord["locationId"] = comboBoxLocations.SelectedValue;
            newEventRecord["EventDate"] = eventDatePicker.Value;

            _dataModule.EventTable.Rows.Add(newEventRecord);
            _dataModule.UpdateEventTable();

            MessageBox.Show("New event record is now successfully added!", "Succeed");
            addEventCancelBtn_Click(sender, e);
        }


        private void eventUpdateBtn_Click(object sender, EventArgs e)
        {
            EnableSubMenuButton(false);

            panelAddEvent.Visible = true;
            eventListBox.Visible = false;
            panelUpdateEvent.Visible = true;
            panelAddEventSaveBtn.Visible = false;

            var updateEventRecord = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];
            panelAddEventName.Text = updateEventRecord["eventName"].ToString();
            comboBoxLocations.SelectedValue = updateEventRecord["locationId"];
            try
            {
                eventDatePicker.Value = (DateTime)updateEventRecord["EventDate"];
            }
            catch (StrongTypingException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void panelUpdateEvent_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(panelAddEventName.Text))
            {
                MessageBox.Show("Please enter event name", "Idiot control !!!!!!!!!");
                return;
            }

            var updateEventRecord = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];

            updateEventRecord["eventName"] = panelAddEventName.Text;
            updateEventRecord["locationId"] = comboBoxLocations.SelectedValue;
            updateEventRecord["EventDate"] = eventDatePicker.Value;

            _eventCurrencyManager.EndCurrentEdit();
            _dataModule.UpdateEventTable();

            MessageBox.Show("Record successfully updated!", "Succeed");
            addEventCancelBtn_Click(sender, e);
        }

        private void eventDeleteBtn_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];

            var id = deleteEventRow["EventId"].ToString();
            DataRow[] anyKaiRow = _dataModule.KaiTable.Select("EventId =" + id);

            if (anyKaiRow.Length != 0)
            {
                MessageBox.Show("You may only delete an location that has no events", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEventRow.Delete();
                _dataModule.UpdateEventTable();
            }
        }
    }
}
