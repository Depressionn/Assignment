using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Form {
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

        public void InitLines()
        {
            const string PATH = "MRT.txt";
            string[] textLines = System.IO.File.ReadAllLines(PATH);
            Line currentLine = new Line();

            for (int i = 0; i < textLines.Length; i++)
            {

                if (textLines[i].Equals("(start)"))
                {
                    string lineId = textLines[i + 1].Substring(0, 2); //Gets Line ID from the next line
                    string lineName = getLineFromId(lineId);
                    currentLine = new Line(lineName, lineId);
                }
                else if (textLines[i].Equals("(end)"))
                {
                    lines.Add(currentLine);
                }
                else
                {
                    //name, line, stationNumber
                    currentLine.Stations.Add(new Station(textLines[i + 1], currentLine, int.Parse(textLines[i].Substring(2))));
                    i++;
                }

                for (int l = 0; l < lines.Count; l++)
                {
                    for (int m = 0; m < lines[l].Stations.Count; m++)
                    {
                        bool isJunction = false;
                        List<Line> junctionLines = new List<Line>();
                        List<int> junctionNumbers = new List<int>();
                        junctionLines.Add(lines[l]);
                        junctionNumbers.Add(lines[l].Stations[m].StationNumber);
                        for (int ln = 0; ln < lines.Count; ln++)
                        {
                            for (int mn = 0; mn < lines[ln].Stations.Count; mn++)
                            {
                                if (!lines[ln].Name.Equals(lines[l].Name) && lines[ln].Stations[mn].StationName.Equals(lines[l].Stations[m].StationName))
                                {
                                    isJunction = true;
                                    junctionLines.Add(lines[ln]);
                                    junctionNumbers.Add(lines[ln].Stations[mn].StationNumber);
                                }
                            }
                        }
                        if (isJunction)
                        {
                            Station thisStation = lines[l].Stations[m];
                            lines[l].Stations[m] = new Junction(thisStation.StationName, thisStation.LineBelong, thisStation.StationNumber, junctionLines, junctionNumbers);
                        }
                    }
                }
            }

        }//initalise objects

    }//end class

}
