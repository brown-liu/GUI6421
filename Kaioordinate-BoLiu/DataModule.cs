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
            kaioordinateDBSet1.EnforceConstraints = false;
            Kai = kaioordinateDBSet1.Tables["KAI"];
            Event = kaioordinateDBSet1.Tables["Event"];
            EventRegister = kaioordinateDBSet1.Tables["EventRegister"];
            LocationTable = kaioordinateDBSet1.Tables["Location"];
            Whanau = kaioordinateDBSet1.Tables["Whanau"];

        }

        private void oleDbDataAdapter2_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
