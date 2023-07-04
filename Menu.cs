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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void viewDbBtn_Click(object sender, EventArgs e)
        {
            ViewDatabaseWindow viewDb = new ViewDatabaseWindow();
            viewDb.Show();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
