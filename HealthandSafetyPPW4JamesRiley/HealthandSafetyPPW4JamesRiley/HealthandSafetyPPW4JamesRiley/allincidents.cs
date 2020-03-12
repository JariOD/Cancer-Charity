using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HealthandSafetyPPW4JamesRiley
{
    public partial class allincidents : Form
    {

        public allincidents()
        {
            InitializeComponent();
        }

  
        
        private void Openform_Click(object sender, EventArgs e)
        {
            //opens new incident form 
            addincidents f2 = new addincidents();
            f2.ShowDialog();
        }

      
        private void CreateBasicTable()
        {
            //Creates basic StreamReader and adds it to table
            using (StreamReader sr = new StreamReader("incident.txt"))
            {
                while (sr.Peek() != -1)
                {
                    ListViewItem various = new ListViewItem(sr.ReadLine());
                    for (int i = 1; i < 7; i++)
                    {
                        various.SubItems.Add(sr.ReadLine());
                    }
                    listViewData.Items.Add(various);
                }
            }


            //Assigns variables for follow up counter and percentage counter
            int iCountPub = 0;
            int iCount = 0;
            String[] sArray = new String[7];

            //Iterates through txt file and adds 1 for every public incident and yes followup
            using (StreamReader sr = new StreamReader("incident.txt"))
            {
                while (sr.Peek() != -1)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        sArray[i] = sr.ReadLine();
                    }
                    if (sArray[6] == "Yes")
                    {
                        iCount++;
                    }
                    if (sArray[2] == "Public")
                    {
                        iCountPub++;
                    }


                }
            }
            
        //Calculation for the percentage of followup 
            int iTotalItems = listViewData.Items.Count;
            double Cherry = ((double)iCountPub / (double)iTotalItems) * 100;

            //Calculation for the percentage of followup 
                txtPercent.Text = Convert.ToString(Cherry);
            //Adds all 'Yes' from follow ups and coverts the number to string
                txtFollowUpCount.Text = Convert.ToString(iCount);
            //Counts all listview items and coverts number to string 
                txtCount.Text = listViewData.Items.Count.ToString();



        }

        //Loads information into table from text file
        private void Allincidents_Load(object sender, EventArgs e)
        {
            CreateBasicTable();
        }

        //Clears the table and iterates through the text file checking every 6 restarting when it hits no only showing Yes follow ups 
        private void ChkFollowUp_CheckedChanged(object sender, EventArgs e)
        {
            String[] sArray = new String[7];
            listViewData.Items.Clear();
            if (chkFollowUp.Checked)
            {
                using (StreamReader sr = new StreamReader("incident.txt"))
                {
                    while (sr.Peek() != -1)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            sArray[i] = sr.ReadLine();
                        }
                        if (sArray[6] == "No")
                        {
                            continue;
                        }
                        ListViewItem various = new ListViewItem(sArray[0]);
                        for (int i = 1; i < sArray.Length; i++)
                        {
                            various.SubItems.Add(sArray[i]);
                        }
                        listViewData.Items.Add(various);
                    }
                }
            } else
            {
                CreateBasicTable();
            } 
        }

        // Button updates the table with new values 
        private void Button1_Click(object sender, EventArgs e)
        {
            listViewData.Items.Clear();
            CreateBasicTable();
        }

    }
}

