using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_02_WindowsFormsApplication_spaceship
{
    public partial class Form1 : Form
    {

        Spaceship oddesey = new Spaceship();
        public Form1()
        {
            InitializeComponent();
            oddesey.setXY(640-(picturBox_spaceship01.Size.Width/2), 360-(picturBox_spaceship01.Size.Height / 2));
            picturBox_spaceship01.Location = new Point(oddesey.spaceX, oddesey.spaceY);
            FPS.Start();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            oddesey.spaceX -= 10;
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            oddesey.spaceX += 10;
        }
        private void button_up_Click(object sender, EventArgs e)
        {
            oddesey.spaceY -= 10;
        }
        private void button_down_Click(object sender, EventArgs e)
        {
            oddesey.spaceY += 10;
        }
        private void FPS_Tick(object sender, EventArgs e)
        {
            picturBox_spaceship01.Location = new Point(oddesey.spaceX, oddesey.spaceY);
        }


    }
    public class Spaceship
    {
        public int spaceX;
        public int spaceY;
        public string spaceRotation = "right"; //up,down,left,right
        public Spaceship()
        {

        }

        public void setXY(int midX, int midY)
        {
            this.spaceX = midX;
            this.spaceY = midY;
        }
    }
}
