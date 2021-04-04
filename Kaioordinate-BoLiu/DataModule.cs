using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// DataModule handles data in and out from each table
/// </summary>
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

            KaiTableAdaptor.Fill(dataSetKaioordinate);
            EventRegistorAdaptor.Fill(dataSetKaioordinate);
            EventAdaptor.Fill(dataSetKaioordinate);
            LocationAdaptor.Fill(dataSetKaioordinate);
            WhanauAdapter.Fill(dataSetKaioordinate);


            KaiTable = dataSetKaioordinate.Tables["KAI"];
            EventTable = dataSetKaioordinate.Tables["EVENT"];
            EventRegisterTable = dataSetKaioordinate.Tables["EVENTREGISTER"];
            LocationTable = dataSetKaioordinate.Tables["Location"];
            WhanauTable = dataSetKaioordinate.Tables["Whanau"];

            KaiView = new DataView(KaiTable);
            KaiView.Sort = "KaiID";
            EventView = new DataView(EventTable);
            EventView.Sort = "EventID";
            EventRegisterView = new DataView(EventRegisterTable);
            EventRegisterView.Sort = "RegistrationID";
            LocationView = new DataView(LocationTable);
            LocationView.Sort = "LocationID";
            WhanauView = new DataView(WhanauTable);
            WhanauView.Sort = "WhanauID";

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

        public void UpdateEventTable()
        {
            EventAdaptor.Update(EventTable);
        }

        public void UpdateEventRegisterTable()
        {
            EventRegistorAdaptor.Update(EventRegisterTable);
        }

        public void UpdateLocationTable()
        {
            LocationAdaptor.Update(LocationTable);
        }

        public void UpdateWhanauTable()
        {
            WhanauAdapter.Update(WhanauTable);
        }
    }
}
