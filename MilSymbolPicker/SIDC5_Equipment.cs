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
        // EQUIPMENT Selections


        //SIDC 5
        private void RB_Equipment_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_5.Text = "E";  //SIDC 5: equipment
            tbSIDC_6.Text = "-";
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            tbSIDC_11.Text = "-";
            tbSIDC_12.Text = "-";
            RB_E_None.Checked = true;
        }



        //SIDC 6

        private void RB_E_None_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "-";  //SIDC 6: Unit / Special
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC7_E.Items.Clear(); lb_SIDC7_E.Items.Add('-');
            lb_SIDC8_E.Items.Clear(); lb_SIDC8_E.Items.Add('-');
            tbSIDC_9.Text = "-";
        }

        private void RB_EV_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "V";  //SIDC 6: Equipment / Vehicle
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC7_E.Items.Clear();
            char[] W_List = new char[] { '-', 'A', 'U', 'E', 'T', 'C', 'M' };
            foreach (char c in W_List) lb_SIDC7_E.Items.Add(c);
            lb_SIDC8_E.Items.Clear(); lb_SIDC8_E.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_EW_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "W";  //SIDC 6: Equipment / Weapon
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC7_E.Items.Clear();
            char[] W_List = new char[] { '-', 'M', 'S', 'X', 'T', 'R', 'Z', 'O', 'H', 'G', 'D', 'A' };
            foreach (char c in W_List) lb_SIDC7_E.Items.Add(c);
            lb_SIDC8_E.Items.Clear();
            lb_SIDC8_E.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_ES_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "S"; //SIDC 6: Equipment / Sensor
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC7_E.Items.Clear();
            char[] W_List = new char[] { '-', 'R', 'E' };
            foreach (char c in W_List) lb_SIDC7_E.Items.Add(c);
            lb_SIDC8_E.Items.Clear();
            lb_SIDC8_E.Items.Add('-');
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        private void RB_EX_CheckedChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = "X"; //SIDC 6: Equipment / Special Equipment
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            lb_SIDC7_E.Items.Clear();
            char[] W_List = new char[] { '-', 'L', 'N', 'F', 'M' };
            foreach (char c in W_List) lb_SIDC7_E.Items.Add(c);
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }


        //SIDC 7
        //SIDC 7 Selections Weapon, Equipment, Sensor or Special
        //USER Selected SIDC 7 so next configure list boxes for SIDC 8, 9 10 based on what SIDC 6 and 7 are
        private void lb_SIDC7_E_SelectedIndexChanged(object sender, EventArgs e)  //third letter
        {
            tbSIDC_7.Text = lb_SIDC7_E.Text;
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
            lb_SIDC8_E.Items.Clear();
            LB_SIDC_E_9and10.Items.Clear();

            //EW
            if (tbSIDC_6.Text == "W")  //EW   Equip/Weapon
            {
                if (tbSIDC_7.Text == "M") //EWM
                {
                    char[] W_List = new char[] { '-', 'A', 'S', 'T' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                //EWS   EWX   EWT  EWZ  EWO   EWH   EWG  EWD  EWA
                else if ((tbSIDC_7.Text == "S") | (tbSIDC_7.Text == "X") | (tbSIDC_7.Text == "T") | (tbSIDC_7.Text == "Z") | (tbSIDC_7.Text == "O") | (tbSIDC_7.Text == "H")
                    | (tbSIDC_7.Text == "G") | (tbSIDC_7.Text == "D") | (tbSIDC_7.Text == "A"))
                {
                    char[] W_List = new char[] { '-', 'L', 'M', 'H' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "R")  //EWR
                {
                    char[] W_List = new char[] { '-', 'R', 'L', 'H' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
            }
            //EV
            else if (tbSIDC_6.Text == "V") //EV  Equip/Vehicle
            {
                if (tbSIDC_7.Text == "A") //EVA
                {
                    char[] W_List = new char[] { '-', 'T', 'A', 'I', 'C', 'S', 'L' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "U") //EVU
                {
                    char[] W_List = new char[] { '-', 'B', 'S', 'L', 'X', 'R', 'T', 'A' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "E") //EVE
                {
                    char[] W_List = new char[] { '-', 'B', 'E', 'C', 'M', 'A', 'D', 'S', 'R', 'H', 'F' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                else if ((tbSIDC_7.Text == "T") | (tbSIDC_7.Text == "C") | (tbSIDC_7.Text == "M")) //EVT  EVC  EVM
                {
                    lb_SIDC8_E.Items.Add('-');
                }
            }


            //ES
            else if (tbSIDC_6.Text == "S") //ES  Equip/Sensor
            {
                //nothing to do
            }

            //EX
            else if (tbSIDC_6.Text == "X")  //EX  Equip/Special
            {
                if ((tbSIDC_7.Text == "L") | (tbSIDC_7.Text == "N") | (tbSIDC_7.Text == "F")) //EXL  EXN  EXF
                {
                    char[] W_List = new char[] { '-' };
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
                else if (tbSIDC_7.Text == "M") //EXM
                {
                    char[] W_List = new char[] { '-', 'C', 'L' };  //EXMC  EXML
                    foreach (char c in W_List) lb_SIDC8_E.Items.Add(c);
                }
            }


        }



        //SIDC 8
        //USER Selected SIDC 8 so configure list boxes for SIDC 8, 9 and 10 based on what SIDC 6 and 7 are
        private void lb_SIDC8_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            // user has selected E67X-- 
            tbSIDC_8.Text = lb_SIDC8_E.Text;
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            if (tbSIDC_6.Text == "W")  //EW
            {
                SetUpSIDC9and10ForEW();
            }
            else if (tbSIDC_6.Text == "V")  //EV
            {
                SetUpSIDC9and10ForEV();
            }
            else if (tbSIDC_6.Text == "S")  //ES
            {
                //No options for SIDC 9, 10
            }
            else if (tbSIDC_6.Text == "X")  //EX
            {
                //No options for SIDC 9, 10
            }
        }

        //Sets up SIDC 9 and 10 for a given SIDC 5-8 that is EWX where X is M, S, X or other
        //Preconditions:
        //  SIDC 9 and 10 cleared to '-'
        //  SIDC 5 = E, SIDC 6 = W 
        //Will setup EWM  EWS  EWX, other EW do not use SIDC 9 or 10

        private void SetUpSIDC9and10ForEW()  //handles EWM  EWS  EWX, other EW do not use SIDC 9 or 10       
        {
            LB_SIDC_E_9and10.Items.Clear();
            //EWM
            if (tbSIDC_7.Text == "M")  //EWM
            {
                if (tbSIDC_8.Text == "A")  //EWMA
                {
                    String[] W_List = new String[] { "--", "S-", "SR", "SE", "I-", "IR", "IE", "L-", "LR", "LE", "T-", "TR", "TE" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "S")  //EWMS
                {
                    String[] W_List = new String[] { "--", "S-", "I-", "L-" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "T")  //EWMT
                {
                    String[] W_List = new String[] { "--", "L-", "M-", "H-" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
            }

            //EWH
            else if (tbSIDC_7.Text == "H")  //EWH
            {
                if ((tbSIDC_8.Text == "L") | (tbSIDC_8.Text == "M") | (tbSIDC_8.Text == "H")) //EWHL ,EWHM, EWHH
                {
                    LB_SIDC_E_9and10.Items.Add("--"); LB_SIDC_E_9and10.Items.Add("S-");
                }
            }
            //EWD
            else if (tbSIDC_7.Text == "D")  //EWD
            {
                if ((tbSIDC_8.Text == "L") | (tbSIDC_8.Text == "M") | (tbSIDC_8.Text == "H")) //EWSL ,EWDM, EWDH
                {
                    LB_SIDC_E_9and10.Items.Add("--"); LB_SIDC_E_9and10.Items.Add("S-");
                }
            }
            //EWA
            else if (tbSIDC_7.Text == "A")  //EWA
            {
                if ((tbSIDC_8.Text == "L") | (tbSIDC_8.Text == "M") | (tbSIDC_8.Text == "H")) //EWSL ,EWDM, EWDH
                {
                    LB_SIDC_E_9and10.Items.Add("--"); LB_SIDC_E_9and10.Items.Add("S-");
                }
            }
        }


        private void SetUpSIDC9and10ForEV()  //handles EVA  EVU  EVE, other EW do not use SIDC 9 or 10       
        {
            LB_SIDC_E_9and10.Items.Clear();
            //EVA
            if (tbSIDC_7.Text == "A")  //EVA
            {
                if (tbSIDC_8.Text == "T")  //EVAT
                {
                    String[] W_List = new String[] { "--", "L-", "LR", "M-", "MR", "H-", "HR"};
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "A")  //EVAA
                {
                    String[] W_List = new String[] { "--", "R-" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
            }
            //EVU
            else if (tbSIDC_7.Text == "U")  //EVU
            {
                if (tbSIDC_8.Text == "S")  //EVUS
                {
                    String[] W_List = new String[] { "--", "L-", "M-", "H-"};
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "T")  //EVUT
                {
                    String[] W_List = new String[] { "--", "L-", "H-" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "A")  //EVUA
                {
                    String[] W_List = new String[] { "--", "A-"};
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
            }
            
            //EVE
            else if (tbSIDC_7.Text == "U")  //EVE
            {
                if (tbSIDC_8.Text == "A")  //EVEA
                {
                    String[] W_List = new String[] { "--", "A-", "T-"};
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "D")  //EVED
                {
                    String[] W_List = new String[] { "--", "A-" };
                    foreach (String s in W_List) LB_SIDC_E_9and10.Items.Add(s);
                }
            }
        }




        private void RB_Mobility_CheckedChanged(object sender, EventArgs e)
        {
            String s11 = ((RadioButton)sender).Text;
            //String s11 = RB_MO.Text;
            tbSIDC_11.Text = s11.Substring(0, 1);
            tbSIDC_12.Text = s11.Substring(1, 1);
        }

        private void LB_SIDC_E_9and10_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s11 = LB_SIDC_E_9and10.Text;
            tbSIDC_9.Text = s11.Substring(0, 1);
            tbSIDC_10.Text = s11.Substring(1, 1);
        }


    }

}
