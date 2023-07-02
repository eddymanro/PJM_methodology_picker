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
            processGraphData();
        }

        private void inchideBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function to proceess the data for the graph
        public void processGraphData() 
        {
            Dictionary<Atribute, Metodologii> tempDict = Program.getProjecData().getDict();
            Program.deleteProjectObject();

            switch (tempDict[Atribute.Buget]) 
            {
                case Metodologii.Agile: 
                    A_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    A_W.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Cerinte])
            {
                case Metodologii.Agile:
                    B_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    B_W.BringToFront();
                    break;
                case Metodologii.Ambele:
                    B_AW.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Ciclu_De_Dezvoltare])
            {
                case Metodologii.Agile:
                    C_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    C_W.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Domeniu_Aplicare])
            {
                case Metodologii.Agile:
                    D_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    D_W.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Managementul_Partilor_Interesate])
            {
                case Metodologii.Agile:
                    E_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    E_W.BringToFront();
                    break;
                case Metodologii.Ambele:
                    E_AW.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Marimea_Echipei])
            {
                case Metodologii.Agile:
                    F_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    F_W.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Obiectivele])
            {
                case Metodologii.Agile:
                    G_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    G_W.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Planificarea_Managementului_de_Proiect])
            {
                case Metodologii.Agile:
                    H_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    H_W.BringToFront();
                    break;
                case Metodologii.Ambele:
                    H_AW.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Resursele])
            {
                case Metodologii.Agile:
                    I_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    I_W.BringToFront();
                    break;
                case Metodologii.Ambele:
                    I_AW.BringToFront();
                    break;
            }

            switch (tempDict[Atribute.Timpul])
            {
                case Metodologii.Agile:
                    J_A.BringToFront();
                    break;
                case Metodologii.Waterfall:
                    J_W.BringToFront();
                    break;
            }

        }

    }
}
