using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gui_1 {
	class InitLines {
		private List<Line> lines = new List<Line>();

		public InitLines(string path) {
			string[] txtFile = File.ReadAllLines(path);
			createObj(txtFile);
		}

		public List<Line> Lines {
			get { return lines; }
		}//call to get lines

		private void createObj(string[] input) {
			List<TxtSegment> segments = new List<TxtSegment>();
			string currentTxt;
			for(int atLine = 0; atLine <= input.Length - 1; atLine++) {
				currentTxt = input[atLine];
				if(!currentTxt.Equals("(start)") && !currentTxt.Equals("(end)")) {
					segments.Add(new TxtSegment(input[atLine + 1], currentTxt));
					atLine++;
				}
			}//sort them into segments

			List<string> junctionNames = nameOfJunctions(segments);
			//contains the name of all the junctions
			List<Station> junctions = new List<Station>();
			junctionNames.ForEach(x => {
				Station temp = new Junction(x);
				junctions.Add(temp);
			});

			Line currentLine = new Line();
			for(int atLine = 0; atLine <= input.Length - 1; atLine++) {
				currentTxt = input[atLine];
				if (input[atLine].Equals("(start)")) {
					string lineId = input[atLine + 1].Substring(0, 2); //Gets Line ID from the next line
					string lineName = getLineFromId(lineId);
					currentLine = new Line(lineName, lineId);
				}else if (input[atLine].Equals("(end)")) {
					lines.Add(currentLine);
				}else if(junctionNames.Contains(input[atLine + 1])) {//is a junction
					currentLine.Stations.Add(junctions[findJunctionIndex(input[atLine + 1], junctionNames)]);
					Station currentStation = currentLine.Stations.Last();
					currentStation.setupJunction(currentLine, int.Parse(currentTxt.Substring(2)));
					atLine++;
 				}else {
					currentLine.Stations.Add(new Station(input[atLine + 1], currentLine, int.Parse(currentTxt.Substring(2))));
					currentLine.StationNames.Add(input[atLine + 1]);
					atLine++;
				}
			}
			
		}//creates station objects

		private List<string> nameOfJunctions(List<TxtSegment> segments) {
			List<string> returnList = new List<string>() {};
			for(int count = 0; count <= segments.Count() - 1; count++) {
				string temp = segments[count].Name;
				segments[count] = null;
				for(int count2 = count + 1; count2 <= segments.Count() - 1; count2++) {
					if(segments[count2].Name.Equals(temp) && !returnList.Contains(temp)) {
						returnList.Add(temp);
					}
				}//second loop
			}//main loop
			return returnList;
		}//find names of junctions

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

        private bool junctionAlrExists(string name) {
            bool returnBool = false;
            for(int count = 0; count <= lines.Count() - 1; count++) {
                for(int count1 = 0; count1 <= lines[count].Stations.Count() - 1; count1++) {
                    if (lines[count].Stations[count1].StationName.Equals(name)) {
                        returnBool = true;
                    }
                }
            }
            return returnBool;
        }//check if junction obj alr made

		private Station findJunctionObj(string name) {
			for(int count = 0; count <= lines.Count() - 1; count++) {
				for(int count2 = 0; count2 <= lines[count].Stations.Count() - 1; count2++) {
					if (lines[count].Stations[count2].StationName.Equals(name))
						return lines[count].Stations[count2];
				}
			}
			return null;
		}//find junction obj

		private int findJunctionIndex(string name, List<string> input) {
			for(int count = 0; count <= input.Count() - 1; count++) {
				if (input[count].Equals(name))
					return count;
			}
			return -1;
		}

	}//end class
}
