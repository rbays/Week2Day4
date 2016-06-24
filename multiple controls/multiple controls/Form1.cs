using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiple_controls
{
    public partial class Form1 : Form
    {
        List<int> vectors = new List<int> { };
        Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();  
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            vectors = new List<int> { };
            foreach (Label label in groupBox1.Controls)
            {
                vectors.Add(randomizer.Next(-5, 5));
                vectors.Add(randomizer.Next(-5, 5));
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Label label in groupBox1.Controls)
            {
                
                if (!(label.Location.X + vectors[i] > 0 && label.Location.X + vectors[i] < groupBox1.Width - label.Width))
                {
                    vectors[i] = -vectors[i];
                 }

                if (!(label.Location.Y + vectors[i+1] > 0 && label.Location.Y + vectors[i+1] < groupBox1.Height - label.Height))
                {
                    vectors[i + 1] = -vectors[i + 1];
                }

                int xcoord = label.Location.X + vectors[i];
                int ycoord = label.Location.Y + vectors[i + 1];

                label.Location = new Point(xcoord, ycoord);

                i += 2;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
