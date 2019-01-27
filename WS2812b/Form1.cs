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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //show list of valid com ports
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                ComboBoxComPort.Items.Add(s);
            }
        
        }

        private void ChangePanelColor(object sender, EventArgs e)
        {
            // Panel mit der Hintergrundfarbe aus den eingestellten RGB Werten fülen

        PanelSeg1.BackColor = Color.FromArgb(TrackBarRedSeg1.Value, TrackBarGreenSeg1.Value, TrackBarBlueSeg1.Value);

            //Hinter den Schieberegler die Werte schreiben
            LabelValueRedSeg1.Text = TrackBarRedSeg1.Value.ToString();
            LabelValueGreenSeg1.Text = TrackBarGreenSeg1.Value.ToString();
            LabelValueBlueSeg1.Text = TrackBarBlueSeg1.Value.ToString();

        }

    }
}
