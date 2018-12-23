using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1 {
	class SubPath {
		private List<Station> pathTaken = new List<Station>();
		private Line lineUsed;

		public SubPath(Line lineUsed, Station start, Station end) {
			this.lineUsed = lineUsed;
			findPath(start, end);
		}

		private void findPath(Station start, Station end) {
			int starting = lineUsed.Stations.IndexOf(start);
			int ending = lineUsed.Stations.IndexOf(end);
			if (starting > ending) {
				for (int count = starting; count >= ending; count--) {
					pathTaken.Add(lineUsed.Stations[count]);
				}
			}
			else {
				for (int count = starting; count <= ending; count++) {
					pathTaken.Add(lineUsed.Stations[count]);
				}

			}
		}

		public List<Station> PathTaken {
			get { return pathTaken; }
		}
	}
}
