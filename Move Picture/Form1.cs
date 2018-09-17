﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.X < ClientRectangle.Width - pictureBox1.Width)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);
			}
		}
       

        private void btnUp_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.Y > 0)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);
			}
		}
        

        private void btnDown_Click(object sender, EventArgs e)
		{
	         if(pictureBox1.Location.Y < ClientRectangle.Height - pictureBox1.Height)
			{
					pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
			}
		}

        private void btnLeft_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.X > 0)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 20, pictureBox1.Location.Y);
			}
		}
        

	}
}
