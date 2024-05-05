/* 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
        MilitarySymbol currentSymbol = new MilitarySymbol();
        SymbolLookup symbolLookup = new SymbolLookup();

        String S_T4 = "";

        public FormPicker()
        {
            InitializeComponent();
        }

        private void FormPicker_Load(object sender, EventArgs e)
        {
            symbolLookup.Initialize();

            if (!symbolLookup.Initialized)
                MessageBox.Show(@"Symbol Search will not work: Could not initialize the Symbol Lookup (Do Data\*.csv files exist? Are they locked/open anywhere else?)");

            CheckSettings();

            currentSymbol.Id.Affiliation = StandardIdentityAffiliationType.NotSet;
            currentSymbol.Id.SymbolSet = SymbolSetType.NotSet;

            string id2Try = tb_SIDC.Text.Trim();
            drawSymbol(id2Try);
        }


        private void CheckSettings()
        {
            // Set SVG Images Home if set in App Settings
            string appSettingsSvgHomeKey = "SVGImagesHome";
            var svgHomeFolderSetting = System.Configuration.ConfigurationManager.AppSettings[appSettingsSvgHomeKey];
            if (!string.IsNullOrWhiteSpace(svgHomeFolderSetting))
            {
                if (!Utilities.SetImageFilesHome(svgHomeFolderSetting))
                {
                    Console.WriteLine("App.config setting for SVGImagesHome does not exist, export failed!");
                    Console.WriteLine("Setting: " + svgHomeFolderSetting);
                    return;
                }
            }
            if (!Utilities.CheckImageFilesHomeExists())
                MessageBox.Show("Images will not work: could not find folder: " + MilitarySymbolToGraphicLayersMaker.ImageFilesHome);

            string appSettingsShowCenterPoint = "ShowCenterPoint";
            bool showCenterPointSetting = Convert.ToBoolean(
                System.Configuration.ConfigurationManager.AppSettings[appSettingsShowCenterPoint]);
            if (showCenterPointSetting)
            {
                MilitarySymbolToGraphicLayersMaker.AddReferenceCenterPoint = true;
            }
        }

        void resetSymbolState()
        {
            StandardIdentityAffiliationType affil = currentSymbol.Id.Affiliation;
            currentSymbol.Id = SymbolIdCode.DefaultSymbolIdCode;
            currentSymbol.Id.Affiliation = affil;
            currentSymbol.GraphicLayers.Clear();

            // blank image
            pbSymbolImage2.Image = null;
            // or set to "No Image" graphic:
            // Bitmap noImage = new Bitmap(GetType(), "NoImage.png");
        }


        private void updatePictureBox()
        {
            if (!currentSymbol.Id.IsValid)
                return;

            MilitarySymbolToGraphicLayersMaker.SetMilitarySymbolGraphicLayers(ref currentSymbol);

            if (currentSymbol.GraphicLayers.Count == 0)
            {
                System.Diagnostics.Trace.WriteLine("WARNING: No Graphic Layers to Draw");
                return;
            }
            tb_Debug.AppendText("Layers:" + currentSymbol.GraphicLayers.Count.ToString()+"\r\n");

            SvgSymbol.ImageSize = new Size(pbSymbolImage2.Width, pbSymbolImage2.Height);

            tb_Debug.AppendText(pbSymbolImage2.Width.ToString() + " / " + pbSymbolImage2.Height.ToString()+"\r\n");

            pbSymbolImage2.Image = SvgSymbol.GetBitmap(currentSymbol.GraphicLayers);


            // Set the Combo Box with the layers
            int layerNumber = 0;
            foreach (string graphicLayer in currentSymbol.GraphicLayers)
            {
                tb_Debug.AppendText(graphicLayer+"\r\n");
                layerNumber++;
                string simpleLayer = layerNumber.ToString() + ":" + 
                    graphicLayer.Replace(MilitarySymbolToGraphicLayersMaker.ImageFilesHome, " ");

                if (!System.IO.File.Exists(graphicLayer))
                    simpleLayer = "[MISSING]:" + simpleLayer;

            }
        }

        private void BuildSVG()
        {
            if (!currentSymbol.Id.IsValid) return;

            tb_SVG.Clear();
            foreach (string graphicLayer in currentSymbol.GraphicLayers)
            {
                if (!System.IO.File.Exists(graphicLayer))
                {
                    tb_SVG.AppendText("File not found\r\n");
                    continue;
                }
                parseSVG(graphicLayer);
            }
        }


        private void parseSVG(string fName)
        {
            tb_SVG.AppendText(System.AppDomain.CurrentDomain.BaseDirectory+"\r\n");
            if (!System.IO.File.Exists(fName))
            {
                tb_SVG.AppendText("File not found\r\n");
                return;
            }

            tb_SVG.AppendText("File EXISTS\r\n");

            XElement allData = XElement.Load(fName);

            if (allData != null)
            {
                IEnumerable<XElement> authors = allData.Descendants("g");
                foreach (XElement author in authors)
                    tb_SVG.AppendText((string)author);
            }
        }


        private void setTagLabel()
        {
            StringBuilder tagBuilder = new StringBuilder();

            foreach (string tag in this.currentSymbol.Tags)
            {
                tagBuilder.Append(tag.Replace('_', ' '));
                tagBuilder.Append("\r\n");
            }

            // Add the unformatted code to the end in case needed
            tagBuilder.Append(currentSymbol.Id.Code);

            this.tbTags.Text = tagBuilder.ToString();
        }

   
        private void pbSymbolImage_Click(object sender, EventArgs e)
        {
            if (this.pbSymbolImage2.Image == null) return;

            // Easter Egg : save image file on click
            SaveFileDialog saveImageFile = new SaveFileDialog();

            string basePath = "";
            if (tb_CurDir.Text == "")
            {
                basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            }
            else basePath = tb_CurDir.Text;

            saveImageFile.InitialDirectory = basePath;

            string imageFileName = tb_SIDC.Text.Trim() + ".wmf";
            saveImageFile.FileName = imageFileName;
            saveImageFile.Filter = "Graphics  files (*.png)|*.png|All files (*.*)|*.*";

            if (saveImageFile.ShowDialog() == DialogResult.OK)
            {
                Image saveImage = this.pbSymbolImage2.Image;
                saveImage.Save(saveImageFile.FileName, System.Drawing.Imaging.ImageFormat.Wmf);

                // Determine the full path of the file just saved.
                FileInfo fi = new FileInfo(saveImageFile.FileName);
                DirectoryInfo di = fi.Directory;
                tb_CurDir.Text = di.ToString();
            }
        }
   
        private ToolTip pbPreviewToolTip = new ToolTip();

        private void pbPreview_MouseHover(object sender, EventArgs e)
        {
            Point p = pbSymbolImage2.Location;

            pbPreviewToolTip.Show(                                
                "Click Image to Save",
                this,
                p.X + 50,
                p.Y + 50,
                2000);
        }

   
        private void bnDraw_Click(object sender, EventArgs e)
        {
            string id2Try = tb_SIDC.Text.Trim();
            drawSymbol(id2Try);
        }


        private void drawSymbol(string SIDC_2Try)
        {
            SymbolIdCode tryCode = null;

            if ((SIDC_2Try.Length == 15) || (SIDC_2Try.Length == 10))
            {
                // if 2525C Code length, try to convert it to 2525D first
                bool convertSuccess = Utilities.ConvertCodeCharlieToDelta(SIDC_2Try, out tryCode);

                if (!convertSuccess)
                {
                    tb_Invalid.BackColor = Color.Red;
                    tb_Invalid.Text = "Could not create symbol from SIDC:" + SIDC_2Try;
                }
            }
            else
            {
                // 2525D
                tryCode = new SymbolIdCode(SIDC_2Try);
            }

            if (tryCode.IsValid)
            {
                this.currentSymbol.Id = tryCode;
                tb_Invalid.BackColor = Color.White;
                tb_Invalid.Text = "";
            }
            else
            {
                tb_Invalid.BackColor = Color.Red;
                tb_Invalid.Text = "Could not create symbol from SIDC:" + SIDC_2Try;
            }

            setSymbolState();
        }




        void setSymbolState(string valueSelected = "")
        {
            string symbolSetName = currentSymbol.Id.SymbolSet.ToString().Replace("_", " ");
            setTagLabel();
            updatePictureBox();
        }

        private void bnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_SIDC_TextChanged(object sender, EventArgs e)
        {
            string id2Try = tb_SIDC.Text.Trim();

            if (id2Try.Length==10) drawSymbol(id2Try);
            if (id2Try.Length == 15)
            {
                drawSymbol(id2Try);
                fillReadBoxes(id2Try);
            }
            if (id2Try.Length == 8) drawSymbol(id2Try);
            if (id2Try.Length == 20) drawSymbol(id2Try);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_SIDC.Text = comboBox1.Text;
        }


        private void fillReadBoxes(string str)
        {
            int i = 0;
            if (str.Length != 15) return;
            tbSIDC_1.Text = str[i++]+"";
            tbSIDC_2.Text = str[i++] + "";
            tbSIDC_3.Text = str[i++] + "";
            tbSIDC_4.Text = str[i++] + "";
            tbSIDC_5.Text = str[i++] + "";
            tbSIDC_6.Text = str[i++] + "";
            tbSIDC_7.Text = str[i++] + "";
            tbSIDC_8.Text = str[i++] + "";
            tbSIDC_9.Text = str[i++] + "";
            tbSIDC_10.Text = str[i++] + "";
            tbSIDC_11.Text = str[i++] + "";
            tbSIDC_12.Text = str[i++] + "";
            tbSIDC_13.Text = str[i++] + "";
            tbSIDC_14.Text = str[i++] + "";
            tbSIDC_15.Text = str[i++] + "";
        }

        private void readBoxes()
        {
            S_T4 = "";
            S_T4 = S_T4 + tbSIDC_1.Text;
            S_T4 = S_T4 + tbSIDC_2.Text;
            S_T4 = S_T4 + tbSIDC_3.Text;
            S_T4 = S_T4 + tbSIDC_4.Text;
            S_T4 = S_T4 + tbSIDC_5.Text;
            S_T4 = S_T4 + tbSIDC_6.Text;
            S_T4 = S_T4 + tbSIDC_7.Text;
            S_T4 = S_T4 + tbSIDC_8.Text;
            S_T4 = S_T4 + tbSIDC_9.Text;
            S_T4 = S_T4 + tbSIDC_10.Text;
            S_T4 = S_T4 + tbSIDC_11.Text;
            S_T4 = S_T4 + tbSIDC_12.Text;
            S_T4 = S_T4 + tbSIDC_13.Text;
            S_T4 = S_T4 + tbSIDC_14.Text;
            S_T4 = S_T4 + tbSIDC_15.Text;
            tb_DebugTab4.Text = S_T4;
            tb_SIDC.Clear();
            tb_SIDC.Text = S_T4.Trim();

            drawSymbol(S_T4);
        }


        private void tbSIDC_TextChanged(object sender, EventArgs e)
        {
            readBoxes();
        }

        private void bn_SVG_Click(object sender, EventArgs e)
        {
            BuildSVG();

            parseSVG(@"0_330_0tweaked.xml");
            //parseSVG("SIDC.xml");
        }












        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_6.Text = listBox2.Text;
        }




        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_9.Text = listBox5.Text;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_10.Text = listBox6.Text;
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_11.Text = listBox7.Text;
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSIDC_12.Text = listBox8.Text;
        }

        private void lb_SIDC8_U_SelectedIndexChanged(object sender, EventArgs e)
        {
            // user has selected U67X-- 
            tbSIDC_8.Text = lb_SIDC8_U.Text;
            tbSIDC_9.Text = "-";
            tbSIDC_10.Text = "-";

            if (tbSIDC_6.Text == "C")  //UC
            {
                SetUpSIDC9and10ForUC();
            }
            else if (tbSIDC_6.Text == "U")  //UU
            {
                //SetUpSIDC9and10ForUU();
            }
            else if (tbSIDC_6.Text == "S")  //US
            {
                //SetUpSIDC9and10ForUS();
            }
            else if (tbSIDC_6.Text == "U")  //UH
            {
                //No options for SIDC 9, 10
            }



        }


        private void SetUpSIDC9and10ForUC()  //handles UCC  EWX, other EW do not use SIDC 9 or 10       
        {
            LB_SIDC_E_9and10.Items.Clear();
            //UCD
            if (tbSIDC_7.Text == "D")  //UCD
            {
                if (tbSIDC_8.Text == "S")  //UCDS
                {
                    String[] W_List = new String[] { "--", "C-", "S-", "V-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "M")  //UCDM
                {
                    String[] W_List = new String[] { "--", "L-", "LA", "M-", "H-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "H")  //UCDH
                {
                    String[] W_List = new String[] { "--", "H-", "P-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }

            //UCA
            else if (tbSIDC_7.Text == "A")  //UCA
            {
                if (tbSIDC_8.Text == "T")  //UCAT
                {
                    String[] W_List = new String[] { "--", "A-", "W-", "WR", "L-", "M-", "H-", "R-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "W")  //UCAW
                {
                    String[] W_List = new String[] { "--", "S-", "A-", "W-", "WR", "L-", "M-", "H-", "R-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "A")  //UCAA
                {
                    String[] W_List = new String[] { "--", "D-", "L-", "M-", "S-", "U-", "C-", "A-", "AT", "AW", "AS", "0-", "OS" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }
            else if (tbSIDC_7.Text == "V")  //UCV
            {
                if (tbSIDC_8.Text == "F")  //UCVF
                {
                    String[] W_List = new String[] { "--", "U-", "A-", "R-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "R")  //UCVR
                {
                    String[] W_List = new String[] { "--", "A-", "S-", "W-", "U-", "UL", "UM", "UH", "UC", "UE", "M-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "U")  //UCVU
                {
                    String[] W_List = new String[] { "--", "F-", "R-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }
            //else if (tbSIDC_7.Text == "I")  //UCI
            else if (tbSIDC_7.Text == "E")  //UCE
            {
                if (tbSIDC_8.Text == "C")  //UCEC
                {
                    String[] W_List = new String[] { "--", "S-", "A-", "C-", "L-", "M-", "H-", "T-", "W-", "O-", "R-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "N")  //UCEN
                {
                    String[] W_List = new String[] { "--", "N-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }
            else if (tbSIDC_7.Text == "F")  //UCF
            {
                if (tbSIDC_8.Text == "H")  //UCFH
                {
                    String[] W_List = new String[] { "--", "E-", "S-", "A-", "C-", "O-", "L-", "M-", "H-", "X-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "R")  //UCFR
                {
                    String[] W_List = new String[] { "--", "S-", "SS", "SR", "ST", "M-", "MS", "MR", "MT" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "T")  //UCFT
                {
                    String[] W_List = new String[] { "--", "R-", "S-", "F-", "C-", "CD", "CM", "A-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "M")  //UCFM
                {
                    String[] W_List = new String[] { "--", "S-", "W-", "T-", "TA", "TS", "TC", "TO", "L-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "S")  //UCFS
                {
                    String[] W_List = new String[] { "--", "S-", "A-", "L-", "O-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "O")  //UCFO
                {
                    String[] W_List = new String[] { "--", "S-", "A-", "L-", "O-" };
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }
            else if (tbSIDC_7.Text == "R")  //UCR
            {
                if (tbSIDC_8.Text == "V")  //UCRV
                {
                    String[] W_List = new String[] { "--", "A-", "M-", "G-", "O-"};
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
                else if (tbSIDC_8.Text == "R")  //UCRR
                {
                    String[] W_List = new String[] { "--", "D-", "F-", "L-"};
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }

            else if (tbSIDC_7.Text == "S")  //UCS
            {
                if (tbSIDC_8.Text == "G")  //UCSG
                {
                    String[] W_List = new String[] { "--", "D-", "M-", "A-"};
                    foreach (String s in W_List) LB_SIDC_U_9and10.Items.Add(s);
                }
            }



        }

        private void LB_SIDC_U_9and10_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s11 = LB_SIDC_U_9and10.Text;
            tbSIDC_9.Text = s11.Substring(0, 1);
            tbSIDC_10.Text = s11.Substring(1, 1);
        }

        private void DetermineHQTF()
        {
            if ((CB_TF.Checked == true) & (CB_HQ.Checked == true)) tbSIDC_11.Text = "B"; //Both
            else if ((CB_TF.Checked == true) & (CB_HQ.Checked == false)) tbSIDC_11.Text = "E";  //TF
            else if ((CB_TF.Checked == false) & (CB_HQ.Checked == true)) tbSIDC_11.Text = "A"; // HQ
            else tbSIDC_11.Text = "-";
        }

        private void DetermineUnitSize()
        {

        }


        private void CB_HQ_CheckedChanged(object sender, EventArgs e)
        {
            DetermineHQTF();
        }

        private void CB_TF_CheckedChanged(object sender, EventArgs e)
        {
            DetermineHQTF();
        }

        private void RB_UnitSize_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Team.Checked) tbSIDC_12.Text = "A";
            if (RB_Squad.Checked) tbSIDC_12.Text = "B";
            if (RB_Section.Checked) tbSIDC_12.Text = "C";
            if (RB_Platoon.Checked) tbSIDC_12.Text = "D";
            if (RB_Reg.Checked) tbSIDC_12.Text = "G";
            if (RB_Coy.Checked) tbSIDC_12.Text = "E";
            if (RB_BN.Checked) tbSIDC_12.Text = "F";
            if (RB_Bde.Checked) tbSIDC_12.Text = "H";
            if (RB_Div.Checked) tbSIDC_12.Text = "I";
        }
    }
}
