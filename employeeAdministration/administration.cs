using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace employeeAdministration
{
    public partial class administration : Form
    {
        public administration()
        {
            InitializeComponent();
        }

        private void administration_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            tools searchtool = new tools();

            if (searchfield.Text =="")
                      // Messagebox.anzeigen ( Text, Titel, Buttons, Icon)
            { MessageBox.Show("Please enter what you are looking for", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
	        {           
            //string firstchar = searchfield.Text.ToString().Substring(0,2);
            // MessageBox.Show(toproof,"Wert von toproof", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool result = false;

                
                    result = searchtool.checkValue("name", searchfield.Text.ToString());
                    if (result == true)
                    {
                        MessageBox.Show("its a name", "expression kind", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else 
                    {
                       result = searchtool.checkValue("number", searchfield.Text.ToString()); 
                       if (result == true)
                        {
                            MessageBox.Show("its a number", "expression kind", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a correct Expression", "Wrong Expression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                        
                
                //result == false 
            }


            // if determineInput==name 
            // 1. searchtool.checkValue("name",hgfjdkdkd) wenn falsch brich ab
            // 2. datenbank suche alle daten zu dem namen raus und packe sie ins datagrid
            // else if determineInput==ziffer 
            // 1. searchtool.checkValue("number",1234)
            // 2. datenbank suche alle verdienste in der spanne raus und packe sie ins datagrid
            // else
            // 1. falsche eingabe nochmal
        }
    }
}
