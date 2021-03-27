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
        private CurrencyManager _eventCurrencyManager;

    
        public LocationManagementForm(DataModule dataModule, MainForm mainForm)
        {
            InitializeComponent();
        }
    }
}
