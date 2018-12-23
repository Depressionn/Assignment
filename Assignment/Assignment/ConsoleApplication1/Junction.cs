using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1 {
	class Junction : Station {
		private List<Line> linesBelonging = new List<Line>();
		private List<int> stationNumbers = new List<int>();
		private int noOfLinesBelonging;
		//amount of lines it belongs to
		//basically just lines.length


		//Constructors
		public Junction() { }//default

		public Junction(string name) {
			base.StationName = name;
			base.Junction = true;
		}

		public Junction(string name, Line line, int stationNumber, List<Line> lines, List<int> stationNumbers) : base(name, line, stationNumber) {
			this.linesBelonging = lines;
			noOfLinesBelonging = lines.Count();
			this.stationNumbers = stationNumbers;
			base.Junction = true;
		}

		//properties
		public List<Line> LinesBelonging {
			get { return linesBelonging; }
			set { this.linesBelonging = value; }
		}

		public int NoOfLinesBelonging {
			get { return this.noOfLinesBelonging; }
			set { noOfLinesBelonging = value; }
		}

		public override void setupJunction(Line line, int stationNumber) {
			linesBelonging.Add(line);
			stationNumbers.Add(stationNumber);
		}

		public override List<Line> getLines() {
			return linesBelonging;
		}

		public override List<int> getStationNumbers() {
			return stationNumbers;
		}
	}
}
