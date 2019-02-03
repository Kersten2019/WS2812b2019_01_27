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
using System.Xml.Serialization;

namespace WS2812b
{
    public partial class FormWS812 : Form
    {
        //Active Segment zum Verarbeiten in den Panel Farben Methoden
        int ActiveSegment = 1;
        // Anzahl der activen Segmente 0 = 1 Segment wird wegen dem ESP gebraucht mit 0
        int ActiveSegmentsCount = 0;
        // Um nächstes Panel zu aktivieren
        int ActivateNextSegment = 1;
        //Um vorheriges Panel zu aktivieren
        int ActivatePrevSegment = 0;

        //Möglicheübergabewerte an ESP
        string ESPSeg;
        string ESPMode;
        string ESPBright;
        string ESPSpeed;
        string ESPColor;


        //init Anzahl LEDS
        int LEDMax;
        //Aray für Start und Ende jedes Segmentes erzeugen
        int[] SegStart = new int[10];
        int[] SegEnd = new int[10];


        public FormWS812()
        {
            InitializeComponent();

            //show list of valid com ports
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComboBoxComPort.Items.Add(s);
            }

            //Config aus Default laden

            LEDMax = 300; //Kannweg, wenn Wwrt aus XML kommt

            // Auf allen Segmenten MAX LED bei NumericUD setzen
            SetAllNumericUDtoMaxLED();




        }

        /*
        Vom
        System
        erzeugt
        Events 
        */


        private void ChangePanelColorSeg1(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void ChangePanelColorSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 10;
            ChangeColorSelectedPanel(ActiveSegment);
        }

        private void AddSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControlsfirst(ActiveSegment);

            ActivateNextSegment = 2;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 3;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 4;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 5;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 6;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 7;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 8;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 9;
            EnableNextSegmentControls(ActivateNextSegment);

