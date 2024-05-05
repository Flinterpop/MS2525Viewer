namespace MilSymbolPicker
{
    partial class FormPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPicker));
            this.pbSymbolImage2 = new System.Windows.Forms.PictureBox();
            this.bn_Draw = new System.Windows.Forms.Button();
            this.tb_SIDC = new System.Windows.Forms.TextBox();
            this.bn_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tree = new System.Windows.Forms.TabPage();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tb_DebugTab4 = new System.Windows.Forms.TextBox();
            this.SIDC = new System.Windows.Forms.GroupBox();
            this.tbSIDC_15 = new System.Windows.Forms.TextBox();
            this.tbSIDC_14 = new System.Windows.Forms.TextBox();
            this.tbSIDC_13 = new System.Windows.Forms.TextBox();
            this.tbSIDC_12 = new System.Windows.Forms.TextBox();
            this.tbSIDC_11 = new System.Windows.Forms.TextBox();
            this.tbSIDC_10 = new System.Windows.Forms.TextBox();
            this.tbSIDC_9 = new System.Windows.Forms.TextBox();
            this.tbSIDC_8 = new System.Windows.Forms.TextBox();
            this.tbSIDC_7 = new System.Windows.Forms.TextBox();
            this.tbSIDC_6 = new System.Windows.Forms.TextBox();
            this.tbSIDC_5 = new System.Windows.Forms.TextBox();
            this.tbSIDC_4 = new System.Windows.Forms.TextBox();
            this.tbSIDC_3 = new System.Windows.Forms.TextBox();
            this.tbSIDC_2 = new System.Windows.Forms.TextBox();
            this.tbSIDC_1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbNN = new System.Windows.Forms.RadioButton();
            this.rbMO = new System.Windows.Forms.RadioButton();
            this.rbMP = new System.Windows.Forms.RadioButton();
            this.rbMQ = new System.Windows.Forms.RadioButton();
            this.rb4P = new System.Windows.Forms.RadioButton();
            this.rb4C = new System.Windows.Forms.RadioButton();
            this.rb7Null = new System.Windows.Forms.RadioButton();
            this.rb7A = new System.Windows.Forms.RadioButton();
            this.rb7E = new System.Windows.Forms.RadioButton();
            this.rb7U = new System.Windows.Forms.RadioButton();
            this.rb9Null = new System.Windows.Forms.RadioButton();
            this.rb9L = new System.Windows.Forms.RadioButton();
            this.rb9H = new System.Windows.Forms.RadioButton();
            this.rb8Null = new System.Windows.Forms.RadioButton();
            this.rb8L = new System.Windows.Forms.RadioButton();
            this.rb8T = new System.Windows.Forms.RadioButton();
            this.tb_Invalid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CurDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Debug = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bn_SVG = new System.Windows.Forms.Button();
            this.tb_SVG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSymbolImage2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tree.SuspendLayout();
            this.SIDC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSymbolImage2
            // 
            this.pbSymbolImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSymbolImage2.Location = new System.Drawing.Point(452, 334);
            this.pbSymbolImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbSymbolImage2.Name = "pbSymbolImage2";
            this.pbSymbolImage2.Size = new System.Drawing.Size(299, 307);
            this.pbSymbolImage2.TabIndex = 13;
            this.pbSymbolImage2.TabStop = false;
            this.pbSymbolImage2.Click += new System.EventHandler(this.pbSymbolImage_Click);
            this.pbSymbolImage2.MouseHover += new System.EventHandler(this.pbPreview_MouseHover);
            // 
            // bn_Draw
            // 
            this.bn_Draw.Location = new System.Drawing.Point(345, 54);
            this.bn_Draw.Name = "bn_Draw";
            this.bn_Draw.Size = new System.Drawing.Size(94, 40);
            this.bn_Draw.TabIndex = 30;
            this.bn_Draw.Text = "Draw";
            this.bn_Draw.UseVisualStyleBackColor = true;
            this.bn_Draw.Click += new System.EventHandler(this.bnDraw_Click);
            // 
            // tb_SIDC
            // 
            this.tb_SIDC.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SIDC.Location = new System.Drawing.Point(16, 54);
            this.tb_SIDC.Name = "tb_SIDC";
            this.tb_SIDC.Size = new System.Drawing.Size(318, 35);
            this.tb_SIDC.TabIndex = 31;
            this.tb_SIDC.Text = "SFGPEVAL--MPCAG";
            this.tb_SIDC.TextChanged += new System.EventHandler(this.tb_SIDC_TextChanged);
            // 
            // bn_Quit
            // 
            this.bn_Quit.Location = new System.Drawing.Point(446, 54);
            this.bn_Quit.Name = "bn_Quit";
            this.bn_Quit.Size = new System.Drawing.Size(93, 40);
            this.bn_Quit.TabIndex = 33;
            this.bn_Quit.Text = "Quit";
            this.bn_Quit.UseVisualStyleBackColor = true;
            this.bn_Quit.Click += new System.EventHandler(this.bnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manually Set Code (8 | 20 Chars=2525D or 10 | 15=2525C)";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SFGPEVAL--MPCAG",
            "SFGPEWR-----CAG",
            "SFGPEV------CAG",
            "SFGPEVUL--MOCAG",
            "SFGPEVAL--MOCAG",
            "SFGPEVATH-MQCAG",
            "SFGPUCI---BHCAG",
            "SFGPUCF---AFCAG",
            "SFGPUCF---AECAG",
            "SFGPUCF----ECAG",
            "SFGPUCF----DCAG",
            "SFGPUCA----FCAG",
            "SFGPUCA---AECAG",
            "SFGPUCA----DCAG",
            "SFGPUCE----FCAG",
            "SFGPUCE---AECAG",
            "SFGPUCIZ---FCAG",
            "SFGPUCIZ---ECAG",
            "SFGPUCIZ---FCAG",
            "SFGPUCIZ---ECAG",
            "SFGPUCSS---FCAG",
            "SFGPUCSS---ECAG",
            "SFGPEVAL--MPCAG"});
            this.comboBox1.Location = new System.Drawing.Point(16, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 30);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Examples";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Click on Symbol to save";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tree);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(28, 197);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 681);
            this.tabControl1.TabIndex = 44;
            // 
            // Tree
            // 
            this.Tree.Controls.Add(this.listBox9);
            this.Tree.Controls.Add(this.listBox8);
            this.Tree.Controls.Add(this.listBox7);
            this.Tree.Controls.Add(this.listBox6);
            this.Tree.Controls.Add(this.listBox5);
            this.Tree.Controls.Add(this.listBox4);
            this.Tree.Controls.Add(this.listBox3);
            this.Tree.Controls.Add(this.listBox2);
            this.Tree.Controls.Add(this.listBox1);
            this.Tree.Controls.Add(this.tbTags);
            this.Tree.Controls.Add(this.label3);
            this.Tree.Controls.Add(this.tb_DebugTab4);
            this.Tree.Controls.Add(this.SIDC);
            this.Tree.Controls.Add(this.pbSymbolImage2);
            this.Tree.Location = new System.Drawing.Point(4, 29);
            this.Tree.Name = "Tree";
            this.Tree.Padding = new System.Windows.Forms.Padding(3);
            this.Tree.Size = new System.Drawing.Size(938, 648);
            this.Tree.TabIndex = 4;
            this.Tree.Text = "Detailed";
            this.Tree.UseVisualStyleBackColor = true;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 20;
            this.listBox9.Items.AddRange(new object[] {
            "--",
            "MO",
            "MP",
            "MQ",
            "MR",
            "MS",
            "MT",
            "MU",
            "MV",
            "MW",
            "MX",
            "MY",
            "NS",
            "NL",
            "--"});
            this.listBox9.Location = new System.Drawing.Point(763, 24);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(137, 144);
            this.listBox9.TabIndex = 56;
            this.listBox9.SelectedIndexChanged += new System.EventHandler(this.listBox9_SelectedIndexChanged);
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 20;
            this.listBox8.Items.AddRange(new object[] {
            "-",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "-",
            "M",
            "H"});
            this.listBox8.Location = new System.Drawing.Point(636, 25);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(67, 144);
            this.listBox8.TabIndex = 55;
            this.listBox8.SelectedIndexChanged += new System.EventHandler(this.listBox8_SelectedIndexChanged);
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 20;
            this.listBox7.Items.AddRange(new object[] {
            "-",
            "A",
            "B",
            "E",
            "-",
            "M",
            "T",
            "P"});
            this.listBox7.Location = new System.Drawing.Point(563, 25);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(67, 144);
            this.listBox7.TabIndex = 54;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 20;
            this.listBox6.Items.AddRange(new object[] {
            "M",
            "-"});
            this.listBox6.Location = new System.Drawing.Point(452, 25);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(67, 144);
            this.listBox6.TabIndex = 53;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Items.AddRange(new object[] {
            "M",
            "H",
            "-"});
            this.listBox5.Location = new System.Drawing.Point(370, 25);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(67, 144);
            this.listBox5.TabIndex = 52;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Items.AddRange(new object[] {
            "S",
            "M",
            "H",
            "G",
            "C",
            "T",
            "O",
            "W",
            "F",
            "R",
            "V",
            "U",
            "L",
            "Z",
            "N",
            "I",
            "X",
            "U",
            "-",
            "L",
            "T",
            "-"});
            this.listBox4.Location = new System.Drawing.Point(297, 25);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(67, 144);
            this.listBox4.TabIndex = 51;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "-",
            "D",
            "A",
            "V",
            "I",
            "E",
            "F",
            "R",
            "M",
            "S",
            "-",
            "A",
            "E",
            "U"});
            this.listBox3.Location = new System.Drawing.Point(224, 25);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(67, 144);
            this.listBox3.TabIndex = 50;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "C",
            "-",
            "W",
            "S",
            "X",
            "R",
            "-"});
            this.listBox2.Location = new System.Drawing.Point(151, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(67, 144);
            this.listBox2.TabIndex = 49;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "U",
            "E"});
            this.listBox1.Location = new System.Drawing.Point(78, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(67, 144);
            this.listBox1.TabIndex = 47;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(20, 334);
            this.tbTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTags.Size = new System.Drawing.Size(403, 306);
            this.tbTags.TabIndex = 45;
            this.tbTags.Text = "Selected Symbol PropertiesSelected Symbol Properties";
            // 
            // tb_DebugTab4
            // 
            this.tb_DebugTab4.Location = new System.Drawing.Point(8, 269);
            this.tb_DebugTab4.Name = "tb_DebugTab4";
            this.tb_DebugTab4.Size = new System.Drawing.Size(415, 26);
            this.tb_DebugTab4.TabIndex = 17;
            // 
            // SIDC
            // 
            this.SIDC.Controls.Add(this.tbSIDC_15);
            this.SIDC.Controls.Add(this.tbSIDC_14);
            this.SIDC.Controls.Add(this.tbSIDC_13);
            this.SIDC.Controls.Add(this.tbSIDC_12);
            this.SIDC.Controls.Add(this.tbSIDC_11);
            this.SIDC.Controls.Add(this.tbSIDC_10);
            this.SIDC.Controls.Add(this.tbSIDC_9);
            this.SIDC.Controls.Add(this.tbSIDC_8);
            this.SIDC.Controls.Add(this.tbSIDC_7);
            this.SIDC.Controls.Add(this.tbSIDC_6);
            this.SIDC.Controls.Add(this.tbSIDC_5);
            this.SIDC.Controls.Add(this.tbSIDC_4);
            this.SIDC.Controls.Add(this.tbSIDC_3);
            this.SIDC.Controls.Add(this.tbSIDC_2);
            this.SIDC.Controls.Add(this.tbSIDC_1);
            this.SIDC.Location = new System.Drawing.Point(8, 174);
            this.SIDC.Name = "SIDC";
            this.SIDC.Size = new System.Drawing.Size(792, 89);
            this.SIDC.TabIndex = 16;
            this.SIDC.TabStop = false;
            this.SIDC.Text = "SIDC";
            // 
            // tbSIDC_15
            // 
            this.tbSIDC_15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_15.Location = new System.Drawing.Point(740, 35);
            this.tbSIDC_15.MaxLength = 1;
            this.tbSIDC_15.Name = "tbSIDC_15";
            this.tbSIDC_15.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_15.TabIndex = 15;
            this.tbSIDC_15.Text = "G";
            this.tbSIDC_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_15.TextChanged += new System.EventHandler(this.tbSIDC_15_TextChanged);
            // 
            // tbSIDC_14
            // 
            this.tbSIDC_14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_14.Location = new System.Drawing.Point(713, 35);
            this.tbSIDC_14.MaxLength = 1;
            this.tbSIDC_14.Name = "tbSIDC_14";
            this.tbSIDC_14.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_14.TabIndex = 14;
            this.tbSIDC_14.Text = "A";
            this.tbSIDC_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_14.TextChanged += new System.EventHandler(this.tbSIDC_14_TextChanged);
            // 
            // tbSIDC_13
            // 
            this.tbSIDC_13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_13.Location = new System.Drawing.Point(687, 35);
            this.tbSIDC_13.MaxLength = 1;
            this.tbSIDC_13.Name = "tbSIDC_13";
            this.tbSIDC_13.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_13.TabIndex = 13;
            this.tbSIDC_13.Text = "C";
            this.tbSIDC_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_13.TextChanged += new System.EventHandler(this.tbSIDC_13_TextChanged);
            // 
            // tbSIDC_12
            // 
            this.tbSIDC_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_12.Location = new System.Drawing.Point(620, 35);
            this.tbSIDC_12.MaxLength = 1;
            this.tbSIDC_12.Name = "tbSIDC_12";
            this.tbSIDC_12.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_12.TabIndex = 12;
            this.tbSIDC_12.Text = "P";
            this.tbSIDC_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_12.TextChanged += new System.EventHandler(this.tbSIDC_12_TextChanged);
            // 
            // tbSIDC_11
            // 
            this.tbSIDC_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_11.Location = new System.Drawing.Point(592, 35);
            this.tbSIDC_11.MaxLength = 1;
            this.tbSIDC_11.Name = "tbSIDC_11";
            this.tbSIDC_11.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_11.TabIndex = 11;
            this.tbSIDC_11.Text = "M";
            this.tbSIDC_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_11.TextChanged += new System.EventHandler(this.tbSIDC_11_TextChanged);
            // 
            // tbSIDC_10
            // 
            this.tbSIDC_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_10.Location = new System.Drawing.Point(335, 35);
            this.tbSIDC_10.MaxLength = 1;
            this.tbSIDC_10.Name = "tbSIDC_10";
            this.tbSIDC_10.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_10.TabIndex = 10;
            this.tbSIDC_10.Text = "-";
            this.tbSIDC_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_10.TextChanged += new System.EventHandler(this.tbSIDC_10_TextChanged);
            // 
            // tbSIDC_9
            // 
            this.tbSIDC_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_9.Location = new System.Drawing.Point(308, 35);
            this.tbSIDC_9.MaxLength = 1;
            this.tbSIDC_9.Name = "tbSIDC_9";
            this.tbSIDC_9.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_9.TabIndex = 9;
            this.tbSIDC_9.Text = "-";
            this.tbSIDC_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_9.TextChanged += new System.EventHandler(this.tbSIDC_9_TextChanged);
            // 
            // tbSIDC_8
            // 
            this.tbSIDC_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_8.Location = new System.Drawing.Point(281, 35);
            this.tbSIDC_8.MaxLength = 1;
            this.tbSIDC_8.Name = "tbSIDC_8";
            this.tbSIDC_8.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_8.TabIndex = 8;
            this.tbSIDC_8.Text = "L";
            this.tbSIDC_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_8.TextChanged += new System.EventHandler(this.tbSIDC_8_TextChanged);
            // 
            // tbSIDC_7
            // 
            this.tbSIDC_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_7.Location = new System.Drawing.Point(256, 35);
            this.tbSIDC_7.MaxLength = 1;
            this.tbSIDC_7.Name = "tbSIDC_7";
            this.tbSIDC_7.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_7.TabIndex = 7;
            this.tbSIDC_7.Text = "A";
            this.tbSIDC_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_7.TextChanged += new System.EventHandler(this.tbSIDC_7_TextChanged);
            // 
            // tbSIDC_6
            // 
            this.tbSIDC_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_6.Location = new System.Drawing.Point(228, 35);
            this.tbSIDC_6.MaxLength = 1;
            this.tbSIDC_6.Name = "tbSIDC_6";
            this.tbSIDC_6.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_6.TabIndex = 6;
            this.tbSIDC_6.Text = "V";
            this.tbSIDC_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_6.TextChanged += new System.EventHandler(this.tbSIDC_6_TextChanged);
            // 
            // tbSIDC_5
            // 
            this.tbSIDC_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_5.Location = new System.Drawing.Point(202, 35);
            this.tbSIDC_5.MaxLength = 1;
            this.tbSIDC_5.Name = "tbSIDC_5";
            this.tbSIDC_5.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_5.TabIndex = 5;
            this.tbSIDC_5.Text = "E";
            this.tbSIDC_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_5.TextChanged += new System.EventHandler(this.tbSIDC_5_TextChanged);
            // 
            // tbSIDC_4
            // 
            this.tbSIDC_4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_4.Location = new System.Drawing.Point(96, 35);
            this.tbSIDC_4.MaxLength = 1;
            this.tbSIDC_4.Name = "tbSIDC_4";
            this.tbSIDC_4.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_4.TabIndex = 4;
            this.tbSIDC_4.Text = "P";
            this.tbSIDC_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_4.TextChanged += new System.EventHandler(this.tbSIDC_4_TextChanged);
            // 
            // tbSIDC_3
            // 
            this.tbSIDC_3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_3.Location = new System.Drawing.Point(70, 35);
            this.tbSIDC_3.MaxLength = 1;
            this.tbSIDC_3.Name = "tbSIDC_3";
            this.tbSIDC_3.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_3.TabIndex = 2;
            this.tbSIDC_3.Text = "G";
            this.tbSIDC_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_3.TextChanged += new System.EventHandler(this.tbSIDC_3_TextChanged);
            // 
            // tbSIDC_2
            // 
            this.tbSIDC_2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_2.Location = new System.Drawing.Point(44, 35);
            this.tbSIDC_2.MaxLength = 1;
            this.tbSIDC_2.Name = "tbSIDC_2";
            this.tbSIDC_2.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_2.TabIndex = 1;
            this.tbSIDC_2.Text = "F";
            this.tbSIDC_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_2.TextChanged += new System.EventHandler(this.tbSIDC_2_TextChanged);
            // 
            // tbSIDC_1
            // 
            this.tbSIDC_1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbSIDC_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSIDC_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSIDC_1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSIDC_1.Location = new System.Drawing.Point(16, 35);
            this.tbSIDC_1.MaxLength = 1;
            this.tbSIDC_1.Name = "tbSIDC_1";
            this.tbSIDC_1.Size = new System.Drawing.Size(30, 35);
            this.tbSIDC_1.TabIndex = 0;
            this.tbSIDC_1.Text = "S";
            this.tbSIDC_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSIDC_1.TextChanged += new System.EventHandler(this.tbSIDC_1_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 648);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Help";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rbNN
            // 
            this.rbNN.AutoSize = true;
            this.rbNN.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNN.Location = new System.Drawing.Point(12, 33);
            this.rbNN.Margin = new System.Windows.Forms.Padding(6);
            this.rbNN.Name = "rbNN";
            this.rbNN.Size = new System.Drawing.Size(96, 47);
            this.rbNN.TabIndex = 12;
            this.rbNN.Text = "--";
            this.rbNN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbNN.UseVisualStyleBackColor = true;
            // 
            // rbMO
            // 
            this.rbMO.AutoSize = true;
            this.rbMO.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMO.Location = new System.Drawing.Point(12, 94);
            this.rbMO.Margin = new System.Windows.Forms.Padding(6);
            this.rbMO.Name = "rbMO";
            this.rbMO.Size = new System.Drawing.Size(96, 47);
            this.rbMO.TabIndex = 13;
            this.rbMO.Text = "MO";
            this.rbMO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMO.UseVisualStyleBackColor = true;
            // 
            // rbMP
            // 
            this.rbMP.AutoSize = true;
            this.rbMP.Checked = true;
            this.rbMP.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMP.Location = new System.Drawing.Point(12, 146);
            this.rbMP.Margin = new System.Windows.Forms.Padding(6);
            this.rbMP.Name = "rbMP";
            this.rbMP.Size = new System.Drawing.Size(96, 47);
            this.rbMP.TabIndex = 14;
            this.rbMP.TabStop = true;
            this.rbMP.Text = "MP";
            this.rbMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMP.UseVisualStyleBackColor = true;
            // 
            // rbMQ
            // 
            this.rbMQ.AutoSize = true;
            this.rbMQ.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMQ.Location = new System.Drawing.Point(12, 208);
            this.rbMQ.Margin = new System.Windows.Forms.Padding(6);
            this.rbMQ.Name = "rbMQ";
            this.rbMQ.Size = new System.Drawing.Size(96, 47);
            this.rbMQ.TabIndex = 15;
            this.rbMQ.Text = "MQ";
            this.rbMQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMQ.UseVisualStyleBackColor = true;
            // 
            // rb4P
            // 
            this.rb4P.AutoSize = true;
            this.rb4P.Checked = true;
            this.rb4P.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4P.Location = new System.Drawing.Point(34, 33);
            this.rb4P.Margin = new System.Windows.Forms.Padding(6);
            this.rb4P.Name = "rb4P";
            this.rb4P.Size = new System.Drawing.Size(73, 47);
            this.rb4P.TabIndex = 12;
            this.rb4P.TabStop = true;
            this.rb4P.Text = "P";
            this.rb4P.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb4P.UseVisualStyleBackColor = true;
            // 
            // rb4C
            // 
            this.rb4C.AutoSize = true;
            this.rb4C.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4C.Location = new System.Drawing.Point(34, 94);
            this.rb4C.Margin = new System.Windows.Forms.Padding(6);
            this.rb4C.Name = "rb4C";
            this.rb4C.Size = new System.Drawing.Size(73, 47);
            this.rb4C.TabIndex = 13;
            this.rb4C.Text = "C";
            this.rb4C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb4C.UseVisualStyleBackColor = true;
            // 
            // rb7Null
            // 
            this.rb7Null.AutoSize = true;
            this.rb7Null.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7Null.Location = new System.Drawing.Point(34, 33);
            this.rb7Null.Margin = new System.Windows.Forms.Padding(6);
            this.rb7Null.Name = "rb7Null";
            this.rb7Null.Size = new System.Drawing.Size(73, 47);
            this.rb7Null.TabIndex = 12;
            this.rb7Null.Text = "-";
            this.rb7Null.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb7Null.UseVisualStyleBackColor = true;
            // 
            // rb7A
            // 
            this.rb7A.AutoSize = true;
            this.rb7A.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7A.Location = new System.Drawing.Point(34, 85);
            this.rb7A.Margin = new System.Windows.Forms.Padding(6);
            this.rb7A.Name = "rb7A";
            this.rb7A.Size = new System.Drawing.Size(73, 47);
            this.rb7A.TabIndex = 13;
            this.rb7A.Text = "A";
            this.rb7A.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb7A.UseVisualStyleBackColor = true;
            // 
            // rb7E
            // 
            this.rb7E.AutoSize = true;
            this.rb7E.Checked = true;
            this.rb7E.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7E.Location = new System.Drawing.Point(34, 146);
            this.rb7E.Margin = new System.Windows.Forms.Padding(6);
            this.rb7E.Name = "rb7E";
            this.rb7E.Size = new System.Drawing.Size(73, 47);
            this.rb7E.TabIndex = 14;
            this.rb7E.TabStop = true;
            this.rb7E.Text = "E";
            this.rb7E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb7E.UseVisualStyleBackColor = true;
            // 
            // rb7U
            // 
            this.rb7U.AutoSize = true;
            this.rb7U.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7U.Location = new System.Drawing.Point(34, 208);
            this.rb7U.Margin = new System.Windows.Forms.Padding(6);
            this.rb7U.Name = "rb7U";
            this.rb7U.Size = new System.Drawing.Size(73, 47);
            this.rb7U.TabIndex = 15;
            this.rb7U.Text = "U";
            this.rb7U.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb7U.UseVisualStyleBackColor = true;
            // 
            // rb9Null
            // 
            this.rb9Null.AutoSize = true;
            this.rb9Null.Checked = true;
            this.rb9Null.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9Null.Location = new System.Drawing.Point(34, 33);
            this.rb9Null.Margin = new System.Windows.Forms.Padding(6);
            this.rb9Null.Name = "rb9Null";
            this.rb9Null.Size = new System.Drawing.Size(73, 47);
            this.rb9Null.TabIndex = 12;
            this.rb9Null.TabStop = true;
            this.rb9Null.Text = "-";
            this.rb9Null.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb9Null.UseVisualStyleBackColor = true;
            // 
            // rb9L
            // 
            this.rb9L.AutoSize = true;
            this.rb9L.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9L.Location = new System.Drawing.Point(34, 85);
            this.rb9L.Margin = new System.Windows.Forms.Padding(6);
            this.rb9L.Name = "rb9L";
            this.rb9L.Size = new System.Drawing.Size(73, 47);
            this.rb9L.TabIndex = 13;
            this.rb9L.Text = "L";
            this.rb9L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb9L.UseVisualStyleBackColor = true;
            // 
            // rb9H
            // 
            this.rb9H.AutoSize = true;
            this.rb9H.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9H.Location = new System.Drawing.Point(34, 146);
            this.rb9H.Margin = new System.Windows.Forms.Padding(6);
            this.rb9H.Name = "rb9H";
            this.rb9H.Size = new System.Drawing.Size(73, 47);
            this.rb9H.TabIndex = 14;
            this.rb9H.Text = "H";
            this.rb9H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb9H.UseVisualStyleBackColor = true;
            // 
            // rb8Null
            // 
            this.rb8Null.AutoSize = true;
            this.rb8Null.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8Null.Location = new System.Drawing.Point(30, 37);
            this.rb8Null.Margin = new System.Windows.Forms.Padding(6);
            this.rb8Null.Name = "rb8Null";
            this.rb8Null.Size = new System.Drawing.Size(73, 47);
            this.rb8Null.TabIndex = 16;
            this.rb8Null.Text = "-";
            this.rb8Null.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb8Null.UseVisualStyleBackColor = true;
            // 
            // rb8L
            // 
            this.rb8L.AutoSize = true;
            this.rb8L.Checked = true;
            this.rb8L.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8L.Location = new System.Drawing.Point(28, 90);
            this.rb8L.Margin = new System.Windows.Forms.Padding(6);
            this.rb8L.Name = "rb8L";
            this.rb8L.Size = new System.Drawing.Size(73, 47);
            this.rb8L.TabIndex = 17;
            this.rb8L.TabStop = true;
            this.rb8L.Text = "L";
            this.rb8L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb8L.UseVisualStyleBackColor = true;
            // 
            // rb8T
            // 
            this.rb8T.AutoSize = true;
            this.rb8T.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8T.Location = new System.Drawing.Point(30, 150);
            this.rb8T.Margin = new System.Windows.Forms.Padding(6);
            this.rb8T.Name = "rb8T";
            this.rb8T.Size = new System.Drawing.Size(73, 47);
            this.rb8T.TabIndex = 18;
            this.rb8T.Text = "T";
            this.rb8T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb8T.UseVisualStyleBackColor = true;
            // 
            // tb_Invalid
            // 
            this.tb_Invalid.Location = new System.Drawing.Point(345, 132);
            this.tb_Invalid.Name = "tb_Invalid";
            this.tb_Invalid.Size = new System.Drawing.Size(259, 26);
            this.tb_Invalid.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Issues:";
            // 
            // tb_CurDir
            // 
            this.tb_CurDir.Location = new System.Drawing.Point(984, 803);
            this.tb_CurDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_CurDir.Name = "tb_CurDir";
            this.tb_CurDir.Size = new System.Drawing.Size(634, 26);
            this.tb_CurDir.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 778);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Last Saved Directory";
            // 
            // tb_Debug
            // 
            this.tb_Debug.Location = new System.Drawing.Point(628, 54);
            this.tb_Debug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Debug.Multiline = true;
            this.tb_Debug.Name = "tb_Debug";
            this.tb_Debug.Size = new System.Drawing.Size(990, 167);
            this.tb_Debug.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Layers (SVG)";
            // 
            // bn_SVG
            // 
            this.bn_SVG.Location = new System.Drawing.Point(984, 232);
            this.bn_SVG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bn_SVG.Name = "bn_SVG";
            this.bn_SVG.Size = new System.Drawing.Size(112, 35);
            this.bn_SVG.TabIndex = 52;
            this.bn_SVG.Text = "Build SVG";
            this.bn_SVG.UseVisualStyleBackColor = true;
            this.bn_SVG.Click += new System.EventHandler(this.bn_SVG_Click);
            // 
            // tb_SVG
            // 
            this.tb_SVG.Location = new System.Drawing.Point(984, 275);
            this.tb_SVG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_SVG.Multiline = true;
            this.tb_SVG.Name = "tb_SVG";
            this.tb_SVG.Size = new System.Drawing.Size(634, 486);
            this.tb_SVG.TabIndex = 53;
            // 
            // FormPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 892);
            this.Controls.Add(this.tb_SVG);
            this.Controls.Add(this.bn_SVG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Debug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_CurDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Invalid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn_Quit);
            this.Controls.Add(this.tb_SIDC);
            this.Controls.Add(this.bn_Draw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPicker";
            this.Text = "MIL-STD-2525B SIDC Viewer, 4 May 2024, B. Graham";
            this.Load += new System.EventHandler(this.FormPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSymbolImage2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tree.ResumeLayout(false);
            this.Tree.PerformLayout();
            this.SIDC.ResumeLayout(false);
            this.SIDC.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSymbolImage2;
        private System.Windows.Forms.Button bn_Draw;
        private System.Windows.Forms.TextBox tb_SIDC;
        private System.Windows.Forms.Button bn_Quit;
        //public System.Windows.Forms.CheckBox cbShowSymbolCenterReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Tree;
        private System.Windows.Forms.TextBox tbSIDC_1;
        private System.Windows.Forms.TextBox tbSIDC_3;
        private System.Windows.Forms.TextBox tbSIDC_2;
        private System.Windows.Forms.TextBox tbSIDC_15;
        private System.Windows.Forms.TextBox tbSIDC_14;
        private System.Windows.Forms.TextBox tbSIDC_13;
        private System.Windows.Forms.TextBox tbSIDC_12;
        private System.Windows.Forms.TextBox tbSIDC_11;
        private System.Windows.Forms.TextBox tbSIDC_10;
        private System.Windows.Forms.TextBox tbSIDC_9;
        private System.Windows.Forms.TextBox tbSIDC_8;
        private System.Windows.Forms.TextBox tbSIDC_7;
        private System.Windows.Forms.TextBox tbSIDC_6;
        private System.Windows.Forms.TextBox tbSIDC_5;
        private System.Windows.Forms.TextBox tbSIDC_4;
        private System.Windows.Forms.GroupBox SIDC;
        private System.Windows.Forms.TextBox tb_DebugTab4;
        private System.Windows.Forms.RadioButton rbNN;
        private System.Windows.Forms.RadioButton rbMO;
        private System.Windows.Forms.RadioButton rbMP;
        private System.Windows.Forms.RadioButton rbMQ;
        private System.Windows.Forms.RadioButton rb4P;
        private System.Windows.Forms.RadioButton rb4C;
        private System.Windows.Forms.RadioButton rb7Null;
        private System.Windows.Forms.RadioButton rb7A;
        private System.Windows.Forms.RadioButton rb7E;
        private System.Windows.Forms.RadioButton rb7U;
        private System.Windows.Forms.RadioButton rb9Null;
        private System.Windows.Forms.RadioButton rb9L;
        private System.Windows.Forms.RadioButton rb9H;
        private System.Windows.Forms.RadioButton rb8Null;
        private System.Windows.Forms.RadioButton rb8L;
        private System.Windows.Forms.RadioButton rb8T;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_Invalid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CurDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Debug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bn_SVG;
        private System.Windows.Forms.TextBox tb_SVG;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
    }
}

