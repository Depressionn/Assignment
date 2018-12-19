using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Form
{
	class InputToStation {
		private List<Line> lines = new List<Line>();
		private string input;
		private Station output;

		public InputToStation() { }//default

		public InputToStation(List<Line> lines, string input) {
			this.output = getOutput(lines, input.ToUpper());
		}
		//properties
		public Station Output {
			get { return output; }
		}//call this to get output

		//methods
		public Station getOutput(List<Line> lines, string input) {
			string combined;
			for(int lineCount = 0; lineCount <= lines.Count() - 1; lineCount++) {
				for(int stationCount = 0; stationCount <= lines[lineCount].Stations.Count() - 1; stationCount++) {
					Station currentStation = lines[lineCount].Stations[stationCount];
					combined = currentStation.LineBelong.Id + currentStation.StationNumber;
					if(input.Equals(combined) || input.Equals(currentStation.StationName.ToUpper()))
						return currentStation;
				}//end second loop
			}//end first loop
			return null;
		}//gets output

	}
}
