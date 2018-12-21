using Assignment_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class Form1 : Form
    {
        Guide guide = new Guide();
        public Form1()
        {
            InitializeComponent();
            guide.InitLines();
            initComboBoxes();
        }

        public void initComboBoxes()
        {
            foreach(Line line in guide.Lines)
            {
                comboBox1.Items.Add(line.Name);
                comboBox4.Items.Add(line.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startLineChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "Select a station";
            comboBox2.Items.Clear();
            Line line = guide.Lines[comboBox1.SelectedIndex];
            foreach(Station station in line.Stations)
            {
                comboBox2.Items.Add(station.StationName);
            }
        }

        private void endLineChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "Select a station";
            comboBox3.Items.Clear();
            Line line = guide.Lines[comboBox4.SelectedIndex];
            foreach (Station station in line.Stations)
            {
                comboBox3.Items.Add(station.StationName);
            }
        }
    }
}
