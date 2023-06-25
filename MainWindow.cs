using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PJM_methodology_picker
{
    public partial class MainWindow : Form
    {
        List<Panel> listPanel = new List<Panel>();
        private int idx = 0;
        private int pg_nr = 1;
        private ConnectToDb connection;
        private ProjectModel projectData;
        public MainWindow()
        {
            InitializeComponent();
            panelA.BringToFront();
            connection = new ConnectToDb();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Methodology mthd = new Methodology();

            //verificare field nume proiect
            if (numeProiectField.Text == "")
            {
                MessageBox.Show("Please enter a project name", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                mthd.setProjName(numeProiectField.Text);
            }

            if (!A_1_1.Checked && !A_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from A category!");
                return;
            }
            else
            {
                if (A_1_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Buget
            mthd.checkSelection(Atribute.Buget);

            if (!B_1_1.Checked && !B_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from B category!");
                return;
            }
            else
            {
                if (B_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            if (!B_2_1.Checked && !B_2_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 2 from B category!");
                return;
            }
            else
            {
                if (B_2_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Cerinte
            mthd.checkSelection(Atribute.Cerinte);

            if (!C_1_1.Checked && !C_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from C category!");
                return;
            }
            else
            {
                if (C_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            // Check Ciclu_De_Dezvoltare
            mthd.checkSelection(Atribute.Ciclu_De_Dezvoltare);

            if (!D_1_1.Checked && !D_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from D category!");
                return;
            }
            else 
            {
                if (D_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            // Check Domeniu_Aplicare
            mthd.checkSelection(Atribute.Domeniu_Aplicare);

            if (!E_1_1.Checked && !E_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from E category!");
                return;
            }
            else
            {
                if (E_1_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            if (!E_2_1.Checked && !E_2_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 2 from E category!");
                return;
            }
            else
            {
                if (E_2_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            // Check Managementul_Partilor_Interesate
            mthd.checkSelection(Atribute.Managementul_Partilor_Interesate);

            if (!F_1_1.Checked && !F_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from F category!");
                return;
            }
            else
            {
                if (F_1_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Marimea_Echipei
            mthd.checkSelection(Atribute.Marimea_Echipei);

            if (!G_1_1.Checked && !G_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from G category!");
                return;
            }
            else
            {
                if (G_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            // Check Obiectivele
            mthd.checkSelection(Atribute.Obiectivele);

            if (!H_1_1.Checked && !H_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from H category!");
                return;
            }
            else
            {
                if (H_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            if (!H_2_1.Checked && !H_2_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 2 from H category!");
                return;
            }
            else
            {
                if (H_2_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Planificarea_Managementului_de_Proiect
            mthd.checkSelection(Atribute.Planificarea_Managementului_de_Proiect);

            if (!I_1_1.Checked && !I_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from I category!");
                return;
            }
            else
            {
                if (I_1_1.Checked == true)
                {
                    mthd.incrementWaterfall();
                }
                else
                {
                    mthd.incrementAgile();
                }
            }

            if (!I_2_1.Checked && !I_2_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 2 from I category!");
                return;
            }
            else
            {
                if (H_2_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Resursele
            mthd.checkSelection(Atribute.Resursele);

            if (!J_1_1.Checked && !J_1_2.Checked)
            {
                MessageBox.Show("Please select an option for Question 1 from J category!");
                return;
            }
            else
            {
                if (J_1_1.Checked == true)
                {
                    mthd.incrementAgile();
                }
                else
                {
                    mthd.incrementWaterfall();
                }
            }

            // Check Timpul
            mthd.checkSelection(Atribute.Timpul);

            // Console helpers
            mthd.printProjNameToConsole();
            mthd.printDictToConsole();

            // Write Data to database:
            addDataToDb(mthd);

            // Open Results window:
            ViewResultGraphs viewResultGraphs = new ViewResultGraphs();
            viewResultGraphs.Show();

            this.Close();
        }

        private void addDataToDb(Methodology mt)
        {
            IMongoCollection<ProjectModel> projectsCollection = this.connection.getProjectsCollection();
            
            this.projectData = new ProjectModel
            {
                Nume_Proiect = mt.getNumeProiect(),
                Buget = mt.getDict()[Atribute.Buget].ToString(),
                Cerinte = mt.getDict()[Atribute.Cerinte].ToString(),
                Ciclu_De_Dezvoltare = mt.getDict()[Atribute.Ciclu_De_Dezvoltare].ToString(),
                Domeniu_Aplicare = mt.getDict()[Atribute.Domeniu_Aplicare].ToString(),
                Managementul_Partilor_Interesate = mt.getDict()[Atribute.Managementul_Partilor_Interesate].ToString(),
                Marimea_Echipei = mt.getDict()[Atribute.Marimea_Echipei].ToString(),
                Obiectivele = mt.getDict()[Atribute.Obiectivele].ToString(),
                Planificarea_Managementului_de_Proiect = mt.getDict()[Atribute.Planificarea_Managementului_de_Proiect].ToString(),
                Resursele = mt.getDict()[Atribute.Resursele].ToString(),
                Timpul = mt.getDict()[Atribute.Timpul].ToString(),
            };

            projectsCollection.InsertOne(projectData);
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                listPanel[--idx].BringToFront();
                pg_nr--;
                pageNr.Text = pg_nr.ToString();
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (idx < listPanel.Count - 1)
            {
                listPanel[++idx].BringToFront();
                pg_nr++;
                pageNr.Text = pg_nr.ToString();
            }
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            listPanel.Add(panelA);
            listPanel.Add(panelB);
            listPanel.Add(panelC);
            listPanel.Add(panelD);
            listPanel.Add(panelE);
            listPanel.Add(panelF);
            listPanel.Add(panelG);
            listPanel.Add(panelH);
            listPanel.Add(panelI);
            listPanel.Add(panelJ);
            listPanel[idx].BringToFront();
        }
    }
}
