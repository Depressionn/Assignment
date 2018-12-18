using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_1 {
	class InputToStation {
		private Station referencedStation;
		private List<Line> lines = new List<Line>();

		public InputToStation(string input, List<Line> lines) {
			this.lines = lines;
			this.referencedStation = findStation(input);
		}

		public Station ReferencedStation {
			get { return referencedStation; }
		}

		private Station findStation(string input) {
			input = input.ToUpper();
			for(int lineCount = 0; lineCount <= lines.Count() - 1; lineCount++) {
				for(int stationCount = 0; stationCount <= lines[lineCount].Stations.Count() - 1; stationCount++) {
					List<string> acceptable = new List<string>();

					if (lines[lineCount].Stations[stationCount].Junction) {
						List<Line> inLines = lines[lineCount].Stations[stationCount].getLines();
						List<int> stationNumbers = lines[lineCount].Stations[stationCount].getStationNumbers();
						for(int count = 0; count <= inLines.Count() - 1; count++) {
							string temp = inLines[count].Id + stationNumbers[count];
							acceptable.Add(temp);
						}
					}else {
						string temp = lines[lineCount].Stations[stationCount].LineBelong.Id + lines[lineCount].Stations[stationCount].StationNumber;
						acceptable.Add(temp);
					}

					if (lines[lineCount].Stations[stationCount].StationName.ToUpper().Equals(input) || acceptable.Contains(input.ToUpper()))
						return lines[lineCount].Stations[stationCount];
				}
			}
			return null;
		}//finds station

	}//end class
}
