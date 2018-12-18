using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_1 {
	class Path {
		private List<SubPath> subPaths = new List<SubPath>();
		private List<List<Station>> possiblePaths = new List<List<Station>>();
		private List<Station> completePath = new List<Station>();

		public Path(Station start, Station end) {
			createPath(start, end);
		}

		public List<Station> CompletePath {
			get { return completePath; }
		}

		private void createPath(Station start, Station end) {
			if(!start.Junction && !end.Junction) {
				Line startLine = start.LineBelong;
				Line endLine = end.LineBelong;
				List<Station> junctions = findJunction(startLine, endLine);
				for(int count = 0; count <= junctions.Count() - 1; count++) {
					SubPath temp = new SubPath(startLine, start, junctions[count]);
					possiblePaths.Add(temp.PathTaken);
					temp = new SubPath(endLine, junctions[count], end);
					List<Station> extendedPath = combinedLists(possiblePaths[count], temp.PathTaken);
					possiblePaths[count] = extendedPath;
				}
				completePath.AddRange(possiblePaths[indexOfSmallestList(possiblePaths)]);
			}//if neither are junctions
			else if(start.Junction && end.Junction) {
				List<Line> line1 = start.getLines();
				List<Line> line2 = end.getLines();
				if (line1.Any(x => line2.Contains(x))) {    //on same line
					Line lineUsed = findCommonLine(line1, line2);
					SubPath temp = new SubPath(lineUsed, start, end);
					completePath.AddRange(temp.PathTaken);
				}else {
					List<Station> junctions = findJunctions(line1, line2);
					for(int line1Count = 0; line1Count <= line1.Count() - 1; line1Count++) {
						for(int line2Count = 0; line2Count <= line2.Count() - 1; line2Count++) {
							for (int count = 0; count <= junctions.Count() - 1; count++) {
								if (line1[line1Count].Stations.Contains(junctions[count]) && line2[line2Count].Stations.Contains(junctions[count])) {
									SubPath temp = new SubPath(line1[line1Count], start, junctions[count]);
									possiblePaths.Add(temp.PathTaken);
									temp = new SubPath(line2[line2Count], junctions[count], end);
									List<Station> extendedPath = combinedLists(possiblePaths[count], temp.PathTaken);
									possiblePaths[count] = extendedPath;
								}
							}
							completePath.AddRange(possiblePaths[indexOfSmallestList(possiblePaths)]);
						}
					}
				}
			}//if both are junctions
			else if(!start.Junction && end.Junction) {
				Line startLine = start.LineBelong;
				List<Line> endLines = end.getLines();
				List<Station> junctions = findJunctions(endLines, startLine);
				for(int count1 = 0; count1 <= endLines.Count() - 1; count1++) {
					for (int count = 0; count <= junctions.Count() - 1; count++) {
						if (endLines[count1].Stations.Contains(junctions[count]) && startLine.Stations.Contains(junctions[count])) {
							SubPath temp = new SubPath(startLine, start, junctions[count]);
							possiblePaths.Add(temp.PathTaken);
							temp = new SubPath(endLines[count1], junctions[count], end);
							List<Station> extendedPath = combinedLists(possiblePaths[count], temp.PathTaken);
							possiblePaths[count] = extendedPath;
						}
					}
					
				}
				completePath.AddRange(possiblePaths[indexOfSmallestList(possiblePaths)]);
			}//if only end is a junction
			else {
				List<Line> startLine = start.getLines();
				Line endLine = end.LineBelong;
				List<Station> junctions = findJunctions(startLine, endLine);
				for (int count1 = 0; count1 <= startLine.Count() - 1; count1++) {
					for (int count = 0; count <= junctions.Count() - 1; count++) {
						if (startLine[count1].Stations.Contains(junctions[count]) && endLine.Stations.Contains(junctions[count])) {
							SubPath temp = new SubPath(startLine[count1], start, junctions[count]);
							possiblePaths.Add(temp.PathTaken);
							temp = new SubPath(endLine, junctions[count], end);
							List<Station> extendedPath = combinedLists(possiblePaths[count], temp.PathTaken);
							possiblePaths[count] = extendedPath;
						}
					}

				}
				completePath.AddRange(possiblePaths[indexOfSmallestList(possiblePaths)]);
			}//if only start is junction
		}//create path
		
		private List<Station> findJunction(Line line1, Line line2) {
			List<Station> returnList = new List<Station>();
			for(int count = 0; count <= line1.Stations.Count() - 1; count++) {
				for(int count1 = 0; count1 <= line2.Stations.Count() - 1; count1++) {
					if(line1.Stations[count].StationName.Equals(line2.Stations[count1].StationName)) {
						returnList.Add(line1.Stations[count]);
					}
				}
			}
			return returnList;
		}//finds junctions given two lines

		private List<Station> findJunctions(List<Line> line1, Line line2) {
			List<Station> returnList = new List<Station>();
			for(int count = 0; count <= line1.Count() - 1; count++) {
				returnList.AddRange(findJunction(line1[count], line2));
			}
			return returnList;
		}//finds junctions given a listLine and a line

		private List<Station> findJunctions(List<Line> lines1, List<Line> lines2) {
			List<Station> returnList = new List<Station>();
			for(int count = 0; count <= lines1.Count() - 1; count++) {
				for(int count2 = 0; count2 <= lines2.Count() - 1; count2++) {
					returnList.AddRange(findJunction(lines1[count], lines2[count2]));
				}
			}
			return returnList;
		}//find junctions given two list lines

		private List<Station> combinedLists(List<Station> list1, List<Station> list2) {
			List<Station> returnList = new List<Station>();
			returnList.AddRange(list1);
			returnList.AddRange(list2);
			return returnList;
		}//combines two paths into one

		private int indexOfSmallestList(List<List<Station>> input) {
			int smallestLength = input[0].Count(), returnInt = 0;
			for(int count = 1; count <= input.Count() - 1; count++) {
				int lengthOfCurrent = input[count].Count();
				if(lengthOfCurrent < smallestLength) {
					smallestLength = lengthOfCurrent;
					returnInt = count;
				}
			}
			return returnInt;
		}//finds index of smallest list

		private Line findCommonLine(List<Line> line1, List<Line> line2) {
			for(int count1 = 0; count1 <= line1.Count() - 1; count1++) 
				for(int count2 = 0; count2 <= line2.Count() - 1; count2++) 
					if (line1[count1] == line2[count2])
						return line1[count1];
			return null;

		}//finds the common line given two listLines
		//first line to be found is returned

	}//end class
}
