using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            int a = int.Parse(lenghttextbox.Text.ToString());
            int b = int.Parse(widthtextBox.Text.ToString());
            Pen pen = new Pen(Color.Blue, 5);
            Point[] points =
             {
                 new Point(70, 70),
                 new Point(a+70, 70),
                 new Point(a+70, b+70),
                 new Point(70, b+70),
                 new Point(70, 70)
             };
            e.Graphics.DrawLines(pen, points);
        }

        private void rectanglebutton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Paint()
        {
        }

        private void rectanglebutton_Click_1(object sender, EventArgs e)
        {
        }
    }
}