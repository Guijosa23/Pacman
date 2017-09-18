using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics onScreen = this.CreateGraphics(); //Sets up on-screen graphics
            Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen
            Graphics offScreen = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 6);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            formGraphics.FillPie(drawBrush, 20, 20, 52, 52, 30, 300);

            offScreen.DrawEllipse(Pens.White, 180, 130, 300, 300);
            offScreen.DrawEllipse(Pens.White, 322, 275, 16, 16);
            offScreen.DrawLine(Pens.White, 325, 153, 325, 275);
            offScreen.DrawLine(Pens.White, 335, 153, 335, 275);
         

        }
    }
}
