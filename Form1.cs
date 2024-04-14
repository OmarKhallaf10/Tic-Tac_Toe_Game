using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
      

        string[] imagePaths = {
    @"G:\Images\O.png",
    @"G:\Images\X.png"
};
        
       
        public Form1()
        {
            InitializeComponent();

           
        }

        static int GenerateRandomNumber(int min=0, int max=1)
        {
            Random random = new Random();
            return random.Next(min, max + 1); // The "+1" ensures that the maximum value is inclusive
        }

        private string LoadRandomPathImage()
        {

            return imagePaths[GenerateRandomNumber()];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color whi = Color.White;

            Pen pen = new Pen(whi);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Draw Vertical Lines
            e.Graphics.DrawLine(pen, 450, 380, 950, 380);
            e.Graphics.DrawLine(pen, 450, 200, 950, 200);

            //Draw Horizontial Lines
            e.Graphics.DrawLine(pen,610, 50, 610, 540);
            e.Graphics.DrawLine(pen, 800, 50, 800, 540);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb4.Tag == "Question")
            {
                pb4.Image = Image.FromFile(LoadRandomPathImage());
                pb4.Tag = "Changed";
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb3.Tag == "Question")
            {
                pb3.Image = Image.FromFile(LoadRandomPathImage());
                pb3.Tag = "Changed";
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
          
            if(pb1.Tag == "Question")
            {
                pb1.Tag = "Changed";
                pb1.Image = Image.FromFile(LoadRandomPathImage());
               
            }
            else
            {
                MessageBox.Show("Can't change");
            }
               
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (pb2.Tag == "Question")
            {
                pb2.Tag = "Changed";
                pb2.Image = Image.FromFile(LoadRandomPathImage());
                
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb5.Tag == "Question")
            {
                pb5.Tag = "Changed";
                pb5.Image = Image.FromFile(LoadRandomPathImage());
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb6.Tag == "Question")
            {
                pb6.Tag = "Changed";
                pb6.Image = Image.FromFile(LoadRandomPathImage());
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (pb9.Tag == "Question")
            {
                pb9.Tag = "Changed";
                pb9.Image = Image.FromFile(LoadRandomPathImage());
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {

            if (pb8.Tag == "Question")
            {
                pb8.Tag = "Changed";
                pb8.Image = Image.FromFile(LoadRandomPathImage());
            }
            else
            {
                MessageBox.Show("Can't change");
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (pb7.Tag == "Question")
            {
                pb7.Tag = "Changed";
                pb7.Image = Image.FromFile(LoadRandomPathImage());
            }
            else
            {
                MessageBox.Show("Can't change");
            }

        }
    }
}
