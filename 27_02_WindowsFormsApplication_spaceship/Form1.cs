using _27_02_WindowsFormsApplication_spaceship.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _27_02_WindowsFormsApplication_spaceship
{
    public partial class Form1 : Form
    {
        Spaceship oddesey = new Spaceship();

        public Form1()
        {
            InitializeComponent();
            oddesey.setXY(640 - (picturBox_spaceship01.Size.Width / 2), 360 - (picturBox_spaceship01.Size.Height / 2));
            picturBox_spaceship01.SizeMode = PictureBoxSizeMode.Zoom;
            picturBox_spaceship01.Location = new Point(oddesey.spaceX, oddesey.spaceY);
            FPS.Start();
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            oddesey.spaceX -= 10;
            rotateShip("right");
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            oddesey.spaceX += 10;
            rotateShip("left");
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            oddesey.spaceY -= 10;
            rotateShip("up");
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            oddesey.spaceY += 10;
            rotateShip("down");
        }

        private void FPS_Tick(object sender, EventArgs e)
        {
            picturBox_spaceship01.Location = new Point(oddesey.spaceX, oddesey.spaceY);
        }

        public void rotateShip(string targetDirection)
        {
            if (oddesey.spaceRotation == targetDirection) 
                return;

            while (oddesey.spaceRotation != targetDirection)
            {
                Image flip = (Image)picturBox_spaceship01.BackgroundImage.Clone();
                flip.RotateFlip(RotateFlipType.Rotate90FlipNone);
                picturBox_spaceship01.BackgroundImage = flip;

                oddesey.currentDirectionIndex = (oddesey.currentDirectionIndex + 1) % oddesey.directions.Length;
                oddesey.spaceRotation = oddesey.directions[oddesey.currentDirectionIndex];
            }
        }
    }

    public class Spaceship
    {
        public int spaceX;
        public int spaceY;
        public string spaceRotation = "right"; 
        public int currentDirectionIndex = 2;  
        public string[] directions = { "left", "down", "right", "up" };

        public Spaceship() { }

        public void setXY(int midX, int midY)
        {
            this.spaceX = midX;
            this.spaceY = midY;
        }
    }
}
