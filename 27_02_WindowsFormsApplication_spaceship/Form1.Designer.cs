namespace _27_02_WindowsFormsApplication_spaceship
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picturBox_spaceship01 = new System.Windows.Forms.PictureBox();
            this.button_up = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.FPS = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturBox_spaceship01)).BeginInit();
            this.SuspendLayout();
            // 
            // picturBox_spaceship01
            // 
            this.picturBox_spaceship01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturBox_spaceship01.BackColor = System.Drawing.Color.Transparent;
            this.picturBox_spaceship01.BackgroundImage = global::_27_02_WindowsFormsApplication_spaceship.Properties.Resources.leftspaceship;
            this.picturBox_spaceship01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturBox_spaceship01.Location = new System.Drawing.Point(484, 184);
            this.picturBox_spaceship01.Name = "picturBox_spaceship01";
            this.picturBox_spaceship01.Size = new System.Drawing.Size(270, 270);
            this.picturBox_spaceship01.TabIndex = 0;
            this.picturBox_spaceship01.TabStop = false;
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(600, 541);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(41, 40);
            this.button_up.TabIndex = 1;
            this.button_up.Text = "▲";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(641, 583);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(41, 40);
            this.button_right.TabIndex = 2;
            this.button_right.Text = "►";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(557, 583);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(41, 40);
            this.button_left.TabIndex = 3;
            this.button_left.Text = "◄";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(600, 626);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(41, 40);
            this.button_down.TabIndex = 4;
            this.button_down.Text = "▼";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // FPS
            // 
            this.FPS.Interval = 10;
            this.FPS.Tick += new System.EventHandler(this.FPS_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_27_02_WindowsFormsApplication_spaceship.Properties.Resources.R1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.picturBox_spaceship01);
            this.Name = "Form1";
            this.Text = "Spaceship";
            ((System.ComponentModel.ISupportInitialize)(this.picturBox_spaceship01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturBox_spaceship01;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Timer FPS;
    }
}

