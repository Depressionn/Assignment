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
    public partial class AssignmentForm : Form
    {
		private List<Line> lines = new List<Line>();
        public AssignmentForm()
        {
            InitializeComponent();
        }

        public void initComboBoxes()
        {
            foreach(Line line in lines)
            {
                comboStartLine.Items.Add(line.Name);
                comboEndLine.Items.Add(line.Name);
            }
        }//fill up the combo box lists

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
			txtInputStartManual.Text = "";
            comboStartStation.Text = "Select a station";
            comboStartStation.Items.Clear();
            Line line = lines[comboStartLine.SelectedIndex];
            foreach(Station station in line.Stations)
            {
                comboStartStation.Items.Add(station.StationName);
            }
        }

        private void endLineChanged(object sender, EventArgs e)
        {
			txtInputEndManual.Text = "";
            comboEndStation.Text = "Select a station";
            comboEndStation.Items.Clear();
            Line line = lines[comboEndLine.SelectedIndex];
            foreach (Station station in line.Stations)
            {
                comboEndStation.Items.Add(station.StationName);
            }
        }

		private void Form1_Load(object sender, EventArgs e) {
			InitLines a = new InitLines(@"MRT.txt");
			lines = a.Lines;
			initComboBoxes();
		}

		private void txtInputManual_TextChanged(object sender, EventArgs e) {
			string input = txtInputStartManual.Text;
			InputToStation temp = new InputToStation(input, lines);
			Station referencedStation = temp.ReferencedStation;
			//when text changed, get the correct station
			if(temp.ReferencedStation == null) {
				comboStartLine.Text = "Unknown";
				comboStartStation.Text = "Unknown";
				return;
			}//if unknown

			//change line and station combo box 
			if (referencedStation.Junction) {
				List<string> linesBelongingTo = new List<string>();
				referencedStation.getLines().ForEach(x => linesBelongingTo.Add(x.Name));
				string txt = linesBelongingTo[0];
				for(int count = 1; count <= linesBelongingTo.Count() - 1; count++) 
					txt += " & " + linesBelongingTo[count];
				comboStartLine.Text = txt;
				comboStartStation.Text = referencedStation.StationName;
			}else {
				comboStartLine.Text = referencedStation.LineBelong.Name;
				comboStartStation.Text = referencedStation.StationName;		
			}


		}

		private void txtEndManualInput_TextChanged(object sender, EventArgs e) {
			string input = txtInputEndManual.Text;
			InputToStation temp = new InputToStation(input, lines);
			Station referencedStation = temp.ReferencedStation;
			//when text changed, get the correct station
			if (temp.ReferencedStation == null) {
				comboEndLine.Text = "Unknown";
				comboEndStation.Text = "Unknown";
				return;
			}//if unknown

			//change line and station combo box 
			if (referencedStation.Junction) {
				List<string> linesBelongingTo = new List<string>();
				referencedStation.getLines().ForEach(x => linesBelongingTo.Add(x.Name));
				string txt = linesBelongingTo[0];
				for (int count = 1; count <= linesBelongingTo.Count() - 1; count++)
					txt += " & " + linesBelongingTo[count];
				comboEndLine.Text = txt;
				comboEndStation.Text = referencedStation.StationName;
			}
			else {
				comboEndLine.Text = referencedStation.LineBelong.Name;
				comboEndStation.Text = referencedStation.StationName;
			}

		}


		//make it moveable
		private int xCord = 0, yCord = 0;
		private bool clicking = false;
		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void panelTop_MouseDown(object sender, MouseEventArgs e) {
			clicking = true;
			xCord = e.X;
			yCord = e.Y;
		}//when mouse clicking

		private void panelTop_MouseUp(object sender, MouseEventArgs e) {
			clicking = false;
		}//when mouse not clicking anymore

		private void panelTop_MouseMove(object sender, MouseEventArgs e) {
			if (clicking) 
				this.SetDesktopLocation(MousePosition.X - xCord, MousePosition.Y - yCord);
			//if it is clicking
			//minus needed so that form moves with the mouse
		}//when mouse move
	}
}
