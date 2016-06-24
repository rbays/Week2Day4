using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textOutputBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog backColorDiag = new ColorDialog();
            if (backColorDiag.ShowDialog() == DialogResult.OK)
            {
                textOutputBox.BackColor = backColorDiag.Color;
            }
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog textColorDiag = new ColorDialog();
            if (textColorDiag.ShowDialog() == DialogResult.OK)
            {
                textOutputBox.ForeColor = textColorDiag.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nextForm = new Form2();
            nextForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
