using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS2812b
{
    public partial class FormWS812 : Form
    {

        public void PanelColorChange(string SegNumber)
            /*Erster Veruch, aber keine Übergabe eines Wertes,
             hier sollte eine Methode entstehen, die einen numerischen Wert des aktuellen 
             Segmentes entgegen nimmt und diesen dann verarbeitet
             */
             
        {
            string RGBPanel = "PanelSeg" + SegNumber;
            string TrackBarRed = "TrackBarRedSeg" + SegNumber;
            string TrackBarGreen = "TrackBarGreenSeg" + SegNumber;
            string TrackBarBlue = "TrackBarBlueSeg" + SegNumber;
            string LabelRed = "LabelValueRedSeg" + SegNumber;
            string LabelGreen = "LabelValueGreenSeg" + SegNumber;
            string LabelBlue = "LabelValueBlueSeg" + SegNumber;


            /*
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            RGBPanel.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelRed.Text = TrackBarRed.Value.ToString();
            LabelGreen.Text = TrackBarGreen.Value.ToString();
            LabelBlue.Text = TrackBarBlue.Value.ToString();
            */
        }

        public void ChangeColorSelectedPanel(string selPanel, string selTrackR, string selTrackG, string selTrackB)
        {

            /*2. Veruch mit der Find funktion von Daniel
            //Auswal der Übergebenden Trackbars
            TrackBar selectedTrackBarRed = (TrackBar).Controls.Find(selTrackR,false);
            TrackBar selectedTrackBarGed = (TrackBar).Controls.Find(selTrackG,false);
            TrackBar selectedTrackBarBed = (TrackBar).Controls.Find(selTrackB,false);

            //Auswahl des Übergebenden Panels
            Panel selectedPanel = (Panel)Controls.Find(selPanel,false);
            //Panelbackgroundfarbe mit den ubergebenden RGB Werten schrieben
            selectedPanel.BackColor = Color.Color.FromArgb(selectedTrackBarRed.Value, selectedTrackBarGed.Value, selectedTrackBarBed.Value);
            */
            



            // Panel selPanel = (Panel)this.Controls.Find(PanelSeg1.Value, false)[0];
            //selPanel.BackColor = Color.Green;
            

        }



                public FormWS812()
        {
            InitializeComponent();

            //show list of valid com ports
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComboBoxComPort.Items.Add(s);
            }
        }




            

        private void ChangePanelColorSeg1(object sender, EventArgs e)
        {
            
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg1.BackColor = Color.FromArgb(TrackBarRedSeg1.Value, TrackBarGreenSeg1.Value, TrackBarBlueSeg1.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg1.Text = TrackBarRedSeg1.Value.ToString();
            LabelValueGreenSeg1.Text = TrackBarGreenSeg1.Value.ToString();
            LabelValueBlueSeg1.Text = TrackBarBlueSeg1.Value.ToString();

            PanelColorChange("1");
            
        }

        private void ChangePanelColorSeg2(object sender, EventArgs e)
        {
         // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
         PanelSeg2.BackColor = Color.FromArgb(TrackBarRedSeg2.Value, TrackBarGreenSeg2.Value, TrackBarBlueSeg2.Value);
         //Hinter den Schieberegler die Werte schreiben
         LabelValueRedSeg2.Text = TrackBarRedSeg2.Value.ToString();
         LabelValueGreenSeg2.Text = TrackBarGreenSeg2.Value.ToString();
         LabelValueBlueSeg2.Text = TrackBarBlueSeg2.Value.ToString();
        }

        private void ChangePanelColorSeg3(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg3.BackColor = Color.FromArgb(TrackBarRedSeg3.Value, TrackBarGreenSeg3.Value, TrackBarBlueSeg3.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg3.Text = TrackBarRedSeg3.Value.ToString();
            LabelValueGreenSeg3.Text = TrackBarGreenSeg3.Value.ToString();
            LabelValueBlueSeg3.Text = TrackBarBlueSeg3.Value.ToString();
        }

        private void ChangePanelColorSeg4(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg4.BackColor = Color.FromArgb(TrackBarRedSeg4.Value, TrackBarGreenSeg4.Value, TrackBarBlueSeg4.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg4.Text = TrackBarRedSeg4.Value.ToString();
            LabelValueGreenSeg4.Text = TrackBarGreenSeg4.Value.ToString();
            LabelValueBlueSeg4.Text = TrackBarBlueSeg4.Value.ToString();
        }

        private void ChangePanelColorSeg5(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg5.BackColor = Color.FromArgb(TrackBarRedSeg5.Value, TrackBarGreenSeg5.Value, TrackBarBlueSeg5.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg5.Text = TrackBarRedSeg5.Value.ToString();
            LabelValueGreenSeg5.Text = TrackBarGreenSeg5.Value.ToString();
            LabelValueBlueSeg5.Text = TrackBarBlueSeg5.Value.ToString();
        }

        private void ChangePanelColorSeg6(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg6.BackColor = Color.FromArgb(TrackBarRedSeg6.Value, TrackBarGreenSeg6.Value, TrackBarBlueSeg6.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg6.Text = TrackBarRedSeg6.Value.ToString();
            LabelValueGreenSeg6.Text = TrackBarGreenSeg6.Value.ToString();
            LabelValueBlueSeg6.Text = TrackBarBlueSeg6.Value.ToString();
        }

        private void ChangePanelColorSeg7(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg7.BackColor = Color.FromArgb(TrackBarRedSeg7.Value, TrackBarGreenSeg7.Value, TrackBarBlueSeg7.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg7.Text = TrackBarRedSeg7.Value.ToString();
            LabelValueGreenSeg7.Text = TrackBarGreenSeg7.Value.ToString();
            LabelValueBlueSeg7.Text = TrackBarBlueSeg7.Value.ToString();
        }

        private void ChangePanelColorSeg8(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg8.BackColor = Color.FromArgb(TrackBarRedSeg8.Value, TrackBarGreenSeg8.Value, TrackBarBlueSeg8.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg8.Text = TrackBarRedSeg8.Value.ToString();
            LabelValueGreenSeg8.Text = TrackBarGreenSeg8.Value.ToString();
            LabelValueBlueSeg8.Text = TrackBarBlueSeg8.Value.ToString();
        }

        private void ChangePanelColorSeg9(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg9.BackColor = Color.FromArgb(TrackBarRedSeg9.Value, TrackBarGreenSeg9.Value, TrackBarBlueSeg9.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg9.Text = TrackBarRedSeg9.Value.ToString();
            LabelValueGreenSeg9.Text = TrackBarGreenSeg9.Value.ToString();
            LabelValueBlueSeg9.Text = TrackBarBlueSeg9.Value.ToString();
        }

        private void ChangePanelColorSeg10(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen
            PanelSeg10.BackColor = Color.FromArgb(TrackBarRedSeg10.Value, TrackBarGreenSeg10.Value, TrackBarBlueSeg10.Value);
            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg10.Text = TrackBarRedSeg10.Value.ToString();
            LabelValueGreenSeg10.Text = TrackBarGreenSeg10.Value.ToString();
            LabelValueBlueSeg10.Text = TrackBarBlueSeg10.Value.ToString();
        }
    }
}
