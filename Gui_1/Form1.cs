using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_1 {
	public partial class Assignment : Form {
		private List<Line> lines = new List<Line>();
		private Station startingStation = null, endingStation = null;

		public Assignment() {
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e) {
			lblCurrent.Location = btnStart.Location;
			panelEnd.SendToBack();
			panelDirections.SendToBack();
			startPanel.BringToFront();
			//send start panel to front
		}

		private void btnEnd_Click(object sender, EventArgs e) {
			lblCurrent.Location = btnEnd.Location;
			startPanel.SendToBack();
			panelDirections.SendToBack();
			panelEnd.BringToFront();
			//send end panel to front
		}

		private void btnDirections_Click(object sender, EventArgs e) {
			lblCurrent.Location = btnDirections.Location;
			startPanel.SendToBack();
			panelEnd.SendToBack();
			panelDirections.BringToFront();
			//send directions panel to front

			//no starting station
			if (startingStation != null)
				txtDisplayStartStation.Text = startingStation.StationName;
			else
				txtDisplayStartStation.Text = "Unknown";

			//no ending station
			if (endingStation != null)
				txtDisplayEnd.Text = endingStation.StationName;
			else
				txtDisplayEnd.Text = "Unknown";
			
			//reset box
			txtDisplayPath.Text = "";

			if(startingStation != null & endingStation != null) {
				string text = "";
				Path output = new Path(startingStation, endingStation);
				for(int count = 0; count <= output.CompletePath.Count() - 1; count++) {
					text += output.CompletePath[count].StationName + "\r\n";
				}
				txtDisplayPath.Text = text;
			}
			
		}

		private void btnExit_Click(object sender, EventArgs e) {
			Application.Exit();
			//stops application
		}

		private void txtInputStart_TextChanged(object sender, EventArgs e) {
			//reset box text
			txtStartStationName.Text = "";
			txtStartingID.Text = "";

			string input = txtInputStart.Text;
			InputToStation start = new InputToStation(input, lines);

			if (start.ReferencedStation == null) { 
				txtStartStationName.Text = "Unknown";
				txtStartingID.Text = "Unknown";
				startingStation = null;
				return;
			}
			string text = "";
			txtStartStationName.Text = start.ReferencedStation.StationName;
			startingStation = start.ReferencedStation;
			if (start.ReferencedStation.Junction) {	//if junction
				List<Line> linesBelong = start.ReferencedStation.getLines();
				List<int> stationNumbers = start.ReferencedStation.getStationNumbers();
				for(int count = 0; count <= linesBelong.Count() - 1; count++) {
					text += linesBelong[count].Id + stationNumbers[count] + "\r\n";
				}
				txtStartingID.Text = text;
			}
			else {  //not junction
				txtStartingID.Text = start.ReferencedStation.LineBelong.Id + start.ReferencedStation.StationNumber;		
			}
		}//when starting station changed

		private void btnGoEnd_Click(object sender, EventArgs e) {
			lblCurrent.Location = btnEnd.Location;
			startPanel.SendToBack();
			panelDirections.SendToBack();
			panelEnd.BringToFront();
			//send end panel to front
		}

		private void txtEndStationInput_TextChanged(object sender, EventArgs e) {
			//reset box text
			txtEndStationName.Text = "";
			txtEndStationID.Text = "";

			string input = txtEndStationInput.Text;
			InputToStation end = new InputToStation(input, lines);

			if (end.ReferencedStation == null) {
				txtEndStationName.Text = "Unknown";
				txtEndStationID.Text = "Unknown";
				endingStation = null;
				return;
			}
			string text = "";
			txtEndStationName.Text = end.ReferencedStation.StationName;
			endingStation = end.ReferencedStation;
			if (end.ReferencedStation.Junction) { //if junction
				List<Line> linesBelong = end.ReferencedStation.getLines();
				List<int> stationNumbers = end.ReferencedStation.getStationNumbers();
				for (int count = 0; count <= linesBelong.Count() - 1; count++) {
					text += linesBelong[count].Id + stationNumbers[count] + "\r\n";
				}
				txtEndStationID.Text = text;
			}
			else {  //not junction
				txtEndStationID.Text = end.ReferencedStation.LineBelong.Id + end.ReferencedStation.StationNumber;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			lblCurrent.Location = btnDirections.Location;
			startPanel.SendToBack();
			panelEnd.SendToBack();
			panelDirections.BringToFront();
			//send directions panel to front

			//no starting station
			if (startingStation != null)
				txtDisplayStartStation.Text = startingStation.StationName;
			else
				txtDisplayStartStation.Text = "Unknown";

			//no ending station
			if (endingStation != null)
				txtDisplayEnd.Text = endingStation.StationName;
			else
				txtDisplayEnd.Text = "Unknown";

			//reset box
			txtDisplayPath.Text = "";

			if (startingStation != null & endingStation != null) {
				string text = "";
				Path output = new Path(startingStation, endingStation);
				for (int count = 0; count <= output.CompletePath.Count() - 1; count++) {
					text += output.CompletePath[count].StationName + "\r\n";
				}
				txtDisplayPath.Text = text;
			}

		}

		private void Assignment_Load(object sender, EventArgs e) {
			InitLines a = new InitLines(@"MRT.txt");
			lines = a.Lines;
			//init lines
			lblCurrent.Location = btnStart.Location;
			panelEnd.SendToBack();
			panelDirections.SendToBack();
			startPanel.BringToFront();
			//send start panel to front
		}
	}
}
