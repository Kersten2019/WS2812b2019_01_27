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
using System.IO.Ports;
using ReadWriteConfigFiles;

namespace WS2812b
{

    public partial class FormWS812 : Form
    {
        //Active Segment zum Verarbeiten in den Panel, Farben, Controls ETC Methoden
        public int ActiveSegment = 1;
        public int ActivateNextSegment = 1;
        public int ActivatePrevSegment = 0;
        
        //INI Segmete = ESPSegmente
        public int INIPrevSeg;
        public int INICurrentSeg; 
        public int ININextSeg;
        public int INISegCounter=0; //Zähler für Segmente
        public int LEDMax;
        
        //INI-Variablen
        //Zahlen Werte für die LEDS von und bis
        int PrevLEDSegStart;
        int NewLEDSegEnd;
        int NextLEDSegStart;
        int OldLEDSegStart;

        //Übergabe an ListArray
        string INIValueToWrite;
        string INIValueToFind;
        string SettingsNameandValuetoSplit;
        
        //Vorbereiten um string zu teilen durch "=" 
        string[] stringSeparators = new string[] { "=" };
        string[] SplittedNameandValue;

        //public string filename;
        public string FilenameToReadFrom;
        public string FilenameToWriteto;

        List<string> sectionHWSet;
        List<string> sectionSegSet;
        List<string> sectionModi;
                
        
        
        //Möglicheübergabewerte an ESP
        int ESPMode;
        int ESPBright;
        int ESPSpeed;
        string ESPAction;
        string ESPColorHex;
        string ESPColorR;
        string ESPColorG;
        string ESPColorB;
        string ESPSend;
        string ESPCOM;       

        

        public FormWS812()
        {
            InitializeComponent();


            //show list of valid com ports
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComboBoxComPort.Items.Add(s);
            }



            //prüfen ob es eine Konfig.ini gibt, wenn ja lesen, wenn nein, dann suchen
            ChooseINI();
            //File zu laden 
            ReadINI(FilenameToReadFrom);



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

        private void PictureBoxRGBSeg1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 1;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg1.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;

                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            {

            }
        }

