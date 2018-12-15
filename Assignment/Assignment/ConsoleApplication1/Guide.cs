using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1 {
	class Guide {
		private List<Line> lines = new List<Line>();

		//Constructors
		public Guide() { }//default

		//properties
		public List<Line> Lines {
			get { return this.lines; }
			set { this.lines = value; }
		}

		//methods
		public string getLineFromId(string lineId) {
			switch (lineId) {
				case "CC":
					return "Circle Line";
				case "DT":
					return "Down Town Line";
				case "EW":
					return "East West Line";
				case "NS":
					return "North South Line";
				case "NE":
					return "North East Line";
				default:
					return "Unknown"; //if unknown name
			}//end switch
		}//gets line name from id

		public void InitLines() {
			const string PATH = "C:\\Users\\tanti\\OneDrive\\Desktop\\sch stuff\\C#\\MRT.txt";
			string[] textLines = System.IO.File.ReadAllLines(PATH);
			Line currentLine = new Line();

			for (int i = 0; i < textLines.Length; i++) {

				if (textLines[i].Equals("(start)")) {
					string lineId = textLines[i + 1].Substring(0, 2); //Gets Line ID from the next line
					string lineName = getLineFromId(lineId);
					currentLine = new Line(lineName, lineId);
				}
				else if (textLines[i].Equals("(end)")) {
					lines.Add(currentLine);
				}
				else {
					  //name, line, stationNumber
					currentLine.Stations.Add(new Station(textLines[i + 1], currentLine, int.Parse(textLines[i].Substring(2))));
					i++;
				}

				//Change to juctions
				for (int lineCount = 0; lineCount < lines.Count(); lineCount++) {
					for (int stationCount = 0; stationCount < lines[lineCount].Stations.Count(); stationCount++) {
						for (int lineCount1 = 0; lineCount1 < lines.Count(); lineCount1++) {
							for (int stationCount1 = 0; stationCount1 < lines[lineCount1].Stations.Count(); stationCount1++) {
								if (lines[lineCount].Stations[stationCount].StationName.Equals(lines[lineCount1].Stations[stationCount1].StationName) && lines[lineCount] != lines[lineCount1]) {
									List<Line> serving = new List<Line>() { lines[lineCount].Stations[stationCount].LineBelong };
									serving.Add(lines[lineCount]);
									List<int> stationNumbers = new List<int>() { lines[lineCount].Stations[stationCount].StationNumber };
									stationNumbers.Add(lines[lineCount].Stations[stationCount].StationNumber);
									lines[lineCount].Stations[stationCount] = new Junction(lines[lineCount].Stations[stationCount].StationName, lines[lineCount].Stations[stationCount].LineBelong, lines[lineCount].Stations[stationCount].StationNumber, serving, stationNumbers);
								}//end if
							}//fourth loop
						}//third loop
					}//second loop
				}//first loop

			}//end main loop
		}//end init

	}//end class

}
