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
    public partial class DataModule : Form
    {
        public DataTable Kai;
        public DataTable Event;
        public DataTable EventRegister;
        public DataTable LocationTable;
        public DataTable Whanau;

        public DataModule()
        {
            InitializeComponent();
            dataSetKaioordinate.EnforceConstraints = false;

            Kai = dataSetKaioordinate.Tables["KAI"];
            KaiTableAdaptor.Fill(dataSetKaioordinate);

            Event = dataSetKaioordinate.Tables["Event"];
            EventRegistorAdaptor.Fill(dataSetKaioordinate);

            EventRegister = dataSetKaioordinate.Tables["EventRegister"];
            EventRegistorAdaptor.Fill(dataSetKaioordinate);

            LocationTable = dataSetKaioordinate.Tables["Location"];
            LocationAdaptor.Fill(dataSetKaioordinate);

            Whanau = dataSetKaioordinate.Tables["Whanau"];
            WhanauAdapter.Fill(dataSetKaioordinate);

            dataSetKaioordinate.EnforceConstraints = true;
        }

        private void oleDbDataAdapter2_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateKaiTable()
        {
            KaiTableAdaptor.Update(Kai);
        }

    }
}
