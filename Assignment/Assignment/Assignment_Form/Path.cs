using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Form
{
	class Path {
		private List<Line> lines = new List<Line>();
		private List<Station> firstPath = new List<Station>();
		private List<Station> secondPath = new List<Station>();
		private List<Station> completePath = new List<Station>();

		public Path() { }//default

		public Path(Station startingStation, Station endingStation) {
			completePath = initPath(startingStation, endingStation);
		}//make path

		//properties
		public List<Station> CompletePath {
			get { return completePath; }
		}//call this to get the path

		public List<Station> FirstPath {
			get { return firstPath; }
		}

		public List<Station> SecondPath {
			get { return secondPath; }
		}

		//methods
		private List<Station> initPath(Station start, Station end) {
			if (start.LineBelong == end.LineBelong) {
				firstPath = pathToDestination(start, end);
				return pathToDestination(start, end);
			}//same line
			else {
				List<Station> returnList = new List<Station>();
				List<Station> junctions = findJuctions(start, end);
				if (junctions == null)
					return null;
				returnList.AddRange(pathToDestination(start, junctions, end));
				firstPath.AddRange(pathToDestination(start, junctions, end));
				Station junctionUsed = returnList[returnList.Count() - 1];
				returnList.AddRange(pathToDestination(junctionUsed, end));
				secondPath.AddRange(pathToDestination(junctionUsed, end));
				returnList.Add(junctionUsed);
				return returnList;
			}//different lines
		}//finds path

		private List<Station> pathToDestination(Station start, Station end) {
			int starting = start.LineBelong.Stations.IndexOf(start);
			int ending = end.LineBelong.Stations.IndexOf(end);
			List<Station> returnList = new List<Station>();
			if (starting > ending) {
				for (int count = starting; count >= ending; count--)
					returnList.Add(start.LineBelong.Stations[count]);
			}
			else {
				for (int count = starting; count <= ending; count++)
					returnList.Add(start.LineBelong.Stations[count]);
			}
			return returnList;
		}//path to destinations on the same line

		private List<Station> findJuctions(Station station1, Station station2) {
			Line line1 = station1.LineBelong;
			Line line2 = station2.LineBelong;
			//the two lines
			List<Station> returnList = new List<Station>();

			for (int count = 0; count <= line1.Stations.Count() - 1; count++) {
				for(int count1 = 0; count1 <= line2.Stations.Count() - 1; count1++) {
					if(line1.Stations[count].StationName.Equals(line2.Stations[count1].StationName))
						returnList.Add(line1.Stations[count]);
				}

			}
			//add any junctions between the two lines

			if (returnList.Count() == 0)
				return null;
			//if no junctions

			return returnList;
		}//find junctions on two lines

		private List<Station> pathToDestination(Station start, List<Station> junctions, Station end) {
			List<Station> returnList = new List<Station>();

			List<int> numberOfStops = new List<int>();
			for (int count = 0; count <= junctions.Count() - 1; count++) {
				//first section
				//before changing
				int starting = start.LineBelong.Stations.IndexOf(start);
				int ending = start.LineBelong.Stations.IndexOf(junctions[count]);

				int x = (starting > ending) ? starting : ending;
				int y = (x == starting) ? ending : starting;
				//ensure x is always larger than y

				int total = x - y;

				//second section
				//after changing
				starting = end.LineBelong.Stations.IndexOf(junctions[count]);
				ending = end.LineBelong.Stations.IndexOf(end);

			    x = (starting > ending) ? starting : ending;
				y = (x == starting) ? ending : starting;

				total += (x - y);
				numberOfStops.Add(total);
			}
			int shorterDistance = findSmallest(numberOfStops);
			Station junctionUsed = junctions[shorterDistance];
			Line firstLine = start.LineBelong;
			Line secondLine = end.LineBelong;
			returnList.AddRange(pathToDestination(start, firstLine.Stations[findIndex(firstLine, junctionUsed.StationName)]));
			returnList.AddRange(pathToDestination(secondLine.Stations[findIndex(secondLine, junctionUsed.StationName)], end));
			returnList.RemoveAt(returnList.Count() - 1);
			return returnList;
		}//find path when junctions are involved

		private int findIndex(Line line, string name) {
			for(int count = 0; count <= line.Stations.Count() - 1; count ++) {
				if (line.Stations[count].StationName.Equals(name))
					return count;
			}
			return -1;
		}

		private int findSmallest(List<int> arr) {
			int smallest = arr[0];
			for (int count = 1; count <= arr.Count() - 1; count++) {
				if (arr[count] <= smallest)
					smallest = arr[count];
			}
			return arr.IndexOf(smallest);
		}//find index of smallest int

		public List<string> removeDuplicates(List<string> input) {
			List<string> returnList = new List<string>();
			for(int count = 0; count <= input.Count - 1; count++) 
				if (!returnList.Contains(input[count])) 
					returnList.Add(input[count]);
			return returnList;
		}//remove duplicates

		public int indexOfDuplicate(List<string> input) {
			for (int count1 = 0; count1 <= input.Count() - 1; count1++) 
				for(int count2 = count1; count2 <= input.Count() - 1; count2++) 
					if (input[count1].Equals(input[count2]))
						return count2;
			return -1;
		}//find index of nearest duplicate

	}
}
