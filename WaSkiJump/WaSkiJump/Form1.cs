using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Drawing.Printing;

namespace WaSkiJump
{
    public partial class MainForm1 : Form
    { // public Form

        // public Form2 resultfile = null;






        public MainForm1()
        {
            InitializeComponent();




            // Calculate Wind average

            //static float CalculateWindAverage (lkm)
            //  {
            //      float wind = 0;
            //      float sum = 0;
            //      float average = 0;
            //      int lkm = 0;

            //      do
            //      {
            //          if (wind >= 0)
            //          {
            //              sum = sum + wind;
            //              lkm = lkm + 1;

            //          }




            //      } while (wind >= 0);


            //      if (lkm > 0)
            //          average = sum / lkm;

            //      else average = 0;

        //}
          
        //    }



        }

        private void BtnStartJump_Click(object sender, EventArgs e)
        {
            // Calculate points


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void JudgPointsTxb_TextChanged(object sender, EventArgs e)
        {
            // show Judges points
            //example 2x 18p 3x20 =58points ( lowest and highest point no )

        }

        private void LenghtTxb_TextChanged(object sender, EventArgs e)
        {
            // Jump Lenght
        }

        private void OverallTxb_TextChanged(object sender, EventArgs e)
        {
            //Overall 
        }

        private void SkiJumpreTxb_TextChanged(object sender, EventArgs e)
        {
            // Finaly result
        }
    }
}