            ChangeToNextTab();
        }

        private void AddSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            AddSegment(ActiveSegment);

            DisableCurrentSegmentControls(ActiveSegment);

            ActivateNextSegment = 10;
            EnableNextSegmentControlsLast(ActivateNextSegment);

            ChangeToNextTab();

        }

        private void DelSeg10(object sender, EventArgs e)
        {
            ActivatePrevSegment = 9;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment);
            
            
            //Controls auf aktivem Tab Deaktivieren


            //Controls auf vorherigen Tab aktivieren

            //Zu vorherigen Tab wechseln
            ChangeToPrevTab();
        }

        private void DelSeg9(object sender, EventArgs e)
        {

        }

        private void DelSeg8(object sender, EventArgs e)
        {

        }

        private void DelSeg7(object sender, EventArgs e)
        {

        }

        private void DelSeg6(object sender, EventArgs e)
        {

        }

        private void DelSeg5(object sender, EventArgs e)
        {

        }

        private void DelSeg4(object sender, EventArgs e)
        {

        }

        private void DelSeg3(object sender, EventArgs e)
        {

        }

        private void DelSeg2(object sender, EventArgs e)
        {

        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                var path = openfiledialog.FileName;
            }

        }

        /*
         Ab
         hier
         sind
         meine
         Methoden
         */


        public void ChangeColorSelectedPanel(int ActiveSegment)
        {
            //Variablen vorbereiten

            string SelectedTrackBarRed = "TrackBarRedSeg";
            string SelectedTrackBarGreen = "TrackBarGreenSeg";
            string SelectedTrackBarBlue = "TrackBarBlueSeg";
            string SelectedLabelRed = "LabelValueRedSeg";
            string SelectedLabelGreen = "LabelValueGreenSeg";
            string SelectedLabelBlue = "LabelValueBlueSeg";
            string SelectedPanel = "PanelSeg";

            //Trackbar Rot identifizieren
            SelectedTrackBarRed = SelectedTrackBarRed + ActiveSegment.ToString();
            TrackBar seltrackRed = (TrackBar)this.Controls.Find(SelectedTrackBarRed, true)[0];

            //Trackbar Gruen identifizieren
            SelectedTrackBarGreen = SelectedTrackBarGreen + ActiveSegment.ToString();
            TrackBar seltrackGreen = (TrackBar)this.Controls.Find(SelectedTrackBarGreen, true)[0];

            //Trackbar Blau identifizieren
            SelectedTrackBarBlue = SelectedTrackBarBlue + ActiveSegment.ToString();
            TrackBar seltrackBlue = (TrackBar)this.Controls.Find(SelectedTrackBarBlue, true)[0];

            //Label rot identifizieren
            SelectedLabelRed = SelectedLabelRed + ActiveSegment.ToString();
            Label sellabelRed = (Label)this.Controls.Find(SelectedLabelRed, true)[0];

            //Label Gruen identifizieren
            SelectedLabelGreen = SelectedLabelGreen + ActiveSegment.ToString();
            Label sellabelGreen = (Label)this.Controls.Find(SelectedLabelGreen, true)[0];

            //Label Blau identifizieren
            SelectedLabelBlue = SelectedLabelBlue + ActiveSegment.ToString();
            Label sellabelBlue = (Label)this.Controls.Find(SelectedLabelBlue, true)[0];

            //Panel identifizieren
            SelectedPanel = SelectedPanel + ActiveSegment.ToString();
            Panel selPanel = (Panel)this.Controls.Find(SelectedPanel, true)[0];

            //Neue Farbe Panel setzen;
            selPanel.BackColor = Color.FromArgb(seltrackRed.Value, seltrackGreen.Value, seltrackBlue.Value);
            //RGB Werte der Label schreiben
            sellabelRed.Text = seltrackRed.Value.ToString();
            sellabelGreen.Text = seltrackGreen.Value.ToString();
            sellabelBlue.Text = seltrackBlue.Value.ToString();

            //Variablen zurücksetzen
            SelectedPanel = "PanelSeg";
            SelectedTrackBarRed = "TrackBarRedSeg";
            SelectedTrackBarGreen = "TrackBarGreenSeg";
            SelectedTrackBarBlue = "TrackBarBlueSeg";
            SelectedLabelRed = "LabelValueRedSeg";
            SelectedLabelGreen = "LabelValueGreenSeg";
            SelectedLabelBlue = "LabelValueBlueSeg";

        }

        public void TransmitToESP(string ESPSeg, string ESPMode, string ESPBright, string ESPSpeed, string ESPColor)
        {
            /* Mögliche Kommandos über COM-Schnittstelle
               setSegment(segment index, start LED, stop LED, mode, color, speed, reverse)
                m <n> : select mode <n>
                b+    : increase brightness
                b-    : decrease brightness
                b <n> : set brightness to <n>
                s+    : increase speed
                s-    : decrease speed
                s <n> : set speed to <n>
                c 0x007BFF : set color to 0x007BFF
                SPEED_MIN = 10
                SPEED_MAX = 65535
                BRIGHTNESS_MIN = 0
                BRIGHTNESS_MAX = 255
            */
        }

        public void AddSegment(int ActiveSegment)
        {

            string SelectedNumericUD = "NumericUDSeg";
            string NextLabelLEDfromSeg = "LabelLEDfromSeg";

            //Zahlen Werte für die LEDS von und bis
            int NewLEDSegEnd;
            int NewLEDSegStart;
            //Zahlenwerte für ansprechen des Array vorbereiten
            int ActiveLEDSeg;
            int NextLEDSeg;

            //NumericUD auf aktuellen Segment identifizieren
            SelectedNumericUD = SelectedNumericUD + (ActiveSegment.ToString());
            NumericUpDown SelNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            //Neues Ende des aktuellen Segment auf Wert aus NumericUD setzen
            NewLEDSegEnd = Decimal.ToInt32(SelNumericUD.Value);

            //Prüfen ob Eingaben stimmen = Neues Ende min 5 LED Lang
            if (LEDMax - NewLEDSegEnd > 4)
            {
                //Label auf Nächstem SegmentStart neu schreiben
                NextLabelLEDfromSeg = NextLabelLEDfromSeg + (ActiveSegment + 1).ToString();
                Label selnextlabel = (Label)this.Controls.Find(NextLabelLEDfromSeg, true)[0];
                //Aus dem int NewLEDSegEnd + dazu addieren und dann den String zusammenbauen und auf nächstes Segment schreiben
                NewLEDSegStart = NewLEDSegEnd + 1;
                selnextlabel.Text = "Von LED " + NewLEDSegStart;

                //Variablen für Array vorbereiten
                ActiveLEDSeg = ActiveSegmentsCount;
                NextLEDSeg = ActiveSegmentsCount + 1;

                //Werte ins Array schreiben
                SegEnd[ActiveLEDSeg] = NewLEDSegEnd;
                SegStart[NextLEDSeg] = NewLEDSegStart;

                //Werte in currentconfig schreiben
                
                //Wert der activen Segmente erhöhen und übergabe Wert nächstes Panel
                ActiveSegmentsCount = ActiveSegmentsCount + 1;
                ActivateNextSegment = ActivateNextSegment + 1;
            }

            else
            {
                //Fehlermeldung weil weniger als 5 LED übrig
            }



        }

        public void DisableCurrentSegmentControls(int ActiveSegment)
        {

            //Steuerlemente für Segmentcontrolle inaktiv machen
            string SelectedNumericUD = "NumericUDSeg";
            string SelectedButtonLEDSegAdd = "ButtonLEDSegAddSeg";
            string SelectedButtonLEDSegDel = "ButtonLEDSegDelSeg";

            //NumericUD auf aktuellen Segment identifizieren
            SelectedNumericUD = SelectedNumericUD + (ActiveSegment.ToString());
            NumericUpDown selNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            selNumericUD.Enabled = false;

            //Button LEDSegAdd auf aktuellen Segment identifizieren
            SelectedButtonLEDSegAdd = SelectedButtonLEDSegAdd + (ActiveSegment.ToString());
            Button selButLEDSegAddSeg = (Button)this.Controls.Find(SelectedButtonLEDSegAdd, true)[0];
            selButLEDSegAddSeg.Enabled = false;

            //Button LEDSegDel auf aktuellen Segment identifizieren beim ersten nicht notwendig
            SelectedButtonLEDSegDel = SelectedButtonLEDSegDel + (ActiveSegment.ToString());
            Button selButLEDSegDelSeg = (Button)this.Controls.Find(SelectedButtonLEDSegDel, true)[0];
            selButLEDSegDelSeg.Enabled = false;
        }

        public void DisableCurrentSegmentControlsfirst(int ActiveSegment)
        {
            //Steuerlemente für Segmentcontrolle inaktiv machen
            string SelectedNumericUD = "NumericUDSeg";
            string SelectedButtonLEDSegAdd = "ButtonLEDSegAddSeg";

            //NumericUD auf aktuellen Segment identifizieren
            SelectedNumericUD = SelectedNumericUD + (ActiveSegment.ToString());
            NumericUpDown selNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            selNumericUD.Enabled = false;

            //Button LEDSegAdd auf aktuellen Segment identifizieren
            SelectedButtonLEDSegAdd = SelectedButtonLEDSegAdd + (ActiveSegment.ToString());
            Button selButLEDSegAddSeg = (Button)this.Controls.Find(SelectedButtonLEDSegAdd, true)[0];
            selButLEDSegAddSeg.Enabled = false;
        }

        public void DisableCurrentSegmentControlsLast(int ActiveSegment)
        {
            //Steuerlemente für Segmentcontrolle inaktiv machen
            string SelectedNumericUD = "NumericUDSeg";
            string SelectedButtonLEDSegDel = "ButtonLEDSegDelSeg";

            //NumericUD auf aktuellen Segment identifizieren
            SelectedNumericUD = SelectedNumericUD + (ActiveSegment.ToString());
            NumericUpDown selNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            selNumericUD.Enabled = false;

            //Button LEDSegDel auf aktuellen Segment identifizieren
            SelectedButtonLEDSegDel = SelectedButtonLEDSegDel + (ActiveSegment.ToString());
            Button selButLEDSegDelSeg = (Button)this.Controls.Find(SelectedButtonLEDSegDel, true)[0];
            selButLEDSegDelSeg.Enabled = false;
        }

        public void EnableNextSegmentControls(int ActivateNextSegment)
        {
            //Steuerelemet herstellen
            string SelectedNumericUD = "NumericUDSeg";
            string SelectedButtonLEDSegAdd = "ButtonLEDSegAddSeg";
            string SelectedButtonLEDSegDel = "ButtonLEDSegDelSeg";
            string SelectedTrackBarRed = "TrackBarRedSeg";
            string SelectedTrackBarGreen = "TrackBarGreenSeg";
            string SelectedTrackBarBlue = "TrackBarBlueSeg";
            string SelectedTrackBarSpeed = "TrackBarSpeedSeg";
            string SelectedTrackBarBright = "TrackBarBrightSeg";
            string SelectedListBoxModi = "ListBoxModiSeg";


            //NumericUD &  Buttons Zugriff erlauben
            SelectedNumericUD = SelectedNumericUD + ActivateNextSegment.ToString();
            NumericUpDown selNumeric = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            selNumeric.Enabled = true;
            SelectedButtonLEDSegAdd = SelectedButtonLEDSegAdd + ActivateNextSegment.ToString();
            Button selButtonLEDSegAdd = (Button)this.Controls.Find(SelectedButtonLEDSegAdd, true)[0];
            selButtonLEDSegAdd.Enabled = true;
            SelectedButtonLEDSegDel = SelectedButtonLEDSegDel + ActivateNextSegment.ToString();
            Button selButtonLEDSegDel = (Button)this.Controls.Find(SelectedButtonLEDSegDel, true)[0];
            selButtonLEDSegDel.Enabled = true;

            //Trackbars Zugriff erlauben
            SelectedTrackBarRed = SelectedTrackBarRed + ActivateNextSegment.ToString();
            TrackBar seltrackRed = (TrackBar)this.Controls.Find(SelectedTrackBarRed, true)[0];
            seltrackRed.Enabled = true;
            SelectedTrackBarGreen = SelectedTrackBarGreen + ActivateNextSegment.ToString();
            TrackBar seltrackGreen = (TrackBar)this.Controls.Find(SelectedTrackBarGreen, true)[0];
            seltrackGreen.Enabled = true;
            SelectedTrackBarBlue = SelectedTrackBarBlue + ActivateNextSegment.ToString();
            TrackBar seltrackBlue = (TrackBar)this.Controls.Find(SelectedTrackBarBlue, true)[0];
            seltrackBlue.Enabled = true;
            SelectedTrackBarSpeed = SelectedTrackBarSpeed + ActivateNextSegment.ToString();
            TrackBar selTrackBarSpeed = (TrackBar)this.Controls.Find(SelectedTrackBarSpeed, true)[0];
            selTrackBarSpeed.Enabled = true;
            SelectedTrackBarBright = SelectedTrackBarBright + ActivateNextSegment.ToString();
            TrackBar selTrackBarBright = (TrackBar)this.Controls.Find(SelectedTrackBarBright, true)[0];
            selTrackBarBright.Enabled = true;

            //Listbox Zugriff erlauben
            SelectedListBoxModi = SelectedListBoxModi + ActivateNextSegment.ToString();
            ListBox selListBoxModi = (ListBox)this.Controls.Find(SelectedListBoxModi, true)[0];
            selListBoxModi.Enabled = true;
        }

        public void EnableNextSegmentControlsLast(int ActivateNextSegment)
        {
            //Steuerelemet herstellen
            string SelectedNumericUD = "NumericUDSeg";
            string SelectedButtonLEDSegAdd = "ButtonLEDSegAddSeg";
            string SelectedButtonLEDSegDel = "ButtonLEDSegDelSeg";
            string SelectedTrackBarRed = "TrackBarRedSeg";
            string SelectedTrackBarGreen = "TrackBarGreenSeg";
            string SelectedTrackBarBlue = "TrackBarBlueSeg";
            string SelectedTrackBarSpeed = "TrackBarSpeedSeg";
            string SelectedTrackBarBright = "TrackBarBrightSeg";
            string SelectedListBoxModi = "ListBoxModiSeg";


            //Buttons Zugriff erlauben
            SelectedButtonLEDSegDel = SelectedButtonLEDSegDel + ActivateNextSegment.ToString();
            Button selButtonLEDSegDel = (Button)this.Controls.Find(SelectedButtonLEDSegDel, true)[0];
            selButtonLEDSegDel.Enabled = true;


            //Trackbars Zugriff erlauben
            SelectedTrackBarRed = SelectedTrackBarRed + ActivateNextSegment.ToString();
            TrackBar seltrackRed = (TrackBar)this.Controls.Find(SelectedTrackBarRed, true)[0];
            seltrackRed.Enabled = true;
            SelectedTrackBarGreen = SelectedTrackBarGreen + ActivateNextSegment.ToString();
            TrackBar seltrackGreen = (TrackBar)this.Controls.Find(SelectedTrackBarGreen, true)[0];
            seltrackGreen.Enabled = true;
            SelectedTrackBarBlue = SelectedTrackBarBlue + ActivateNextSegment.ToString();
            TrackBar seltrackBlue = (TrackBar)this.Controls.Find(SelectedTrackBarBlue, true)[0];
            seltrackBlue.Enabled = true;
            SelectedTrackBarSpeed = SelectedTrackBarSpeed + ActivateNextSegment.ToString();
            TrackBar selTrackBarSpeed = (TrackBar)this.Controls.Find(SelectedTrackBarSpeed, true)[0];
            selTrackBarSpeed.Enabled = true;
            SelectedTrackBarBright = SelectedTrackBarBright + ActivateNextSegment.ToString();
            TrackBar selTrackBarBright = (TrackBar)this.Controls.Find(SelectedTrackBarBright, true)[0];
            selTrackBarBright.Enabled = true;

            //Listbox Zugriff erlauben
            SelectedListBoxModi = SelectedListBoxModi + ActivateNextSegment.ToString();
            ListBox selListBoxModi = (ListBox)this.Controls.Find(SelectedListBoxModi, true)[0];
            selListBoxModi.Enabled = true;
        }

        public void EnablePrevSegmentControls(int ActivatePrevSegment)
        {

        }
        
        public void DelSegment(int ActiveSegment)
        {

            ActiveSegmentsCount = ActiveSegmentsCount - 1;
            int OldLEDSegEnd;
            int NewSegEnd;

            int ActiveLEDSeg;
            int PrevLEDSeg;

            //Prev Segmet new end = Max LED
            //NumericUD auf aktuellen Segment identifizieren
            SelectedNumericUD = SelectedNumericUD + (ActivatePrevSegment.ToString());
            NumericUpDown SelNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
            SelNumericUD.Value = LEDMax;

            //Aktives Array mit 0 füllen
            SegEnd[ActiveLEDSeg] = 0;
            SegStart[ActiveLEDSeg] =0;

            //Ende letztes Segmt in Arry schreiben
            PrevLEDSeg = ActiveLEDSeg - 1;
            SegEnd[ActiveLEDSeg] = LEDMax;








        }

        public void ChangeToNextTab()
        {
            string ChangeToTab = "TabSeg";
            ChangeToTab = ChangeToTab + ActivateNextSegment.ToString();
            TabSegmente.SelectedTab = TabSegmente.TabPages[ChangeToTab];
        }

        public void ChangeToPrevTab()
        {
            string ChangeToTab = "TabSeg";
            ChangeToTab = ChangeToTab + ActivatePrevSegment.ToString();
            TabSegmente.SelectedTab = TabSegmente.TabPages[ChangeToTab];
        }

        public void SetAllNumericUDtoMaxLED()
        {
            string SelectedNumericUD = "NumericUDSeg";
            for (int i = 1; i < 11; i++)
            {
                //alle NumericUD auf Max LED stellen
                SelectedNumericUD = SelectedNumericUD + (i.ToString());
                NumericUpDown SelNumericUD = (NumericUpDown)this.Controls.Find(SelectedNumericUD, true)[0];
                //NumericUD schreiben
                SelNumericUD.Value = LEDMax;
                //String wieder für Schleife zurück setzen
                SelectedNumericUD = "NumericUDSeg";
            }




        }
    }
}

