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
    public partial class LocationManagementForm : Form
    {
        private DataModule _dataModule;
        private MainForm _mainForm;
        private CurrencyManager _locationCurrencyManager;


        public LocationManagementForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;
            _mainForm = mainForm;
            InitializeComponent();

            displaylocationId.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Location.LocationId");
            locationName.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Location.LocationName");
            locationAddress.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Location.Address");

            locationListBox.DataSource = _dataModule.dataSetKaioordinate;
            locationListBox.DisplayMember = "Location.LocationName";
            locationListBox.ValueMember = "Location.LocationName";

            _locationCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "Location"];

        }
        private void EnableSubMenuButton(bool ifEnableBtns)
        {
            locationDownBtn.Enabled = ifEnableBtns;
            locationAddBtn.Enabled = ifEnableBtns;
            locationDeleteBtn.Enabled = ifEnableBtns;
            locationReturnBtn.Enabled = ifEnableBtns;
            locationUpBtn.Enabled = ifEnableBtns;
            locationUpdateBtn.Enabled = ifEnableBtns;
        }

        private void locationUpBtn_Click(object sender, EventArgs e)
        {
            if (_locationCurrencyManager.Position > 0)
                _locationCurrencyManager.Position--;
        }

        private void locationDownBtn_Click(object sender, EventArgs e)
        {
            if (_locationCurrencyManager.Position < _locationCurrencyManager.Count - 1)
                _locationCurrencyManager.Position++;
        }

        private void locationReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void locationAddBtn_Click(object sender, EventArgs e)
        {
            panelAddLocation.Visible = true;
            EnableSubMenuButton(false);
            panelSaveLocationBtn.Visible = true;
            updateLocationBtn.Visible = false;
            locationListBox.Visible = false;
        }



        private void locationUpdateBtn_Click(object sender, EventArgs e)
        {
            panelAddLocation.Visible = true;
            EnableSubMenuButton(false);
            panelSaveLocationBtn.Visible = false;
            updateLocationBtn.Visible = true;
            locationListBox.Visible = false;

            var currentRecord = _dataModule.LocationTable.Rows[_locationCurrencyManager.Position];
            addPanelLocationName.Text = currentRecord["LocationName"].ToString();
            addPanelAddress.Text = currentRecord["Address"].ToString();


        }

        private void locationDeleteBtn_Click(object sender, EventArgs e)
        {
            DataRow deletelocationRow = _dataModule.LocationTable.Rows[_locationCurrencyManager.Position];

            var locationId = deletelocationRow["locationId"].ToString();

            DataRow[] anyEventRow = _dataModule.EventTable.Select("locationId =" + locationId);

            if (anyEventRow.Length != 0)
            {
                MessageBox.Show("You may only delete records that have no events", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deletelocationRow.Delete();
                _dataModule.UpdateLocationTable();
            }


        }
    

        private void addLocationCancelBtn_Click(object sender, EventArgs e)
        {
            panelAddLocation.Visible = false;
            EnableSubMenuButton(true);
            locationListBox.Visible = true;



        }

        private void panelSaveLocationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addPanelLocationName.Text) || string.IsNullOrEmpty(addPanelAddress.Text))
            {
                MessageBox.Show("Please complete auto fields before save", "Idiot control !!!!!!!!!");
                return;
            }

            var newAddress = _dataModule.LocationTable.NewRow();
            newAddress["LocationName"] = addPanelLocationName.Text;
            newAddress["Address"] = addPanelAddress.Text;

            _dataModule.LocationTable.Rows.Add(newAddress);
            _dataModule.UpdateLocationTable();
            MessageBox.Show("Location added successfully", "Succeed");
            addLocationCancelBtn_Click(sender, e);
        }

        private void updateLocationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addPanelLocationName.Text) || string.IsNullOrEmpty(addPanelAddress.Text))
            {
                MessageBox.Show("Please complete auto fields before save", "Idiot control !!!!!!!!!");
                return;
            }

            var addressToUpdate = _dataModule.LocationTable.Rows[_locationCurrencyManager.Position];
            addressToUpdate["LocationName"] = addPanelLocationName.Text;
            addressToUpdate["Address"] = addPanelAddress.Text;

            _locationCurrencyManager.EndCurrentEdit();
            _dataModule.UpdateLocationTable();
            MessageBox.Show("Location updated successfully", "Succeed");
            addLocationCancelBtn_Click(sender, e);
        }
    }
}
