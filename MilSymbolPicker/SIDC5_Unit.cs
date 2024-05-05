using System.Windows.Forms;


using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MilitarySymbols;
using System.IO;
//using Svg;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;


namespace MilSymbolPicker
{
    /// <summary>
    /// 2525D Touch Symbol Picker Form
    /// </summary>
    public partial class FormPicker : Form
    {
        // UNIT Selections

        private void RB_Unit_CheckedChanged(object sender, EventArgs e)
        {

            //reset all
            tbSIDC_5.Text = "U";  //SIDC 5: Unit
            tbSIDC_6.Text = "-";
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            tbSIDC_11.Text = "-";
            tbSIDC_12.Text = "-";
            RB_U_None.Checked = true;
            CB_TF.Checked = false;
            CB_HQ.Checked = false;
        }

        //SIDC 6

        private void RB_U_None_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "-";  //SIDC 6: Unit / Special
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC7_U.Items.Clear(); lb_SIDC7_U.Items.Add('-');
            lb_SIDC8_U.Items.Clear(); lb_SIDC8_U.Items.Add('-');
            tbSIDC_9.Text = "-";
        }
        private void RV_UC_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "C";  //SIDC 6: Unit / Combat
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            lb_SIDC7_U.Items.Clear();
            char[] W_List = new char[] { '-', 'D', 'A', 'V', 'I', 'E', 'F', 'R', 'S' };
            foreach (char c in W_List) lb_SIDC7_U.Items.Add(c);

            lb_SIDC8_U.Items.Clear(); lb_SIDC8_U.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_UU_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "U";  //SIDC 6: Unit / Combat Support
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            lb_SIDC7_U.Items.Clear();
            char[] W_List = new char[] { '-', 'A', 'M', 'L', 'S', 'I', 'P', 'E' };
            foreach (char c in W_List) lb_SIDC7_U.Items.Add(c);

            lb_SIDC8_U.Items.Clear(); lb_SIDC8_U.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_US_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "S";  //SIDC 6: Unit / Special
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            lb_SIDC7_U.Items.Clear();
            char[] W_List = new char[] { '-', 'A', 'M', 'S', 'T', 'X' };
            foreach (char c in W_List) lb_SIDC7_U.Items.Add(c);

            lb_SIDC8_U.Items.Clear(); lb_SIDC8_U.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_UH_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "H";  //SIDC 6: Unit / Combat Service Support
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            lb_SIDC7_U.Items.Clear();
            lb_SIDC8_U.Items.Clear(); 
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }


        private void lb_SIDC7_U_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_7.Text = lb_SIDC7_U.Text;
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC8_U.Items.Clear();
            LB_SIDC_U_9and10.Items.Clear();

            //UC
            if (tbSIDC_6.Text == "C")  //UC Unit / Combat
            {
                if (tbSIDC_7.Text == "D") //UCD
                {
                    char[] W_List = new char[] { '-', 'S', 'M', 'H', 'G', 'C', 'T', 'O' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                //UCA
                else if (tbSIDC_7.Text == "A")
                {
                    char[] W_List = new char[] { '-', 'T', 'W', 'A' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "V")  //UCV
                {
                    char[] W_List = new char[] { '-', 'F', 'R', 'S', 'C', 'V', 'U' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "I")  //UCI
                {
                    char[] W_List = new char[] { '-', 'L', 'M', 'O', 'A', 'S', 'Z', 'N', 'I', 'C' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "E")  //UCE
                {
                    char[] W_List = new char[] { '-', 'C', 'N' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "F")  //UCF
                {
                    char[] W_List = new char[] { '-', 'H', 'R', 'T', 'M', 'S', 'O' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "R")  //UCR
                {
                    char[] W_List = new char[] { '-', 'H', 'V', 'C', 'S', 'A', 'O', 'L', 'R', 'X' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "M")  //UCM
                {
                    char[] W_List = new char[] { '-', 'T', 'S' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "S")  //UCS
                {
                    char[] W_List = new char[] { '-', 'W', 'G', 'M', 'R', 'A' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
            }

            //UU
            else if (tbSIDC_6.Text == "U") //UU  Unit Support
            {
                if (tbSIDC_7.Text == "A") //UUA
                {
                    char[] W_List = new char[] { '-', 'C', 'N', 'B', 'D' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "M") //UUM
                {
                    char[] W_List = new char[] { '-', 'A', 'S', 'C', 'R', 'M', 'O', 'T', 'Q', 'J' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "L") //UUL
                {
                    char[] W_List = new char[] { '-', 'S', 'M', 'C', 'F', 'D' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "S") //UUS
                {
                    char[] W_List = new char[] { '-', 'A', 'C', 'O', 'F', 'M', 'R', 'S', 'W', 'X' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
            }


            //US
            else if (tbSIDC_6.Text == "S") //US  Unit/CSS
            {
                if (tbSIDC_7.Text == "A") //USA
                {
                    char[] W_List = new char[] { '-', 'T', 'C', 'J', 'O', 'F', 'S', 'M', 'R', 'P', 'X', 'L', 'W', 'Q' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "M") //USM
                {
                    char[] W_List = new char[] { '-', 'T', 'C', 'M', 'V', 'D', 'P' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "S") //USS
                {
                    char[] W_List = new char[] { '-', 'T', 'C', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'X', 'L', 'W' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "T") //UST
                {
                    char[] W_List = new char[] { '-', 'T', 'C', 'M', 'R', 'S', 'A', 'I' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "X") //USX
                {
                    char[] W_List = new char[] { '-', 'T', 'C', 'H', 'O', 'E' };
                    foreach (char c in W_List) lb_SIDC8_U.Items.Add(c);
                }
            }

            //UH
            else if (tbSIDC_6.Text == "H")  //UH  Unit/Special
            {
                //nothing to do               
            }
        }



    }
}
