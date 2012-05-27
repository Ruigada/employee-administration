using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace employeeAdministration
{
    class tools
    {

        //////////////////////////////////////////////////////////////////////////////////
        // data checking method expects value + regular expression to check against
        // called by valuecheck method
        // returns boolean if expression matches
        //////////////////////////////////////////////////////////////////////////////////
        private bool checkString(string value, string strRegex)
        {
            return Regex.IsMatch(value, strRegex);
        }

       /* public string determineInput(string firstchar){

            checkValue()

            return result;
        
        }*/


        //////////////////////////////////////////////////////////////////////////////////
        // value checking method
        // calls check string method
        //////////////////////////////////////////////////////////////////////////////////
        public bool checkValue(string valueKind, string value)
        {
            bool valid = false;
            
           

            switch (valueKind)

            {
                case "name":
                    // Regular Expression nur BUchstaben (klein / groß) maximal 60 Stellen und min. 2 (größe des DB feldes)
                   //MessageBox.Show("checking name", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, @"^[\p{L},.-]{1,40}$");
                    break;
                
                case "number":
                    //Regular Expression nur Zahlen minimal 4 Stellen maximal 5 Stellen
                    //MessageBox.Show("checking Number", "regex check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = checkString(value, "(^[1-9]{4,5}$)");
                    break;

               /* default:
                    MessageBox.Show("Please enter a correct Expression", "Wrong Expression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;*/
            }
            return valid;
        } 
    }

    /*class MForm : Form
   {

       private DataGrid dg = null;
      public MForm()
       {

           this.Text = "DataGrid";
           this.Size = new Size(350, 300);

           this.InitUI();


           this.CenterToScreen();
       }

       void InitUI()
       {
           dg = new DataGrid();

           dg.CaptionBackColor = System.Drawing.Color.White;
           dg.CaptionForeColor = System.Drawing.Color.Black;
           dg.CaptionText = "Users";

           dg.Location = new Point(8, 0);
           dg.Size = new Size(350, 300);
           dg.TabIndex = 0;
           dg.Parent = this;
       }
   }*/
}
