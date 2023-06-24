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

        public ViewDatabaseWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
            fetchNewData();
        }

        public void fetchNewData() 
        {
            
            Program.populateArraylist(connection.getProjectsCollection(), Program.getProjectList());
            List<ProjectModel> localList = Program.getProjectList();
            dataGridV.DataSource = localList;
            // Hide databese id column
            dataGridV.Columns[0].Visible = false;
        }

        public void removeData()
        {
            Program.clearList(Program.getProjectList());
            dataGridV.DataSource = null;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            removeData();
            this.Close();
        }
    }
}
