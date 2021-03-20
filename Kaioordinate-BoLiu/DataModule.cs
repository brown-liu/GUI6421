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
        public DataTable KaiTable;
        public DataTable EventTable;
        public DataTable EventRegisterTable;
        public DataTable LocationTable;
        public DataTable WhanauTable;

        public DataView KaiView;
        public DataView EventView;
        public DataView EventRegisterView;
        public DataView LocationView;
        public DataView WhanauView;

        public DataModule()
        {
            InitializeComponent();
            dataSetKaioordinate.EnforceConstraints = false;

            KaiTable = dataSetKaioordinate.Tables["KAI"];
            KaiTableAdaptor.Fill(dataSetKaioordinate);
            KaiView = new DataView(KaiTable);
            KaiView.Sort = "KaiID";

            EventTable = dataSetKaioordinate.Tables["Event"];
            EventRegistorAdaptor.Fill(dataSetKaioordinate);
            EventView = new DataView(EventTable);
            EventView.Sort = "EventId";

            EventRegisterTable = dataSetKaioordinate.Tables["EventRegister"];
            EventRegistorAdaptor.Fill(dataSetKaioordinate);
            EventRegisterView = new DataView(EventRegisterTable);
            EventRegisterView.Sort = "RegistrationId";

            LocationTable = dataSetKaioordinate.Tables["Location"];
            LocationAdaptor.Fill(dataSetKaioordinate);
            LocationView = new DataView(LocationTable);
            LocationView.Sort = "locationId";

            WhanauTable = dataSetKaioordinate.Tables["Whanau"];
            WhanauAdapter.Fill(dataSetKaioordinate);
            WhanauView = new DataView(WhanauTable);
            WhanauView.Sort = "WhanauId";




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
            KaiTableAdaptor.Update(KaiTable);
        }

    }
}
