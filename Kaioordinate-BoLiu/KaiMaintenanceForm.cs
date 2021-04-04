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
    public partial class KaiMaintenanceForm : Form
    {
        private DataModule _dataModule;
        private MainForm _mainForm;
        private CurrencyManager _kaiCurrencyManager;
        private CurrencyManager _eventCurrencyManager;

        public KaiMaintenanceForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;
            _mainForm = mainForm;

            InitializeComponent();


            BindControls();
        }


        public void BindControls()
        {
            _kaiCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "KAI"];
            _eventCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "EVENT"];


            //Linking textbox data
            kaiIDdislay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.KaiId");

            eventDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Event.EventName");

            preparationDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.PreparationRequired");
            preparationTimeDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.PreparationMinutes");
            kaiNameDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.KaiName");
            serveQuantityDisplay.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.ServeQuantity");



            kaiMaintinanceListBox.DataSource = _dataModule.dataSetKaioordinate;
            kaiMaintinanceListBox.DisplayMember = "KAI.KaiName";
            kaiMaintinanceListBox.ValueMember = "KAI.KaiName";



        }


        private void kaiReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kaiUpBtn_Click(object sender, EventArgs e)
        {
            if (_kaiCurrencyManager.Position > 0)
            {
                --_kaiCurrencyManager.Position;
            }
        }

        private void kaiDownBtn_Click(object sender, EventArgs e)
        {
            if (_kaiCurrencyManager.Position < _kaiCurrencyManager.Count - 1)
            {
                ++_kaiCurrencyManager.Position;

            }
        }

        private void EnableSubMenuBtns(bool ifEnable)
        {
            kaiDownBtn.Enabled = ifEnable;
            kaiUpBtn.Enabled = ifEnable;
            kaiAddBtn.Enabled = ifEnable;
            kaiReturnBtn.Enabled = ifEnable;
            kaiUpdateBtn.Enabled = ifEnable;
            kaiDeleteBtn.Enabled = ifEnable;
        }


        private void kaiAddBtn_Click(object sender, EventArgs e)
        {
            EnableSubMenuBtns(false);

            addKaiPanel.Visible = true;
            kaiMaintinanceListBox.Visible = false;
            addKaiSaveBtn.Visible = true;
            addKaiCancelBtn.Visible = true;

        }

        private void addKaiSaveBtn_Click(object sender, EventArgs e)
        {
            DataRow newKaiRecord = _dataModule.KaiTable.NewRow();
            DataRow newEventRecord = _dataModule.EventTable.NewRow();

            if (string.IsNullOrEmpty(eventDisplay.Text) || string.IsNullOrEmpty(kaiNameDisplay.Text))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "ERROR OCCURED");
                return;
            }

            newEventRecord["EventName"] = addPanelEventName.Text;
            _dataModule.EventTable.Rows.Add(newEventRecord);
            _dataModule.UpdateEventTable();
            try {
                newKaiRecord["EventId"] = newEventRecord["EventId"];
                newKaiRecord["KaiName"] = addFormKaiName.Text;
                newKaiRecord["ServeQuantity"] = Int32.Parse(addPanelServingQuantity.Text.ToString());
                newKaiRecord["PreparationMinutes"] = Int32.Parse(addPanelPreparationTime.Text.ToString());
                newKaiRecord["PreparationRequired"] = kaiAddCheckBox.Checked;
            }
            catch (FormatException) {
                MessageBox.Show("Please input correct format", "Input error!");
                return;
            }




            _dataModule.KaiTable.Rows.Add(newKaiRecord);
            _dataModule.UpdateKaiTable();



            MessageBox.Show("Kai updated successfully", "Action succeed!");
            addKaiCancelBtn_Click(sender, e);

        }

        private void addKaiCancelBtn_Click(object sender, EventArgs e)
        {
            addKaiPanel.Visible = false;
            kaiMaintinanceListBox.Visible = true;
            addKaiSaveBtn.Visible = false;
            addKaiCancelBtn.Visible = false;
            updateKaiBtn.Visible = false;

            EnableSubMenuBtns(true);

        }

        private void kaiMaintinanceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventID = _dataModule.KaiTable.Rows[_kaiCurrencyManager.Position]["EventID"];
            _eventCurrencyManager.Position = _dataModule.EventView.Find(eventID);
        }

        private void kaiDeleteBtn_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = _dataModule.KaiTable.Rows[_kaiCurrencyManager.Position];

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteKaiRow.Delete();
                _dataModule.UpdateKaiTable();
            }
        }

        private void kaiUpdateBtn_Click(object sender, EventArgs e)
        {


            EnableSubMenuBtns(false);
            addKaiPanel.Visible = true;
            kaiMaintinanceListBox.Visible = false;
            updateKaiBtn.Visible = true;
            addKaiCancelBtn.Visible = true;

            var currentKaiRow = _dataModule.KaiTable.Rows[_kaiCurrencyManager.Position];
            var currentEventRow = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];

            addPanelEventName.Text = currentEventRow["EventName"].ToString();
            addFormKaiName.Text = currentKaiRow["KaiName"].ToString();
            kaiAddCheckBox.Checked = (bool)currentKaiRow["PreparationRequired"];
            addPanelPreparationTime.Text = currentKaiRow["PreparationMinutes"].ToString();
            addPanelServingQuantity.Text = currentKaiRow["ServeQuantity"].ToString();

        }

        private void updateKaiBtn_Click(object sender, EventArgs e)
        {
            var currentKaiRow = _dataModule.KaiTable.Rows[_kaiCurrencyManager.Position];
            var currentEventRow = _dataModule.EventTable.Rows[_eventCurrencyManager.Position];

            if (addPanelEventName.Text == "" || addFormKaiName.Text == "" || addPanelServingQuantity.Text == "" || addPanelPreparationTime.Text == "")
            {

                MessageBox.Show("You must enter a value for each of the text fields", "ERROR OCCURED");
                return;

            }


            currentEventRow["EventName"] = addPanelEventName.Text;
            _eventCurrencyManager.EndCurrentEdit();
            _dataModule.UpdateEventTable();


            currentKaiRow["EventId"] = currentEventRow["EventId"];
            currentKaiRow["KaiName"] = addFormKaiName.Text;
            currentKaiRow["ServeQuantity"] = Int32.Parse(addPanelServingQuantity.Text.ToString());
            currentKaiRow["PreparationMinutes"] = Int32.Parse(addPanelPreparationTime.Text.ToString());
            currentKaiRow["PreparationRequired"] = kaiAddCheckBox.Checked;

            _kaiCurrencyManager.EndCurrentEdit();
            _dataModule.UpdateKaiTable();

            MessageBox.Show("Kai updated successfully", "Action succeed!");
            addKaiCancelBtn_Click(sender, e);
        }
    }
}
