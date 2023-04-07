using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Drawing2D
{
    public partial class Form1 : Form
    {
        Bitmap poli;
        Point2D p2d = new Point2D();

        Polygon poly = new Polygon();
        public Form1()
        {
            InitializeComponent();
            poli = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = poli;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label6.Text = Convert.ToString("P(" + p2d.x + "," + p2d.y + ")");
                textBox1.Text = Convert.ToString(p2d.x);
                textBox2.Text = Convert.ToString(p2d.y);
            }
            else
            {
                label6.Text = ("P(" + textBox1.Text + "," + textBox2.Text + ")");
                p2d.x = Convert.ToInt32(textBox1.Text);
                p2d.y = Convert.ToInt32(textBox2.Text);
            }
            
            if (textBox4.Text == "")
            {
                
                textBox4.Text = Convert.ToString(poly.mLength);
            }
            else
            {
                
                poly.mLength = Convert.ToInt32(textBox4.Text);
            }
            
            poly.mNofEdges = Convert.ToInt32(textBox5.Text);
            Polygon eray = new Polygon();
            poli = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = poli;

            eray.mLength = Convert.ToInt32(textBox4.Text);
            eray.mNofEdges = Convert.ToInt32(textBox5.Text);
            eray.mCenter.x = Convert.ToInt32(textBox1.Text);
            eray.mCenter.y = Convert.ToInt32(textBox2.Text);

            Pen pen = new Pen(Color.Black, 4);
            Graphics g = Graphics.FromImage(poli);
            g.DrawLines(pen, eray.calculateEdgeCoordinate());
            g.DrawLine(pen, eray.calculateEdgeCoordinate()[0], eray.calculateEdgeCoordinate()[eray.mNofEdges - 1]);
            pictureBox1.Image = poli;
            g.Dispose();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}

