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
            tbSIDC_5.Text = "U";  //SIDC 5: Unit
            tbSIDC_6.Text = "-";
            tbSIDC_7.Text = "-";
            tbSIDC_8.Text = "-";
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";
        }

        //SIDC 6






    }
}
