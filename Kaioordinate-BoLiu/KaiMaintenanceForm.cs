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
        private  DataModule _dataModule;
        private readonly MainForm _mainForm;
        private CurrencyManager _currencyManager;

        public KaiMaintenanceForm(DataModule dataModule,MainForm mainForm)
        {
            InitializeComponent();
            _dataModule = dataModule;
            _mainForm = mainForm;
            BindControls();
        }


        public void BindControls()
        {
            //KaiIdInputBox.DataBindings.Add("Text", _dataModule.dataSetKaioordinate, "Kai.KaiId");
            kaiMaintinanceListBox.DataSource = _dataModule.dataSetKaioordinate;

            kaiMaintinanceListBox.DisplayMember = "KAI.KaiName";
            kaiMaintinanceListBox.ValueMember = "KAI.KaiName";
            _currencyManager = (CurrencyManager)this.BindingContext[_dataModule.dataSetKaioordinate, "KAI"];

        }


        private void kaiReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
