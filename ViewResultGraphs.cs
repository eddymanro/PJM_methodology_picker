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
    public partial class ViewResultGraphs : Form
    {
        public ViewResultGraphs()
        {
            InitializeComponent();
            pictureBox.BringToFront();
        }

        private void inchideBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