        private void PictureBoxRGBSeg2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 2;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg2.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            {

            }
        }

        private void PictureBoxRGBSeg3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 3;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg3.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg4_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 4;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg4.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg5_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 5;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg5.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg6_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 6;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg6.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg7_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 7;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg7.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg8_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 8;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg8.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg9_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 9;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg9.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void PictureBoxRGBSeg10_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ActiveSegment = 10;
                //Werte aus Bitmap auslesen
                Bitmap Selbitmap = new Bitmap(PictureBoxRGBSeg10.BackgroundImage);
                Color color = Selbitmap.GetPixel(e.X, e.Y);

                //Werte auf Trackbar setzen
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
                seltrackRed.Value = color.R;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
                seltrackGreen.Value = color.G;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
                seltrackBlue.Value = color.B;
                ChangeColorSelectedPanel(ActiveSegment);
            }
            catch (Exception ex)
            { }
        }

        private void AddSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            ActivateNextSegment = 2;
            AddSegment(ActiveSegment, ActivateNextSegment);
        }

        private void AddSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ActivateNextSegment = 3;
            AddSegment(ActiveSegment, ActivateNextSegment);
         }

        private void AddSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ActivateNextSegment = 4;
            AddSegment(ActiveSegment, ActivateNextSegment);
         }

        private void AddSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ActivateNextSegment = 5;
            AddSegment(ActiveSegment, ActivateNextSegment);
         }

        private void AddSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ActivateNextSegment = 6;
            AddSegment(ActiveSegment, ActivateNextSegment);
         }

        private void AddSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ActivateNextSegment = 7;
            AddSegment(ActiveSegment, ActivateNextSegment);
         }

        private void AddSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ActivateNextSegment = 8;
            AddSegment(ActiveSegment, ActivateNextSegment);
        }

        private void AddSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ActivateNextSegment = 9;
            AddSegment(ActiveSegment, ActivateNextSegment);
        }

        private void AddSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ActivateNextSegment = 10;
            AddSegment(ActiveSegment, ActivateNextSegment);
        }

        private void DelSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 10;
            ActivatePrevSegment = 9;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
         }

        private void DelSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ActivatePrevSegment = 8;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
         }

        private void DelSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ActivatePrevSegment = 7;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ActivatePrevSegment = 6;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ActivatePrevSegment = 5;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ActivatePrevSegment = 4;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ActivatePrevSegment = 3;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ActivatePrevSegment = 2;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void DelSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ActivatePrevSegment = 1;
            //Aktuelles Segment löschen
            DelSegment(ActiveSegment, ActivatePrevSegment);
        }

        private void ChangePanelBrightSeg1(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            ChangePanelBright(ActiveSegment);
         }

        private void ChangePanelBrightSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ChangePanelBright(ActiveSegment);
         }

        private void ChangePanelBrightSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelBrightSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 10;
            ChangePanelBright(ActiveSegment);
        }

        private void ChangePanelSpeedSeg1(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            ChangePanelSpeed(ActiveSegment);
         }

        private void ChangePanelSpeedSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ChangePanelSpeed(ActiveSegment);
        }
        private void ChangePanelSpeedSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ChangePanelSpeedSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 10;
            ChangePanelSpeed(ActiveSegment);
        }

        private void ModusChangeSeg1(object sender, EventArgs e)
        {
            ActiveSegment = 1;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg2(object sender, EventArgs e)
        {
            ActiveSegment = 2;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg3(object sender, EventArgs e)
        {
            ActiveSegment = 3;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg4(object sender, EventArgs e)
        {
            ActiveSegment = 4;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg5(object sender, EventArgs e)
        {
            ActiveSegment = 5;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg6(object sender, EventArgs e)
        {
            ActiveSegment = 6;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg7(object sender, EventArgs e)
        {
            ActiveSegment = 7;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg8(object sender, EventArgs e)
        {
            ActiveSegment = 8;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg9(object sender, EventArgs e)
        {
            ActiveSegment = 9;
            ChangeModus(ActiveSegment);
        }

        private void ModusChangeSeg10(object sender, EventArgs e)
        {
            ActiveSegment = 10;
            ChangeModus(ActiveSegment);
        }

        private void FileOpen(object sender, EventArgs e)
        {
            ChooseINI();
            ReadINI(FilenameToReadFrom);
        }

        private void FileSave(object sender, EventArgs e)
        {
            FilenameToWriteto = FilenameToReadFrom;
            WritealltoINI(FilenameToWriteto);
         }

        private void FileSaveAs(object sender, EventArgs e)
        {
               
                
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "INI Files|*.ini";
            saveFileDialog.Title = "Neue INI-Datei speichern";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                FilenameToWriteto = saveFileDialog.FileName;
                StreamWriter INIStream = new StreamWriter(FilenameToWriteto);
                //Leere INI erzeugen mit Sektions
                INIStream.WriteLine("[HW-Settings]");
                INIStream.WriteLine("[SegmentSettings]");
                INIStream.WriteLine("[Modi]");
                INIStream.Close();
                }
            WritealltoINI(FilenameToWriteto);
        }

        private void FileBeenden(object sender, EventArgs e)
        {
        this.Close();
        }


        /*          Ab          hier          sind          meine          Methoden          */


        public void TransmitToESP(int INICurrentSeg, string ESPAction)
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


            /*
             * 
             * Der Wert 
             * für die Geschwindigkeit
             * muss vor der Übergabe mit 256
             * multipliziert werden, denn
             * Werte für Speed können zwischen 0 und 65535 liegen
             * */

            //Werte für einige Eigenschaften
            SerialPort ComPort = new SerialPort();
            ComPort.PortName = ESPCOM;
            ComPort.BaudRate = 115200;
            //ComPort.Parity = Parity.None;
            //ComPort.DataBits = 8;
            //ComPort.StopBits = StopBits.One;
            //ComPort.Handshake = Handshake.None;
            //ComPort.RtsEnable = true;
            //ComPort.DtrEnable = true;



            //Abfrage was gesendet werden soll

            //SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains(ESPAction));
            SplittedNameandValue = ESPAction.Split(stringSeparators, StringSplitOptions.None);


            if (SplittedNameandValue[0] == "Color")
            {
                ESPSend = "c " + SplittedNameandValue[1] + '\n';
            }
            else if (SplittedNameandValue[0] == "Bright")
            {
                ESPSend = "b " + SplittedNameandValue[1] + '\n';
            }
            else if (SplittedNameandValue[0] == "Speed")
            {
                ESPSend = "s " + SplittedNameandValue[1] + '\n';
            }
            else if (SplittedNameandValue[0] == "Modus")
            {
                ESPSend = "m " + SplittedNameandValue[1] + '\n';
            }
            else {
                return;
                 }



            //Öffnen der seriellen Schnittstelle
            ComPort.Open();
            //Schreibt Daten an der seriellen Schnittstelle wenn die Serielle Schnittstelle offen ist
            if (ComPort.IsOpen)
            {
                ComPort.Write(ESPSend);
            }
            //Schließen der seriellen Schnittstelle
            ComPort.Close();
        }
                        
        public void AddSegment(int ActiveSegment,int ActivateNextSegment)
        {
                //Neues Ende des aktuellen Segment auf Wert aus NumericUD setzen und UD deaktiveren
                NumericUpDown SelNumericUDAvtiveSeg = (NumericUpDown)this.Controls.Find("NumericUDSeg" + ActiveSegment.ToString(), true)[0];
                SelNumericUDAvtiveSeg.Enabled = false;
                NewLEDSegEnd = Decimal.ToInt32(SelNumericUDAvtiveSeg.Value);
                NextLEDSegStart = NewLEDSegEnd + 1;
                           
                //Add & Dell Button Aktivem Segment deaktivieren
                Button selButtonActiveSeg = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActiveSegment.ToString(), true)[0];
                selButtonActiveSeg.Enabled = false;
                Button selButtonActivelSeg = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActiveSegment.ToString(), true)[0];
                selButtonActivelSeg.Enabled = false;
                
                //Add & Del Button auf nächstem Segment aktivieren
                Button selButtonPrevAddSeg = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActivateNextSegment.ToString(), true)[0];
                selButtonPrevAddSeg.Enabled = true;
                Button selButtonPrevDelSeg = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActivateNextSegment.ToString(), true)[0];
                selButtonPrevDelSeg.Enabled = true;
                PictureBox selPicturePrevBox = (PictureBox)this.Controls.Find("PictureBoxRGBSeg" + ActivateNextSegment.ToString(), true)[0];
                selPicturePrevBox.Enabled = true;

                //Trackbars nächstes Segment aktivieren
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActivateNextSegment.ToString(), true)[0];
                seltrackRed.Enabled = true;
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActivateNextSegment.ToString(), true)[0];
                seltrackGreen.Enabled = true;
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActivateNextSegment.ToString(), true)[0];
                seltrackBlue.Enabled = true;
                TrackBar seltrackBright = (TrackBar)this.Controls.Find("TrackBarBrightSeg" + ActivateNextSegment.ToString(), true)[0];
                seltrackBright.Enabled = true;
                TrackBar seltrackSpeed = (TrackBar)this.Controls.Find("TrackBarSpeedSeg" + ActivateNextSegment.ToString(), true)[0];
                seltrackSpeed.Enabled = true;

                //ListBox mit Modi aktivieren
                ListBox selListbox = (ListBox)this.Controls.Find("ListBoxModiSeg" + ActivateNextSegment.ToString(), true)[0];
                selListbox.Enabled = true;
            
                //Label nächstes segment mit Start füllen
                Label selLabelActiveSeg = (Label)this.Controls.Find("LabelLEDfromSeg" + ActivateNextSegment.ToString(), true)[0];
                selLabelActiveSeg.Text = "Von LED " + NextLEDSegStart.ToString();
           
            if (ActiveSegment < 9)
            {
                NumericUpDown SelNumericUDNextSeg = (NumericUpDown)this.Controls.Find("NumericUDSeg" + ActivateNextSegment.ToString(), true)[0];
                SelNumericUDNextSeg.Value = LEDMax;
                SelNumericUDNextSeg.Enabled = true;
                SelNumericUDNextSeg.Minimum = NewLEDSegEnd + 5;
             }

            
            // Werte ins Array schreiben
            INICurrentSeg = ActiveSegment-1;
            ININextSeg= ActiveSegment;
            INISegCounter = INISegCounter + 1;
            //Counter Segmente erhöhen
            INIValueToFind = "SegmentControlsActive";
            INIValueToWrite = "SegmentControlsActive=" + INISegCounter.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            //Nächstes Segment auf Aktiv setzen
            INIValueToFind = "Segment" + INISegCounter + "Active";
            INIValueToWrite = "Segment" + INISegCounter + "Active=1";
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            //Aktuelles Ende auf Wert aus NumUD "NewLEDSegEnd"
            INIValueToFind = "Segment" + INICurrentSeg + "End";
            INIValueToWrite = "Segment" + INICurrentSeg + "End="+ NewLEDSegEnd.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            //Neuer Anfang auf Wert aus NumUD "NextLEDSegStart"
            INIValueToFind = "Segment" + ININextSeg + "Start";
            INIValueToWrite = "Segment" + ININextSeg + "Start="+NextLEDSegStart;
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            //Neues Ende auf LED MAx
            INIValueToFind = "Segment" + ININextSeg + "End";
            INIValueToWrite = "Segment" + ININextSeg + "End=" + LEDMax.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
                                    
            ChangeToNextTab();

            }
                
        public void DelSegment(int ActiveSegment, int ActivatePrevSegment)
        {
            //Trackbars deaktivieren
            TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
            seltrackRed.Enabled = false;
            TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
            seltrackGreen.Enabled = false;
            TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];
            seltrackBlue.Enabled = false;
            TrackBar seltrackBright = (TrackBar)this.Controls.Find("TrackBarBrightSeg" + ActiveSegment.ToString(), true)[0];
            seltrackBright.Enabled = false;
            TrackBar seltrackSpeed = (TrackBar)this.Controls.Find("TrackBarSpeedSeg" + ActiveSegment.ToString(), true)[0];
            seltrackSpeed.Enabled = false;
            //ListBox mit Modi deaktivieren
            ListBox selListbox = (ListBox)this.Controls.Find("ListBoxModiSeg" + ActiveSegment.ToString(), true)[0];
            selListbox.Enabled = false;
            PictureBox selPictureBox = (PictureBox)this.Controls.Find("PictureBoxRGBSeg" + ActiveSegment.ToString(), true)[0];
            selPictureBox.Enabled = false;

            //Prev Segmet new end = Max LED,   und aktuelles deaktivieren
            NumericUpDown SelNumericUDActive = (NumericUpDown)this.Controls.Find("NumericUDSeg" + ActiveSegment.ToString(), true)[0];
            //SelNumericUDActive.Value = 0;
            SelNumericUDActive.Enabled = false;
            Label sellabelActive = (Label)this.Controls.Find("LabelLEDfromSeg" + ActiveSegment.ToString(), true)[0];
            sellabelActive.Text = "Von LED ";
            NumericUpDown SelNumericPrevUD = (NumericUpDown)this.Controls.Find("NumericUDSeg" + ActivatePrevSegment.ToString(), true)[0];
            SelNumericPrevUD.Value = LEDMax;
            SelNumericPrevUD.Enabled = true;
            //PictureBox selPictureBoxPrev = (PictureBox)this.Controls.Find("PictureBoxRGBSeg" + ActivatePrevSegment.ToString(), true)[0];
            //selPictureBoxPrev.Enabled = true;




            if (ActiveSegment == 10)
            {
                //Controlls auf Segment 10 deaktivieren  
                Button selButtonLEDSegDel10 = (Button)this.Controls.Find("ButtonLEDSegDelSeg10", true)[0];
                selButtonLEDSegDel10.Enabled = false;
                //Conttolls auf 9 Segment aktivieren
                Button selButtonLEDSegAdd9 = (Button)this.Controls.Find("ButtonLEDSegAddSeg9", true)[0];
                selButtonLEDSegAdd9.Enabled = true;
                Button selButtonLEDSegDel9 = (Button)this.Controls.Find("ButtonLEDSegDelSeg9", true)[0];
                selButtonLEDSegDel9.Enabled = true;
                int PrePreSegment = ActivatePrevSegment - 1;
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + PrePreSegment + "Start"));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                PrevLEDSegStart = int.Parse(SplittedNameandValue[1]);
                //MinwertUD Vorvorheriges segstart + 5,
                SelNumericPrevUD.Minimum = PrevLEDSegStart + 5;

            }
            else if (ActiveSegment < 10 && ActiveSegment >2 )
            {
                //alle Controlls auf aktuellen Segment deaktivieren
                Button selButtonLEDSegDel = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActiveSegment.ToString(), true)[0];
                selButtonLEDSegDel.Enabled = false;
                Button selButtonLEDSegAdd = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActiveSegment.ToString(), true)[0];
                selButtonLEDSegAdd.Enabled = false;
                //alle Controlls auf vorherigen Segment aktivieren
                Button selButtonLEDPrevSegAdd = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActivatePrevSegment.ToString(), true)[0];
                selButtonLEDPrevSegAdd.Enabled = true;
                Button selButtonLEDSegPrevDel = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActivatePrevSegment.ToString(), true)[0];
                selButtonLEDSegPrevDel.Enabled = true;
                int PrePreSegment = ActivatePrevSegment - 1;
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + PrePreSegment + "Start"));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                PrevLEDSegStart = int.Parse(SplittedNameandValue[1]);
                //MinwertUD Vorvorheriges segstart + 5,
                SelNumericPrevUD.Minimum = PrevLEDSegStart + 5;

            }
            else if (ActiveSegment == 2)
            {
                //Controlls auf aktuellen Segment deaktivieren
                Button selButtonLEDSegDel2 = (Button)this.Controls.Find("ButtonLEDSegDelSeg2", true)[0];
                selButtonLEDSegDel2.Enabled = false;
                Button selButtonLEDSegAdd2 = (Button)this.Controls.Find("ButtonLEDSegAddSeg2", true)[0];
                selButtonLEDSegAdd2.Enabled = false;
                //Controlls auf vorherigen Segment aktivieren
                Button selButtonLEDSegAdd1 = (Button)this.Controls.Find("ButtonLEDSegAddSeg1", true)[0];
                selButtonLEDSegAdd1.Enabled = true;
            }
            
                INICurrentSeg = ActiveSegment - 1;
                INIPrevSeg = INICurrentSeg- 1 ;
                INISegCounter = INISegCounter - 1;
            
                // Werte ins Array schreiben
                INIValueToFind = "SegmentControlsActive";
                INIValueToWrite = "SegmentControlsActive=" + INISegCounter.ToString();
                sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
                INIValueToFind = "Segment" + INICurrentSeg + "Active";
                INIValueToWrite = "Segment" + INICurrentSeg + "Active=0";
                sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
                INIValueToFind = "Segment" + INICurrentSeg + "Start";
                INIValueToWrite = "Segment" + INICurrentSeg + "Start=0";
                sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
                INIValueToFind = "Segment" + INICurrentSeg + "End";
                INIValueToWrite = "Segment" + INICurrentSeg + "End=0";
                sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
                INIValueToFind = "Segment" + INIPrevSeg + "End";
                INIValueToWrite = "Segment" + INIPrevSeg + "End="+ LEDMax.ToString();
                sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;

                ChangeToPrevTab();


            // TransmitToESP(int INICurrentSeg, string ESPAction)

        }

        public void ChangeColorSelectedPanel(int ActiveSegment)
        {
            //Trackbars identifizieren
            TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegment.ToString(), true)[0];
            TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegment.ToString(), true)[0];
            TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegment.ToString(), true)[0];

            //Labels mit Werten aus Trackbar füllen und Hexwerte erzeugen
            Label sellabelRed = (Label)this.Controls.Find("LabelValueRedSeg" + ActiveSegment.ToString(), true)[0];
            sellabelRed.Text = seltrackRed.Value.ToString();
            ESPColorR = seltrackRed.Value.ToString("X2");
            Label sellabelGreen = (Label)this.Controls.Find("LabelValueGreenSeg" + ActiveSegment.ToString(), true)[0];
            sellabelGreen.Text = seltrackGreen.Value.ToString();
            ESPColorG = seltrackGreen.Value.ToString("X2");
            Label sellabelBlue = (Label)this.Controls.Find("LabelValueBlueSeg" + ActiveSegment.ToString(), true)[0];
            sellabelBlue.Text = seltrackBlue.Value.ToString();
            ESPColorB= seltrackBlue.Value.ToString("X2");
            
            //Panel identifizieren und Farbe aus Trackbar setzen
            Panel selPanel = (Panel)this.Controls.Find("PanelSeg" + ActiveSegment.ToString(), true)[0];
            selPanel.BackColor = Color.FromArgb(seltrackRed.Value, seltrackGreen.Value, seltrackBlue.Value);

            INICurrentSeg = ActiveSegment - 1;
            //RGB Werte in Listarray schreiben
            INIValueToFind = "Segment" + INICurrentSeg + "ColorR";
            INIValueToWrite = "Segment" + INICurrentSeg + "ColorR=" + seltrackRed.Value.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            INIValueToFind = "Segment" + INICurrentSeg + "ColorG";
            INIValueToWrite = "Segment" + INICurrentSeg + "ColorG=" + seltrackGreen.Value.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            INIValueToFind = "Segment" + INICurrentSeg + "ColorB";
            INIValueToWrite = "Segment" + INICurrentSeg + "ColorB=" + seltrackBlue.Value.ToString();
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            

            //Hexstring zusammenbauen
            ESPColorHex = "0x"  + ESPColorR + ESPColorG + ESPColorB;
            ESPAction = "Color=" + ESPColorHex;

            //An ESP senden
            TransmitToESP(INICurrentSeg, ESPAction);


        }
        
        public void ChangePanelBright(int ActiveSegment)
        {
            //Trackbar Helligkeit identifizieren
            TrackBar selTrackBarBright = (TrackBar)this.Controls.Find("TrackBarBrightSeg" + ActiveSegment.ToString(), true)[0];
            //Wert für Übergabe an ESP definieren
            ESPBright = selTrackBarBright.Value;
            Label selLabelBright = (Label)this.Controls.Find("LabelValueBrightSeg"+ ActiveSegment.ToString(), true)[0];
            selLabelBright.Text = ESPBright.ToString();
            
            // In Array schreiben
            INICurrentSeg = ActiveSegment - 1;
            INIValueToFind = "Segment" + INICurrentSeg + "Bright";
            INIValueToWrite = "Segment" + INICurrentSeg + "Bright=" + ESPBright;
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;

            //
            ESPAction = "Bright=" + ESPBright.ToString();
            TransmitToESP(INICurrentSeg, ESPAction);

        }

        public void ChangePanelSpeed(int ActiveSegment)
        {
            //Trackbar Geschwindigkeit identifzieren
            string SelectedTrackBarSpeed = "TrackBarSpeedSeg" + ActiveSegment.ToString();
            TrackBar selTrackBarSpeed = (TrackBar)this.Controls.Find(SelectedTrackBarSpeed, true)[0];
            //Wert für Übergabe an ESP definieren
            ESPSpeed = selTrackBarSpeed.Value;
            Label selLabelSpeed = (Label)this.Controls.Find("LabelValueSpeedSeg"+ ActiveSegment.ToString(), true)[0];
            selLabelSpeed.Text = ESPSpeed.ToString();

            INICurrentSeg = ActiveSegment - 1;
            //String für INIzusammenbauen  und ins Array schreiben
            INIValueToFind = "Segment" + INICurrentSeg + "Speed";
            INIValueToWrite = "Segment" + INICurrentSeg + "Speed=" + ESPSpeed;
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;

            ESPAction = "Speed=" + (ESPSpeed * 256).ToString();
            TransmitToESP(INICurrentSeg, ESPAction);

        }

        public void ChangeModus(int ActiveSegment)
        {

            ListBox selListbox = (ListBox)this.Controls.Find("ListBoxModiSeg"+ActiveSegment.ToString(), true)[0];
            ESPMode = selListbox.SelectedIndex;

            //Neuen Modus abfragen,
            INICurrentSeg = ActiveSegment - 1;
            //String für INIzusammenbauen
            INIValueToFind = "Segment" + INICurrentSeg + "Modus=";
            INIValueToWrite = "Segment" + INICurrentSeg + "Modus=" + ESPMode;
            //In Array schreiben
            sectionSegSet[sectionSegSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;

            ESPAction = "Modus=" + ESPMode.ToString();
            TransmitToESP(INICurrentSeg, ESPAction);
        }

        public void ChangeToNextTab()
        {
        TabSegmente.SelectedTab = TabSegmente.TabPages["TabSeg"+ ActivateNextSegment.ToString()];
        }

        public void ChangeToPrevTab()
        {
        TabSegmente.SelectedTab = TabSegmente.TabPages["TabSeg"+ ActivatePrevSegment.ToString()];
        }

        public void ReadINI(string FilenameToReadFrom)
        {
            //Handle für ini-File erzeugen
            INIFile inifile = new INIFile(FilenameToReadFrom);

            //Listarray mit Werten aus INI füllen
            sectionHWSet = inifile.GetSection("HW-Settings");
            sectionSegSet = inifile.GetSection("SegmentSettings");
            sectionModi = inifile.GetSection("Modi");

            //Config Tab befüllen  
            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("MaxLEDs"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            TextBox seltextbox = (TextBox)this.Controls.Find("TextBoxConfLEDCount", true)[0];
            seltextbox.Text = SplittedNameandValue[1];
            //Wert für LEDMAx  = MaxLEDS aus INI -1
            LEDMax = int.Parse(SplittedNameandValue[1]) -1;
            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("ComPort"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            ComboBox selcomboxCom = (ComboBox)this.Controls.Find("ComboBoxComPort", true)[0];
            selcomboxCom.Text = SplittedNameandValue[1];
            ESPCOM = SplittedNameandValue[1];

            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("ArduinoPin"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            ComboBox selcomboxESP = (ComboBox)this.Controls.Find("ComboBoxArduinoPIN", true)[0];
            selcomboxESP.Text = SplittedNameandValue[1];

            //Listbox auf Config Tab füllen
            ListBox sellistboxSource = (ListBox)this.Controls.Find("ListboxModi", true)[0];
            int modusanzahl = sectionModi.Count;
            for (int i = 0; i < modusanzahl; i++)
                {
                    sellistboxSource.Items.Add(sectionModi[i]);
                }
            //ersten Eintrag mit "Modi" löschen
            sellistboxSource.Items.RemoveAt(0);

            //Segment AddDelNumUD zu aktivieren auslesen
            SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("SegmentControlsActive="));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            int AddDelNumericUDtoActivate = int.Parse(SplittedNameandValue[1]);
            INISegCounter = AddDelNumericUDtoActivate;

            //int AddDelNumericUDtoActivate

            //Alles was geht auslesen und schreiben
            for (int i = 0; i < 10; i++)
                 {
                 int ActiveSegmet = i + 1;
                INICurrentSeg = i;

                //Modi Segmente füllen
                string Currentlistboxmodiseg = "listboxmodiseg" + ActiveSegmet.ToString();
                ListBox sellistboxCopyTo = (ListBox)this.Controls.Find("listboxmodiseg" + ActiveSegmet.ToString(), true)[0];
                sellistboxCopyTo.Items.AddRange(sellistboxSource.Items);
            
                //Modus vorbelegen
                ListBox selListbox = (ListBox)this.Controls.Find("ListBoxModiSeg" + ActiveSegmet.ToString(), true)[0];
                //Im Array Wert für Segment finden und Eintrag aktivieren
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "Modus="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                //Neuen Wert im Array setzen
                selListbox.SetSelected(int.Parse(SplittedNameandValue[1]), true);
                ChangeModus(ActiveSegment);

                //LabelLEDfromSeg befüllen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i +"Start="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                Label sellabel = (Label)this.Controls.Find("LabelLEDfromSeg" + ActiveSegmet.ToString(), true)[0];
                sellabel.Text = "Von LED " + SplittedNameandValue[1];
                if (int.Parse(SplittedNameandValue[1]) > 0)
                    {
                        OldLEDSegStart = int.Parse(SplittedNameandValue[1]);
                    }

                //NumericUD schreiben und MAx Wert setzen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i +"End="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                NumericUpDown SelNumericUD = (NumericUpDown)this.Controls.Find("NumericUDSeg" + ActiveSegmet.ToString(), true)[0];
                SelNumericUD.Value = int.Parse(SplittedNameandValue[1]);
                SelNumericUD.Maximum = LEDMax;
                
            
                //RGB Tracks füllen & Panel einfärben
                //Wert für Trackbar Rot setzen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "ColorR="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                TrackBar seltrackRed = (TrackBar)this.Controls.Find("TrackBarRedSeg" + ActiveSegmet.ToString(), true)[0];
                seltrackRed.Value = int.Parse(SplittedNameandValue[1]);

                //Wert für Trackbar Gruen setzen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "ColorG="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                TrackBar seltrackGreen = (TrackBar)this.Controls.Find("TrackBarGreenSeg" + ActiveSegmet.ToString(), true)[0];
                seltrackGreen.Value = int.Parse(SplittedNameandValue[1]);

                //Wert für Trackbar Blau setzen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "ColorB="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                TrackBar seltrackBlue = (TrackBar)this.Controls.Find("TrackBarBlueSeg" + ActiveSegmet.ToString(), true)[0];
                seltrackBlue.Value = int.Parse(SplittedNameandValue[1]);

                //Trackbar RGB,Label und Panel befüllen 
                ChangeColorSelectedPanel(ActiveSegmet);

                //Helligkeit füllen
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "Bright="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                TrackBar seltrackBright = (TrackBar)this.Controls.Find("TrackBarBrightSeg" + ActiveSegmet.ToString(), true)[0];
                seltrackBright.Value = int.Parse(SplittedNameandValue[1]);
                ChangePanelBright(ActiveSegment);

                //Trackbar Speed füllen        
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "Speed="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                TrackBar seltrackSpeed = (TrackBar)this.Controls.Find("TrackBarSpeedSeg" + ActiveSegmet.ToString(), true)[0];
                seltrackSpeed.Value = int.Parse(SplittedNameandValue[1]);
                ChangePanelSpeed(ActiveSegment);
                
                //Prüfen ob Segment aktiv ist
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i + "Active="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                int SegmentControlstoActivate = int.Parse(SplittedNameandValue[1]);


                if (SegmentControlstoActivate == 1)
                    {
                    //Controls aktivieren
                    seltrackRed.Enabled = true;
                    seltrackGreen.Enabled = true;
                    seltrackBlue.Enabled = true;
                    seltrackBright.Enabled = true;
                    seltrackSpeed.Enabled = true;
                    selListbox.Enabled = true;
                    //RGBColorPicker aktivieren
                    PictureBox selPictureBox = (PictureBox)this.Controls.Find("PictureBoxRGBSeg" + ActiveSegment.ToString(), true)[0];
                    selPictureBox.Enabled = true;
                }

                if (i == AddDelNumericUDtoActivate && i==0)
                    {
                    Button selButtonLEDSegAdd = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActiveSegmet.ToString(), true)[0];
                    selButtonLEDSegAdd.Enabled = true;
                    SelNumericUD.Enabled = true;
                    }

                else if (i == AddDelNumericUDtoActivate && i > 0 && i < 9 )
                    {
                    Button selButtonLEDSegAdd = (Button)this.Controls.Find("ButtonLEDSegAddSeg" + ActiveSegmet.ToString(), true)[0];
                    selButtonLEDSegAdd.Enabled = true;
                    Button selButtonLEDSegDel = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActiveSegmet.ToString(), true)[0];
                    selButtonLEDSegDel.Enabled = true;
                    SelNumericUD.Enabled = true;
                    }

                else if (i == AddDelNumericUDtoActivate && i == 9)
                    {
                    Button selButtonLEDSegDel = (Button)this.Controls.Find("ButtonLEDSegDelSeg" + ActiveSegmet.ToString(), true)[0];
                    selButtonLEDSegDel.Enabled = true;
                    SelNumericUD.Enabled = true;
                    }
            
            //an ESP senden
            TransmitToESP(INICurrentSeg, ESPAction);

            }
        }

        public void ChooseINI()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                FilenameToReadFrom = openfiledialog.FileName;
                }
        }

        public void WritealltoINI(string FilenameToWriteto)
        {
             INIFile inifile = new INIFile(FilenameToWriteto);

            //HW-Settings schreiben
            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("MaxLEDs"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("HW-Settings", SplittedNameandValue[0], SplittedNameandValue[1]);
            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("ComPort"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("HW-Settings", SplittedNameandValue[0], SplittedNameandValue[1]);
            SettingsNameandValuetoSplit = sectionHWSet.FirstOrDefault(s => s.Contains("ArduinoPin"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("HW-Settings", SplittedNameandValue[0], SplittedNameandValue[1]);
            

            //SegSettingings Werte schreiben die nicht durch schleife geschrieben werden
            SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("SegmentFirst"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
            SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("SegmentLast"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
            SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("SegmentCount"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
            SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("SegmentControlsActive"));
            SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
            inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
            
            //Werte der einzenlen Segmente schreiben
            for (int i=0; i<10;i++)
                {
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString()+ "Active="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "Start="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "End="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "ColorActive="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "ModusActive="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "ColorR="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "ColorG="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "ColorB="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "Speed="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "Bright="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                SettingsNameandValuetoSplit = sectionSegSet.FirstOrDefault(s => s.Contains("Segment" + i.ToString() + "Modus="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("SegmentSettings", SplittedNameandValue[0], SplittedNameandValue[1]);
                }

            //Modi in INI schreiben 

            //sectionModi
            for (int i = 0; i < sectionModi.Count-1; i++)
                {
                SettingsNameandValuetoSplit = sectionModi.FirstOrDefault(s => s.Contains("Modus" + i.ToString() + "="));
                SplittedNameandValue = SettingsNameandValuetoSplit.Split(stringSeparators, StringSplitOptions.None);
                inifile.SetValue("Modi", SplittedNameandValue[0], SplittedNameandValue[1]);
                }

        }

        public void ConfigChange(object sender, EventArgs e)
        {
            
            //HW-Settings auslesen und ins HWArray schreiben           
            TextBox seltextbox = (TextBox)this.Controls.Find("TextBoxConfLEDCount", true)[0];
            INIValueToFind = "MaxLEDs";
            INIValueToWrite = "MaxLEDs=" + seltextbox.Text;
            sectionHWSet[sectionHWSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            ComboBox selcomboxESP = (ComboBox)this.Controls.Find("ComboBoxArduinoPIN", true)[0];
            INIValueToFind = "ArduinoPin";
            INIValueToWrite = "ArduinoPin=" + selcomboxESP.Text;
            sectionHWSet[sectionHWSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            ComboBox selcomboxCom = (ComboBox)this.Controls.Find("ComboBoxComPort", true)[0];
            INIValueToFind = "ComPort";
            INIValueToWrite = "ComPort=" + selcomboxCom.Text;
            sectionHWSet[sectionHWSet.FindIndex(s => s.Contains(INIValueToFind))] = INIValueToWrite;
            ESPCOM = selcomboxCom.Text;

            //Schleife Modi auslesen und neuer werte ins Array schreiben
            ListBox sellistbox = (ListBox)this.Controls.Find("ListboxModi", true)[0];
            //Array leeren
            sectionModi.Clear();   
            //Segtion für ini anlegen
            sectionModi.Add("[Modi]");
            for (int i = 0; i < sellistbox.Items.Count; i++)
                {
                sectionModi.Add(sellistbox.Items[i].ToString());
                }

        }

     }
}
 