namespace WS2812b
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabHaupt = new System.Windows.Forms.TabControl();
            this.TabControl = new System.Windows.Forms.TabPage();
            this.LabelSegCount = new System.Windows.Forms.Label();
            this.TrackBarSegCount = new System.Windows.Forms.TrackBar();
            this.TabSegmente = new System.Windows.Forms.TabControl();
            this.TabSeg1 = new System.Windows.Forms.TabPage();
            this.PanelSeg1 = new System.Windows.Forms.Panel();
            this.TrackBarBlueSeg1 = new System.Windows.Forms.TrackBar();
            this.TrackBarGreenSeg1 = new System.Windows.Forms.TrackBar();
            this.TrackBarRedSeg1 = new System.Windows.Forms.TrackBar();
            this.NumericUDSeg1 = new System.Windows.Forms.NumericUpDown();
            this.LabelValueBlueSeg1 = new System.Windows.Forms.Label();
            this.LabelColorBlueSeg1 = new System.Windows.Forms.Label();
            this.LabelValueGreenSeg1 = new System.Windows.Forms.Label();
            this.LabelColorGreenSeg1 = new System.Windows.Forms.Label();
            this.LabelValueRedSeg1 = new System.Windows.Forms.Label();
            this.LabelColorRedSeg1 = new System.Windows.Forms.Label();
            this.LabelLEDfromSeg1 = new System.Windows.Forms.Label();
            this.TabSeg2 = new System.Windows.Forms.TabPage();
            this.TabSeg3 = new System.Windows.Forms.TabPage();
            this.TabSeg4 = new System.Windows.Forms.TabPage();
            this.TabSeg5 = new System.Windows.Forms.TabPage();
            this.TabSeg6 = new System.Windows.Forms.TabPage();
            this.TabSeg7 = new System.Windows.Forms.TabPage();
            this.TabSeg8 = new System.Windows.Forms.TabPage();
            this.TabSeg9 = new System.Windows.Forms.TabPage();
            this.TabSeg10 = new System.Windows.Forms.TabPage();
            this.TabKonfig = new System.Windows.Forms.TabPage();
            this.ComboBoxComPort = new System.Windows.Forms.ComboBox();
            this.ComboBoxArduinoPIN = new System.Windows.Forms.ComboBox();
            this.TextBoxConfLEDCount = new System.Windows.Forms.TextBox();
            this.LabelConfComPort = new System.Windows.Forms.Label();
            this.LabelConfArduinoPIN = new System.Windows.Forms.Label();
            this.LabelConfLEDCount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TabHaupt.SuspendLayout();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSegCount)).BeginInit();
            this.TabSegmente.SuspendLayout();
            this.TabSeg1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlueSeg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreenSeg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRedSeg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDSeg1)).BeginInit();
            this.TabKonfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernAlsToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // speichernAlsToolStripMenuItem
            // 
            this.speichernAlsToolStripMenuItem.Name = "speichernAlsToolStripMenuItem";
            this.speichernAlsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.speichernAlsToolStripMenuItem.Text = "Speichern als";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // TabHaupt
            // 
            this.TabHaupt.Controls.Add(this.TabControl);
            this.TabHaupt.Controls.Add(this.TabKonfig);
            this.TabHaupt.Location = new System.Drawing.Point(0, 27);
            this.TabHaupt.Name = "TabHaupt";
            this.TabHaupt.SelectedIndex = 0;
            this.TabHaupt.Size = new System.Drawing.Size(735, 770);
            this.TabHaupt.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LabelSegCount);
            this.TabControl.Controls.Add(this.TrackBarSegCount);
            this.TabControl.Controls.Add(this.TabSegmente);
            this.TabControl.Location = new System.Drawing.Point(4, 22);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl.Size = new System.Drawing.Size(727, 744);
            this.TabControl.TabIndex = 0;
            this.TabControl.Text = "Steuerung";
            this.TabControl.UseVisualStyleBackColor = true;
            // 
            // LabelSegCount
            // 
            this.LabelSegCount.AutoSize = true;
            this.LabelSegCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSegCount.Location = new System.Drawing.Point(275, 18);
            this.LabelSegCount.Name = "LabelSegCount";
            this.LabelSegCount.Size = new System.Drawing.Size(157, 18);
            this.LabelSegCount.TabIndex = 2;
            this.LabelSegCount.Text = "Anzahl der Segmente";
            // 
            // TrackBarSegCount
            // 
            this.TrackBarSegCount.BackColor = System.Drawing.Color.White;
            this.TrackBarSegCount.Location = new System.Drawing.Point(12, 53);
            this.TrackBarSegCount.Minimum = 1;
            this.TrackBarSegCount.Name = "TrackBarSegCount";
            this.TrackBarSegCount.Size = new System.Drawing.Size(692, 45);
            this.TrackBarSegCount.TabIndex = 1;
            this.TrackBarSegCount.Value = 1;
            // 
            // TabSegmente
            // 
            this.TabSegmente.Controls.Add(this.TabSeg1);
            this.TabSegmente.Controls.Add(this.TabSeg2);
            this.TabSegmente.Controls.Add(this.TabSeg3);
            this.TabSegmente.Controls.Add(this.TabSeg4);
            this.TabSegmente.Controls.Add(this.TabSeg5);
            this.TabSegmente.Controls.Add(this.TabSeg6);
            this.TabSegmente.Controls.Add(this.TabSeg7);
            this.TabSegmente.Controls.Add(this.TabSeg8);
            this.TabSegmente.Controls.Add(this.TabSeg9);
            this.TabSegmente.Controls.Add(this.TabSeg10);
            this.TabSegmente.Location = new System.Drawing.Point(12, 104);
            this.TabSegmente.Name = "TabSegmente";
            this.TabSegmente.SelectedIndex = 0;
            this.TabSegmente.Size = new System.Drawing.Size(696, 626);
            this.TabSegmente.TabIndex = 0;
            // 
            // TabSeg1
            // 
            this.TabSeg1.Controls.Add(this.trackBar2);
            this.TabSeg1.Controls.Add(this.trackBar1);
            this.TabSeg1.Controls.Add(this.listBox1);
            this.TabSeg1.Controls.Add(this.PanelSeg1);
            this.TabSeg1.Controls.Add(this.TrackBarBlueSeg1);
            this.TabSeg1.Controls.Add(this.TrackBarGreenSeg1);
            this.TabSeg1.Controls.Add(this.TrackBarRedSeg1);
            this.TabSeg1.Controls.Add(this.NumericUDSeg1);
            this.TabSeg1.Controls.Add(this.LabelValueBlueSeg1);
            this.TabSeg1.Controls.Add(this.label2);
            this.TabSeg1.Controls.Add(this.label1);
            this.TabSeg1.Controls.Add(this.LabelColorBlueSeg1);
            this.TabSeg1.Controls.Add(this.LabelValueGreenSeg1);
            this.TabSeg1.Controls.Add(this.LabelColorGreenSeg1);
            this.TabSeg1.Controls.Add(this.LabelValueRedSeg1);
            this.TabSeg1.Controls.Add(this.LabelColorRedSeg1);
            this.TabSeg1.Controls.Add(this.LabelLEDfromSeg1);
            this.TabSeg1.Location = new System.Drawing.Point(4, 22);
            this.TabSeg1.Name = "TabSeg1";
            this.TabSeg1.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg1.Size = new System.Drawing.Size(688, 600);
            this.TabSeg1.TabIndex = 0;
            this.TabSeg1.Text = "Segment 01";
            this.TabSeg1.UseVisualStyleBackColor = true;
            // 
            // PanelSeg1
            // 
            this.PanelSeg1.BackColor = System.Drawing.Color.Black;
            this.PanelSeg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSeg1.Location = new System.Drawing.Point(422, 66);
            this.PanelSeg1.Name = "PanelSeg1";
            this.PanelSeg1.Size = new System.Drawing.Size(193, 190);
            this.PanelSeg1.TabIndex = 3;
            // 
            // TrackBarBlueSeg1
            // 
            this.TrackBarBlueSeg1.BackColor = System.Drawing.Color.Blue;
            this.TrackBarBlueSeg1.Location = new System.Drawing.Point(9, 211);
            this.TrackBarBlueSeg1.Maximum = 255;
            this.TrackBarBlueSeg1.Name = "TrackBarBlueSeg1";
            this.TrackBarBlueSeg1.Size = new System.Drawing.Size(370, 45);
            this.TrackBarBlueSeg1.SmallChange = 10;
            this.TrackBarBlueSeg1.TabIndex = 10;
            this.TrackBarBlueSeg1.TickFrequency = 10;
            this.TrackBarBlueSeg1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarBlueSeg1.Scroll += new System.EventHandler(this.ChangePanelColor);
            // 
            // TrackBarGreenSeg1
            // 
            this.TrackBarGreenSeg1.BackColor = System.Drawing.Color.Green;
            this.TrackBarGreenSeg1.Location = new System.Drawing.Point(9, 141);
            this.TrackBarGreenSeg1.Maximum = 255;
            this.TrackBarGreenSeg1.Name = "TrackBarGreenSeg1";
            this.TrackBarGreenSeg1.Size = new System.Drawing.Size(370, 45);
            this.TrackBarGreenSeg1.SmallChange = 10;
            this.TrackBarGreenSeg1.TabIndex = 10;
            this.TrackBarGreenSeg1.TickFrequency = 10;
            this.TrackBarGreenSeg1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarGreenSeg1.Scroll += new System.EventHandler(this.ChangePanelColor);
            // 
            // TrackBarRedSeg1
            // 
            this.TrackBarRedSeg1.BackColor = System.Drawing.Color.Red;
            this.TrackBarRedSeg1.Location = new System.Drawing.Point(9, 66);
            this.TrackBarRedSeg1.Maximum = 255;
            this.TrackBarRedSeg1.Name = "TrackBarRedSeg1";
            this.TrackBarRedSeg1.Size = new System.Drawing.Size(370, 45);
            this.TrackBarRedSeg1.SmallChange = 10;
            this.TrackBarRedSeg1.TabIndex = 10;
            this.TrackBarRedSeg1.TickFrequency = 10;
            this.TrackBarRedSeg1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackBarRedSeg1.Scroll += new System.EventHandler(this.ChangePanelColor);
            // 
            // NumericUDSeg1
            // 
            this.NumericUDSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUDSeg1.Location = new System.Drawing.Point(132, 12);
            this.NumericUDSeg1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUDSeg1.Name = "NumericUDSeg1";
            this.NumericUDSeg1.Size = new System.Drawing.Size(49, 22);
            this.NumericUDSeg1.TabIndex = 1;
            // 
            // LabelValueBlueSeg1
            // 
            this.LabelValueBlueSeg1.AutoSize = true;
            this.LabelValueBlueSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueBlueSeg1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelValueBlueSeg1.Location = new System.Drawing.Point(351, 192);
            this.LabelValueBlueSeg1.Name = "LabelValueBlueSeg1";
            this.LabelValueBlueSeg1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelValueBlueSeg1.Size = new System.Drawing.Size(15, 16);
            this.LabelValueBlueSeg1.TabIndex = 0;
            this.LabelValueBlueSeg1.Text = "0";
            this.LabelValueBlueSeg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelColorBlueSeg1
            // 
            this.LabelColorBlueSeg1.AutoSize = true;
            this.LabelColorBlueSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColorBlueSeg1.Location = new System.Drawing.Point(6, 192);
            this.LabelColorBlueSeg1.Name = "LabelColorBlueSeg1";
            this.LabelColorBlueSeg1.Size = new System.Drawing.Size(34, 16);
            this.LabelColorBlueSeg1.TabIndex = 0;
            this.LabelColorBlueSeg1.Text = "Blau";
            // 
            // LabelValueGreenSeg1
            // 
            this.LabelValueGreenSeg1.AutoSize = true;
            this.LabelValueGreenSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueGreenSeg1.Location = new System.Drawing.Point(351, 122);
            this.LabelValueGreenSeg1.Name = "LabelValueGreenSeg1";
            this.LabelValueGreenSeg1.Size = new System.Drawing.Size(15, 16);
            this.LabelValueGreenSeg1.TabIndex = 0;
            this.LabelValueGreenSeg1.Text = "0";
            this.LabelValueGreenSeg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelColorGreenSeg1
            // 
            this.LabelColorGreenSeg1.AutoSize = true;
            this.LabelColorGreenSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColorGreenSeg1.Location = new System.Drawing.Point(3, 122);
            this.LabelColorGreenSeg1.Name = "LabelColorGreenSeg1";
            this.LabelColorGreenSeg1.Size = new System.Drawing.Size(36, 16);
            this.LabelColorGreenSeg1.TabIndex = 0;
            this.LabelColorGreenSeg1.Text = "Grün";
            // 
            // LabelValueRedSeg1
            // 
            this.LabelValueRedSeg1.AutoSize = true;
            this.LabelValueRedSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValueRedSeg1.Location = new System.Drawing.Point(351, 47);
            this.LabelValueRedSeg1.Name = "LabelValueRedSeg1";
            this.LabelValueRedSeg1.Size = new System.Drawing.Size(15, 16);
            this.LabelValueRedSeg1.TabIndex = 0;
            this.LabelValueRedSeg1.Text = "0";
            this.LabelValueRedSeg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelColorRedSeg1
            // 
            this.LabelColorRedSeg1.AutoSize = true;
            this.LabelColorRedSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColorRedSeg1.Location = new System.Drawing.Point(6, 46);
            this.LabelColorRedSeg1.Name = "LabelColorRedSeg1";
            this.LabelColorRedSeg1.Size = new System.Drawing.Size(28, 16);
            this.LabelColorRedSeg1.TabIndex = 0;
            this.LabelColorRedSeg1.Text = "Rot";
            // 
            // LabelLEDfromSeg1
            // 
            this.LabelLEDfromSeg1.AutoSize = true;
            this.LabelLEDfromSeg1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLEDfromSeg1.Location = new System.Drawing.Point(6, 14);
            this.LabelLEDfromSeg1.Name = "LabelLEDfromSeg1";
            this.LabelLEDfromSeg1.Size = new System.Drawing.Size(120, 16);
            this.LabelLEDfromSeg1.TabIndex = 0;
            this.LabelLEDfromSeg1.Text = "Von LED 1 bis LED";
            // 
            // TabSeg2
            // 
            this.TabSeg2.Location = new System.Drawing.Point(4, 22);
            this.TabSeg2.Name = "TabSeg2";
            this.TabSeg2.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg2.Size = new System.Drawing.Size(688, 479);
            this.TabSeg2.TabIndex = 1;
            this.TabSeg2.Text = "Segment 02";
            this.TabSeg2.UseVisualStyleBackColor = true;
            // 
            // TabSeg3
            // 
            this.TabSeg3.Location = new System.Drawing.Point(4, 22);
            this.TabSeg3.Name = "TabSeg3";
            this.TabSeg3.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg3.Size = new System.Drawing.Size(688, 479);
            this.TabSeg3.TabIndex = 2;
            this.TabSeg3.Text = "Segment 03";
            this.TabSeg3.UseVisualStyleBackColor = true;
            // 
            // TabSeg4
            // 
            this.TabSeg4.Location = new System.Drawing.Point(4, 22);
            this.TabSeg4.Name = "TabSeg4";
            this.TabSeg4.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg4.Size = new System.Drawing.Size(688, 479);
            this.TabSeg4.TabIndex = 3;
            this.TabSeg4.Text = "Segment 04";
            this.TabSeg4.UseVisualStyleBackColor = true;
            // 
            // TabSeg5
            // 
            this.TabSeg5.Location = new System.Drawing.Point(4, 22);
            this.TabSeg5.Name = "TabSeg5";
            this.TabSeg5.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg5.Size = new System.Drawing.Size(688, 479);
            this.TabSeg5.TabIndex = 4;
            this.TabSeg5.Text = "Segment 05";
            this.TabSeg5.UseVisualStyleBackColor = true;
            // 
            // TabSeg6
            // 
            this.TabSeg6.Location = new System.Drawing.Point(4, 22);
            this.TabSeg6.Name = "TabSeg6";
            this.TabSeg6.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg6.Size = new System.Drawing.Size(688, 479);
            this.TabSeg6.TabIndex = 5;
            this.TabSeg6.Text = "Segment 06";
            this.TabSeg6.UseVisualStyleBackColor = true;
            // 
            // TabSeg7
            // 
            this.TabSeg7.Location = new System.Drawing.Point(4, 22);
            this.TabSeg7.Name = "TabSeg7";
            this.TabSeg7.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg7.Size = new System.Drawing.Size(688, 479);
            this.TabSeg7.TabIndex = 6;
            this.TabSeg7.Text = "Segment 07";
            this.TabSeg7.UseVisualStyleBackColor = true;
            // 
            // TabSeg8
            // 
            this.TabSeg8.Location = new System.Drawing.Point(4, 22);
            this.TabSeg8.Name = "TabSeg8";
            this.TabSeg8.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg8.Size = new System.Drawing.Size(688, 479);
            this.TabSeg8.TabIndex = 7;
            this.TabSeg8.Text = "Segment 08";
            this.TabSeg8.UseVisualStyleBackColor = true;
            // 
            // TabSeg9
            // 
            this.TabSeg9.Location = new System.Drawing.Point(4, 22);
            this.TabSeg9.Name = "TabSeg9";
            this.TabSeg9.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg9.Size = new System.Drawing.Size(688, 479);
            this.TabSeg9.TabIndex = 8;
            this.TabSeg9.Text = "Segment 09";
            this.TabSeg9.UseVisualStyleBackColor = true;
            // 
            // TabSeg10
            // 
            this.TabSeg10.Location = new System.Drawing.Point(4, 22);
            this.TabSeg10.Name = "TabSeg10";
            this.TabSeg10.Padding = new System.Windows.Forms.Padding(3);
            this.TabSeg10.Size = new System.Drawing.Size(688, 479);
            this.TabSeg10.TabIndex = 9;
            this.TabSeg10.Text = "Segment 10";
            this.TabSeg10.UseVisualStyleBackColor = true;
            // 
            // TabKonfig
            // 
            this.TabKonfig.Controls.Add(this.ComboBoxComPort);
            this.TabKonfig.Controls.Add(this.ComboBoxArduinoPIN);
            this.TabKonfig.Controls.Add(this.TextBoxConfLEDCount);
            this.TabKonfig.Controls.Add(this.LabelConfComPort);
            this.TabKonfig.Controls.Add(this.LabelConfArduinoPIN);
            this.TabKonfig.Controls.Add(this.LabelConfLEDCount);
            this.TabKonfig.Location = new System.Drawing.Point(4, 22);
            this.TabKonfig.Name = "TabKonfig";
            this.TabKonfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabKonfig.Size = new System.Drawing.Size(727, 623);
            this.TabKonfig.TabIndex = 1;
            this.TabKonfig.Text = "Konfiguration";
            this.TabKonfig.UseVisualStyleBackColor = true;
            // 
            // ComboBoxComPort
            // 
            this.ComboBoxComPort.FormattingEnabled = true;
            this.ComboBoxComPort.Location = new System.Drawing.Point(147, 84);
            this.ComboBoxComPort.Name = "ComboBoxComPort";
            this.ComboBoxComPort.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxComPort.TabIndex = 3;
            // 
            // ComboBoxArduinoPIN
            // 
            this.ComboBoxArduinoPIN.FormattingEnabled = true;
            this.ComboBoxArduinoPIN.Items.AddRange(new object[] {
            "D0 (16)",
            "D1 (05)",
            "D2 (04)",
            "D3 (00)",
            "D4 (02)",
            "D5 (14)",
            "D6 (12)",
            "D7 (13)",
            "D8 (15)",
            "",
            ""});
            this.ComboBoxArduinoPIN.Location = new System.Drawing.Point(147, 53);
            this.ComboBoxArduinoPIN.Name = "ComboBoxArduinoPIN";
            this.ComboBoxArduinoPIN.Size = new System.Drawing.Size(99, 21);
            this.ComboBoxArduinoPIN.TabIndex = 2;
            // 
            // TextBoxConfLEDCount
            // 
            this.TextBoxConfLEDCount.Location = new System.Drawing.Point(147, 16);
            this.TextBoxConfLEDCount.Name = "TextBoxConfLEDCount";
            this.TextBoxConfLEDCount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxConfLEDCount.TabIndex = 1;
            // 
            // LabelConfComPort
            // 
            this.LabelConfComPort.AutoSize = true;
            this.LabelConfComPort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfComPort.Location = new System.Drawing.Point(9, 84);
            this.LabelConfComPort.Name = "LabelConfComPort";
            this.LabelConfComPort.Size = new System.Drawing.Size(75, 18);
            this.LabelConfComPort.TabIndex = 0;
            this.LabelConfComPort.Text = "Com Port";
            // 
            // LabelConfArduinoPIN
            // 
            this.LabelConfArduinoPIN.AutoSize = true;
            this.LabelConfArduinoPIN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfArduinoPIN.Location = new System.Drawing.Point(8, 50);
            this.LabelConfArduinoPIN.Name = "LabelConfArduinoPIN";
            this.LabelConfArduinoPIN.Size = new System.Drawing.Size(91, 18);
            this.LabelConfArduinoPIN.TabIndex = 0;
            this.LabelConfArduinoPIN.Text = "Arduino PIN";
            // 
            // LabelConfLEDCount
            // 
            this.LabelConfLEDCount.AutoSize = true;
            this.LabelConfLEDCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfLEDCount.Location = new System.Drawing.Point(9, 19);
            this.LabelConfLEDCount.Name = "LabelConfLEDCount";
            this.LabelConfLEDCount.Size = new System.Drawing.Size(131, 18);
            this.LabelConfLEDCount.TabIndex = 0;
            this.LabelConfLEDCount.Text = "Anzahl der LED\'S";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Static - No blinking. Just plain old static light.",
            "Blink - Normal blinking. 50% on/off time.",
            "Breath - Does the \"standby-breathing\" of well known i-Devices. Fixed Speed.",
            "Color Wipe - Lights all LEDs after each other up. Then turns them in that order o" +
                "ff. Repeat.",
            "Color Wipe Inverse - Same as Color Wipe, except swaps on/off colors.",
            "Color Wipe Reverse - Lights all LEDs after each other up. Then turns them in reve" +
                "rse order off. Repeat.",
            "Color Wipe Reverse Inverse - Same as Color Wipe Reverse, except swaps on/off colo" +
                "rs.",
            "Color Wipe Random - Turns all LEDs after each other to a random color. Then start" +
                "s over with another color.",
            "Random Color - Lights all LEDs in one random color up. Then switches them to the " +
                "next random color.",
            "Single Dynamic - Lights every LED in a random color. Changes one random LED after" +
                " the other to a random color.",
            "Multi Dynamic - Lights every LED in a random color. Changes all LED at the same t" +
                "ime to new random colors.",
            "Rainbow - Cycles all LEDs at once through a rainbow.",
            "Rainbow Cycle - Cycles a rainbow over the entire string of LEDs.",
            "Scan - Runs a single pixel back and forth.",
            "Dual Scan - Runs two pixel back and forth in opposite directions.",
            "Fade - Fades the LEDs on and (almost) off again.",
            "Theater Chase - Theatre-style crawling lights. Inspired by the Adafruit examples." +
                "",
            "Theater Chase Rainbow - Theatre-style crawling lights with rainbow effect. Inspir" +
                "ed by the Adafruit examples.",
            "Running Lights - Running lights effect with smooth sine transition.",
            "Twinkle - Blink several LEDs on, reset, repeat.",
            "Twinkle Random - Blink several LEDs in random colors on, reset, repeat.",
            "Twinkle Fade - Blink several LEDs on, fading out.",
            "Twinkle Fade Random - Blink several LEDs in random colors on, fading out.",
            "Sparkle - Blinks one LED at a time.",
            "Flash Sparkle - Lights all LEDs in the selected color. Flashes single white pixel" +
                "s randomly.",
            "Hyper Sparkle - Like flash sparkle. With more flash.",
            "Strobe - Classic Strobe effect.",
            "Strobe Rainbow - Classic Strobe effect. Cycling through the rainbow.",
            "Multi Strobe - Strobe effect with different strobe count and pause, controlled by" +
                " speed setting.",
            "Blink Rainbow - Classic Blink effect. Cycling through the rainbow.",
            "Chase White - Color running on white.",
            "Chase Color - White running on color.",
            "Chase Random - White running followed by random color.",
            "Chase Rainbow - White running on rainbow.",
            "Chase Flash - White flashes running on color.",
            "Chase Flash Random - White flashes running, followed by random color.",
            "Chase Rainbow White - Rainbow running on white.",
            "Chase Blackout - Black running on color.",
            "Chase Blackout Rainbow - Black running on rainbow.",
            "Color Sweep Random - Random color introduced alternating from start and end of st" +
                "rip.",
            "Running Color - Alternating color/white pixels running.",
            "Running Red Blue - Alternating red/blue pixels running.",
            "Running Random - Random colored pixels running.",
            "Larson Scanner - K.I.T.T.",
            "Comet - Firing comets from one end.",
            "Fireworks - Firework sparks.",
            "Fireworks Random - Random colored firework sparks.",
            "Merry Christmas - Alternating green/red pixels running.",
            "Fire Flicker - Fire flickering effect. Like in harsh wind.",
            "Fire Flicker (soft) - Fire flickering effect. Runs slower/softer.",
            "Fire Flicker (intense) - Fire flickering effect. More range of color.",
            "Circus Combustus - Alternating white/red/black pixels running.",
            "Halloween - Alternating orange/purple pixels running.",
            "Bicolor Chase - Two LEDs running on a background color (set three colors).",
            "Tricolor Chase - Alternating three color pixels running (set three colors).",
            "ICU - Two eyes looking around.",
            "Custom - Up to four user created custom effects."});
            this.listBox1.Location = new System.Drawing.Point(9, 410);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(606, 180);
            this.listBox1.TabIndex = 11;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(9, 359);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(606, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.White;
            this.trackBar2.Location = new System.Drawing.Point(6, 292);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(606, 45);
            this.trackBar2.SmallChange = 10;
            this.trackBar2.TabIndex = 12;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Helligkeit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geschwindigkeit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 786);
            this.Controls.Add(this.TabHaupt);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ben\'s LED Kontrolle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabHaupt.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSegCount)).EndInit();
            this.TabSegmente.ResumeLayout(false);
            this.TabSeg1.ResumeLayout(false);
            this.TabSeg1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBlueSeg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGreenSeg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRedSeg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUDSeg1)).EndInit();
            this.TabKonfig.ResumeLayout(false);
            this.TabKonfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.TabControl TabHaupt;
        private System.Windows.Forms.TabPage TabControl;
        private System.Windows.Forms.Label LabelSegCount;
        private System.Windows.Forms.TrackBar TrackBarSegCount;
        private System.Windows.Forms.TabControl TabSegmente;
        private System.Windows.Forms.TabPage TabSeg1;
        private System.Windows.Forms.TabPage TabSeg2;
        private System.Windows.Forms.TabPage TabKonfig;
        private System.Windows.Forms.TabPage TabSeg3;
        private System.Windows.Forms.TabPage TabSeg4;
        private System.Windows.Forms.TabPage TabSeg5;
        private System.Windows.Forms.TabPage TabSeg6;
        private System.Windows.Forms.TabPage TabSeg7;
        private System.Windows.Forms.TabPage TabSeg8;
        private System.Windows.Forms.TabPage TabSeg9;
        private System.Windows.Forms.TabPage TabSeg10;
        private System.Windows.Forms.Label LabelConfLEDCount;
        private System.Windows.Forms.ComboBox ComboBoxArduinoPIN;
        private System.Windows.Forms.TextBox TextBoxConfLEDCount;
        private System.Windows.Forms.Label LabelConfComPort;
        private System.Windows.Forms.Label LabelConfArduinoPIN;
        private System.Windows.Forms.ComboBox ComboBoxComPort;
        private System.Windows.Forms.NumericUpDown NumericUDSeg1;
        private System.Windows.Forms.Label LabelLEDfromSeg1;
        private System.Windows.Forms.Label LabelColorGreenSeg1;
        private System.Windows.Forms.Label LabelColorRedSeg1;
        private System.Windows.Forms.TrackBar TrackBarRedSeg1;
        private System.Windows.Forms.Panel PanelSeg1;
        private System.Windows.Forms.TrackBar TrackBarBlueSeg1;
        private System.Windows.Forms.TrackBar TrackBarGreenSeg1;
        private System.Windows.Forms.Label LabelColorBlueSeg1;
        private System.Windows.Forms.Label LabelValueBlueSeg1;
        private System.Windows.Forms.Label LabelValueGreenSeg1;
        private System.Windows.Forms.Label LabelValueRedSeg1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

