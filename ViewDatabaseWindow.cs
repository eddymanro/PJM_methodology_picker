using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJM_methodology_picker
{
    public partial class ViewDatabaseWindow : Form
    {
        private ConnectToDb connection;
        private ProjectModel proj;

        public ViewDatabaseWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
            fetchNewData();
        }

        public void fetchNewData() 
        {
            /*
            Program.populateArraylist(connection.getBookstoreCollection(), Program.getBookStoresList());
            List<BookstoreModel> localList = Program.getBookStoresList();
            */
            
            //dataGridV.DataSource = localList;
            
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
