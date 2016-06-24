using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orbit
{
    public partial class Form1 : Form
    {
        Point sunLocation;
        Point planetLocation;
        //set initial velocity for planet
        int pVelX = 7;
        int pVelY = 7;

        //set gravity strength unknown power currently
        int grav = 10000;

        int sunLocationX;
        int sunLocationY;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //set sun location
            sunLocationX = sunLabel.Location.X + (sunLabel.Width) / 2;
            sunLocationY = sunLabel.Location.Y + (sunLabel.Height) / 2;
            Point sunLocation = new Point(sunLocationX, sunLocationY);


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                //find current planet location
                int planetLocationX = planetLabel.Location.X + (planetLabel.Width) / 2;
                int planetLocationY = planetLabel.Location.Y + (planetLabel.Height) / 2;
                Point planetLocation = new Point(planetLocationX, planetLocationY);

                //find current distance squared
                int distanceX = sunLocationX - planetLocationX;
                int distanceY = sunLocationY - planetLocationY;
                distanceXLabel.Text = distanceX.ToString();
                distanceYLabel.Text = distanceY.ToString();


                int distanceSqrd = (distanceX * distanceX) + (distanceY * distanceY);
                //set current acceleration
                float acceleration = grav / distanceSqrd;
                //set acceleration direction, angle starts with left as 0 and goes up to 2 Pi
                double angle;
                if (distanceX == 0)
                {
                    angle = Math.PI;
                }
                else if (distanceX > 0)
                {
                    angle = Math.Atan((double)distanceY / (double)distanceX);
                    if (angle < 0)
                    {
                        angle += (double)2 * Math.PI;
                    }
                }
                else
                {
                    angle = Math.Atan(distanceY / distanceX) + Math.PI;
                }
                AngleLabel.Text = angle.ToString();

                //set acceleration in x and y cartesian vectors
                double accelX = acceleration * Math.Cos(angle);
                double accelY = acceleration * Math.Sin(angle);
                accelerationX.Text = accelX.ToString();
                accelerationY.Text = accelY.ToString();

                //set planet velocity
                pVelX += (Int32)Math.Round(accelX);
                pVelY += (Int32)Math.Round(accelY);
                velocityX.Text = pVelX.ToString();
                velocityY.Text = pVelY.ToString();



                //Set new planet location
                int oldX = planetLabel.Location.X;
                int oldY = planetLabel.Location.Y;
                int newX = oldX + pVelX;
                int newY = oldY + pVelY;
                planetLabel.Location = new Point(newX, newY);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("You crashed into the sun");
            }
        }
    }
}
