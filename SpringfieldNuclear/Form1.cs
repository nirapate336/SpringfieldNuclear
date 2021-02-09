using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
         
            //change backround colour and text
            this.BackColor = Color.Gray;
            outputLabel.Text = "Meltdown Iminent";
            //'
            //change colour of green labels
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;

            //change flashing colour of the label
            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            
            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);



        }
    }
}
