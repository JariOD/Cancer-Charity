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
    public partial class addincidents : Form
    {
        public addincidents()
        {
            InitializeComponent();
        }

        // On click clears form text boxes
        private void Clear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtBoxTreatment.Clear();


        }

        //Creates function to check the if the ID entered is unique by converting the id to a string and checking it against the text file lines
        private Boolean checkUniqueID(int piID)
        {
            String sID = Convert.ToString(piID);
            using (StreamReader sr = new StreamReader("incident.txt"))
            {
                while (sr.Peek() != -1)
                {
                    if (sID == sr.ReadLine())
                    {
                        return false;
                    }
            
                }
            }
            return true;
        }



        //Function to check that no aspect of the form is left blank.
        private String validate(String psVal)
        {
            if (String.IsNullOrEmpty(psVal))
            {
                throw new ArgumentException("Please enter all data");
            }
            return psVal;
        }


        //Function to submit information from the form to the text file. 
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
           
            
                //Uses variables to assign values to the checkboxes so they can be recorded in a text file. 
                string sTreatment = " ";
                string sFollowup = " ";

                if (rdbtreatmentyes.Checked)
                {
                    sTreatment = "Yes";
                }
                else
                {
                    sTreatment = "No";
                    txtBoxTreatment.Text = "N/A";
                }

                if (rdbfolluwupyes.Checked)
                {
                    sFollowup = "Yes";
                }
                else
                {
                    sFollowup = "No";
                }


                
                try
                {
                    //checks if the txtId is empty if not converts it to int 
                    String sId = validate(txtId.Text);
                    int id = Convert.ToInt32(sId);
                    //If 
                    if (checkUniqueID(id) == false)
                    {
                        MessageBox.Show("Please enter  a unique ID");
                        return;
                    }

                    //checks each part of the array if it's empty. 
                    validate(txtName.Text);
                    validate(comboIncident.Text);
                    validate(txtDescription.Text);
                    validate(txtLocation.Text);


                    //if treatment is equal to yes then it will check that the treatment description box is not empty
                    if (sTreatment == "Yes")
                    {
                        validate(txtBoxTreatment.Text);
                    }
                }


                    // Send out the error message from the function
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message);
                    return;

                    //Cast exception checks that the correct format e.g Int, Bool, CHar etc is used if not it creates a message box.
                } catch (InvalidCastException)
                {
                    MessageBox.Show("Please enter a number for the ID");
                }

                //Writes form info to text file  
                string[] form = { txtId.Text, txtName.Text, comboIncident.Text, txtDescription.Text, txtLocation.Text, sTreatment + " " + txtBoxTreatment.Text, sFollowup};
                using (StreamWriter sw = new StreamWriter("incident.txt", true))
                {

                    for (int i = 0; i < form.Length; i++)
                {
                    sw.WriteLine(form[i]);
                }


            }
            this.Close();
        }

        //Sets visibility of the Treatment text box to true if the user wishes to add a treatment description
        private void Rdbtreatmentyes_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtreatmentyes.Checked)
            {
                txtBoxTreatment.Visible = true;
            }
        }
        //Sets visibility of the Treatment text box to false if the user doesn't wish to add a treatment description
        private void Rdbtreatmentno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtreatmentno.Checked)
            {
                txtBoxTreatment.Visible = false;
            }
        }

   
    }
}
               
               
                
