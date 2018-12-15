using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground {
    class Program {
        static void Main(string[] args) {
			List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
			List<int> ends = new List<int>() { 7, 1, 13 };
			//arr, start, end
			List<int> path = findPath(arr, 3, ends);

			if (path == null) {
				Console.WriteLine("Wrong values");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("Path is : ");
			path.ForEach(x => Console.Write(x + " "));
			Console.ReadKey();
        }//end main

		static List<int> findPath(List<int> arr, int start, List<int> end) {
			List<int> returnList = new List<int>();

			if (!arr.Contains(start)) {
				return null;
			}//if arr does not contain start

			List<int> total = new List<int>();
			for(int count = 0; count <= end.Count() - 1; count++) {
				int x = (start > end[count]) ? start : end[count];
				int y = (x == start) ? end[count] : start;
				//ensure x is always bigger than y
				total.Add(x - y);
			}

			if (start + total[findSmallest(total)] == end[findSmallest(total)]) {
				for(int count = start; count <= end[findSmallest(total)]; count++) {	//count up
					returnList.Add(count);
				}
			} else {		
				for(int count = start; count >= end[findSmallest(total)]; count--) {	//count down
					returnList.Add(count);
				}
			}

			return returnList;

		}//end find path

		static int findSmallest(List<int> arr) {
			int smallest = arr[0];
			for (int count = 1; count <= arr.Count() - 1; count++) {
				if (arr[count] < smallest)
					smallest = arr[count];
			}
			return arr.IndexOf(smallest);
		}//find index of smallest int
    }
}
