using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate_BoLiu
{
    public partial class WhanauManagementForm : Form
    {
        private DataModule _dataModule;
        private MainForm _mainForm;
        private CurrencyManager _whanauCurrencyManager;

        public WhanauManagementForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;
            _mainForm = mainForm;
            InitializeComponent();

            _whanauCurrencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "Whanau"];


            displayWhanauId.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.WhanauId");
            displayFirstName.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.FirstName");
            displayLastName.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.LastName");
            displayEmail.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.Email");
            displayAddress.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.Address");
            displayPhone.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Whanau.Phone");

            whanauListBox.DataSource = _dataModule.dataSetKaioordinate;
            whanauListBox.DisplayMember = "Whanau.FirstName";
            whanauListBox.ValueMember = "Whanau.FirstName";


        }

        private void whanauReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void whanauListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void whanauUpBtn_Click(object sender, EventArgs e)
        {
            if (_whanauCurrencyManager.Position > 0)
                _whanauCurrencyManager.Position--;
        }

        private void whanauDownBtn_Click(object sender, EventArgs e)
        {
            if (_whanauCurrencyManager.Position < _whanauCurrencyManager.Count - 1)
                _whanauCurrencyManager.Position++;
        }

        private void whanauAddBtn_Click(object sender, EventArgs e)
        {


            panelAddWhannau.Visible = true;
            panelUpdateWhanauBtn.Visible = false;
            panelAddWhanauBtn.Visible = true;
            whanauListBox.Visible = false;
            EnableSubMenuButton(false);
        }

        private void panelCancel_Click(object sender, EventArgs e)
        {

            panelAddWhannau.Visible = false;
            whanauListBox.Visible = true;
            EnableSubMenuButton(true);
        }

        private void EnableSubMenuButton(bool ifEnableBtns)
        {
            whanauDownBtn.Enabled = ifEnableBtns;
            whanauAddBtn.Enabled = ifEnableBtns;
            whanauDeleteBtn.Enabled = ifEnableBtns;
            whanauReturnBtn.Enabled = ifEnableBtns;
            whanauUpBtn.Enabled = ifEnableBtns;
            whanauUpdateBtn.Enabled = ifEnableBtns;
        }

        private void panelAddWhanau_Click(object sender, EventArgs e)
        {
            var fName = panelAddFirstName.Text;
            var lName = panelAddLastName.Text;
            var email = panelAddEmail.Text;
            var phone = panelAddPhone.Text;
            var address = panelAddAddress.Text;

            if (string.IsNullOrEmpty(fName) ||
                string.IsNullOrEmpty(lName) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address)
                )
            {
                MessageBox.Show("Please complete auto fields before save", "Idiot control !!!!!!!!!");
                return;
            }

            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                MessageBox.Show("Email address is not valid", "Idiot control !!!!!!!!!");
                return;
            }

            var newWhanauDetails = _dataModule.WhanauTable.NewRow();

            newWhanauDetails["FirstName"] = fName;
            newWhanauDetails["LastName"] = lName;
            newWhanauDetails["Email"] = email;
            newWhanauDetails["Phone"] = phone;
            newWhanauDetails["Address"] = address;

            _dataModule.WhanauTable.Rows.Add(newWhanauDetails);
            _dataModule.UpdateWhanauTable();
            MessageBox.Show("Whānau added successfully", "Succeed");
            panelCancel_Click(sender, e);
        }

        private void whanauUpdateBtn_Click(object sender, EventArgs e)
        {
            EnableSubMenuButton(false);
            panelAddWhannau.Visible = true;
            whanauListBox.Visible = false;
            panelUpdateWhanauBtn.Visible = true;
            panelAddWhanauBtn.Visible = false;

            var whanauRecord = _dataModule.WhanauTable.Rows[_whanauCurrencyManager.Position];

            panelAddFirstName.Text = whanauRecord["FirstName"].ToString();
            panelAddLastName.Text = whanauRecord["LastName"].ToString();
            panelAddEmail.Text = whanauRecord["Email"].ToString();
            panelAddPhone.Text = whanauRecord["Phone"].ToString();
            panelAddAddress.Text = whanauRecord["Address"].ToString();


        }

        private void panelUpdateWhanauBtn_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(panelAddFirstName.Text) ||
            string.IsNullOrEmpty(panelAddLastName.Text) ||
            string.IsNullOrEmpty(panelAddEmail.Text) ||
            string.IsNullOrEmpty(panelAddPhone.Text) ||
            string.IsNullOrEmpty(panelAddAddress.Text))
            {
                MessageBox.Show("Please complete auto fields before save", "Idiot control !!!!!!!!!");
                return;
            }
            bool isEmail = Regex.IsMatch(panelAddEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                MessageBox.Show("Email address is not valid", "Idiot control !!!!!!!!!");
                return;
            }
            var whanauRecord = _dataModule.WhanauTable.Rows[_whanauCurrencyManager.Position];

            whanauRecord["FirstName"] = panelAddFirstName.Text;
            whanauRecord["LastName"] = panelAddLastName.Text;
            whanauRecord["Email"] = panelAddEmail.Text;
            whanauRecord["Phone"] = panelAddPhone.Text;
            whanauRecord["Address"] = panelAddAddress.Text;

            _whanauCurrencyManager.EndCurrentEdit();
            _dataModule.UpdateWhanauTable();

            MessageBox.Show("Whānau updated successfully", "Succeed");
            panelCancel_Click(sender, e);
        }

        private void whanauDeleteBtn_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = _dataModule.WhanauTable.Rows[_whanauCurrencyManager.Position];

            var whanauId = deleteWhanauRow["whanauId"].ToString();

            DataRow[] anyRegistrationRow = _dataModule.EventRegisterTable.Select("whanauId =" + whanauId);

            if (anyRegistrationRow.Length != 0)
            {
                MessageBox.Show("You may only delete records that have no registrations", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteWhanauRow.Delete();
                _dataModule.UpdateWhanauTable();
                MessageBox.Show("Whānau deleted successfully", "Succeed");
            }


        }
    }
}
