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
        Spaceship oddesey = new Spaceship(640,360);
        
        public Form1()
        {
            InitializeComponent();
            picturBox_spaceship01.Location = new Point(oddesey.spaceX, oddesey.spaceY);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            int x = picturBox_spaceship01.Location.X;
            int y = picturBox_spaceship01.Location.Y;
            picturBox_spaceship01.Location = new Point(x-10, y);
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            int x = picturBox_spaceship01.Location.X;
            int y = picturBox_spaceship01.Location.Y;
            picturBox_spaceship01.Location = new Point(x + 10, y);

        }
    }
    public class Spaceship
    {
        public int spaceX;
        public int spaceY;
        public Spaceship(int midX, int mixY)
        {
            this.spaceX = midX;
            this.spaceY = mixY;
        }
    }
}
