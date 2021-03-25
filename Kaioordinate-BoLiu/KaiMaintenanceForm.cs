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

        private void kaiAddBtn_Click(object sender, EventArgs e)
        { //read only mode
            labelKaiId.Visible = false;
            kaiDownBtn.Enabled = false;
            kaiUpBtn.Enabled = false;
            kaiAddBtn.Enabled = false;
            kaiReturnBtn.Enabled = false;
            kaiUpdateBtn.Enabled = false;
            kaiDeleteBtn.Enabled = false;
            kaiMaintinanceListBox.Visible = false;
            addKaiSaveBtn.Visible = true;
            addKaiCancelBtn.Visible = true;
            kaiIDdislay.Visible = false;
            preparationDisplay.Visible = false;

            eventDisplay.ReadOnly = false;
            eventDisplay.Text = "";
            kaiNameDisplay.ReadOnly = false;
            kaiNameDisplay.Text = "";

            kaiAddCheckBox.Visible = true;
            preparationTimeDisplay.ReadOnly = false;
            serveQuantityDisplay.ReadOnly = false;


        }

        private void addKaiSaveBtn_Click(object sender, EventArgs e)
        {
            DataRow newKaiRecord = _dataModule.KaiTable.NewRow();
            if (string.IsNullOrEmpty(eventDisplay.Text) || string.IsNullOrEmpty(kaiNameDisplay.Text))
            {
                MessageBox.Show("You must enter a value for each of the text fields", "ERROR OCCURED");
                return;
            }


            newKaiRecord["KaiName"] = eventDisplay.Text;
            newKaiRecord["ServeQuantity"] = Int32.Parse(serveQuantityDisplay.Text.ToString());
            newKaiRecord["PreparationMinutes"] = Int32.Parse(preparationTimeDisplay.Text.ToString());
            newKaiRecord["PreparationRequired"] = preparationDisplay.Text;
            _dataModule.KaiTable.Rows.Add(newKaiRecord);
            _dataModule.UpdateKaiTable();
            MessageBox.Show("Kai updated successfully", "Action succeed!");
        }

        private void addKaiCancelBtn_Click(object sender, EventArgs e)
        {

            labelKaiId.Visible = true;
            kaiDownBtn.Enabled = true;
            kaiUpBtn.Enabled = true;
            kaiAddBtn.Enabled = true;
            kaiReturnBtn.Enabled = true;
            kaiUpdateBtn.Enabled = true;
            kaiDeleteBtn.Enabled = true;
            kaiMaintinanceListBox.Visible = true;
            addKaiSaveBtn.Visible = false;
            addKaiCancelBtn.Visible = false;
            kaiIDdislay.Visible = true;
            preparationDisplay.Visible = true;

            eventDisplay.ReadOnly = true;
            kaiNameDisplay.ReadOnly = true;
            kaiAddCheckBox.Visible = false;
            preparationTimeDisplay.ReadOnly = true;
            serveQuantityDisplay.ReadOnly = true;



        }

        private void kaiMaintinanceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventID = _dataModule.KaiTable.Rows[_kaiCurrencyManager.Position]["EventID"];
            _eventCurrencyManager.Position = _dataModule.EventView.Find(eventID);
        }
    }
}
