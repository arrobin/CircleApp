using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp2
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }

        Circle aCircle = new Circle();

        private void diameterButton_Click(object sender, EventArgs e)
        {
            resultLebel.Text = "Diameter";
            aCircle.radius = Convert.ToDouble(rediustTextBox.Text);
            resultTextBox.Text = aCircle.CalculateDiameter().ToString();
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            resultLebel.Text = "Perimeter";
            aCircle.radius = Convert.ToDouble(rediustTextBox.Text);
            resultTextBox.Text = aCircle.CalculatePerimeter().ToString();
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            resultLebel.Text = "Area";
            aCircle.radius = Convert.ToDouble(rediustTextBox.Text);
            resultTextBox.Text = aCircle.CalculateArea().ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            rediustTextBox.Clear();
            resultTextBox.Clear();
            resultLebel.Text = "Result";

        }
        
    }
}
