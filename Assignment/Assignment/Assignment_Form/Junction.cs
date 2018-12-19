using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Form
{
	class Junction : Station {
		private List<Line> lines = new List<Line>();
		private List<int> stationNumbers = new List<int>();
		private int noOfLinesBelonging;
		//amount of lines it belongs to
		//basically just lines.length


		//Constructors
		public Junction() { }//default

		public Junction(string name, Line line, int stationNumber, List<Line> lines, List<int> stationNumbers) : base(name, line, stationNumber) {
			this.lines = lines;
			noOfLinesBelonging = lines.Count();
			this.stationNumbers = stationNumbers;
			base.Junction = true;
		}

		//properties
		public List<Line> Lines {
			get { return lines; }
			set { this.lines = value; }
		}

		public int NoOfLinesBelonging {
			get { return this.noOfLinesBelonging; }
			set { noOfLinesBelonging = value; }
		}
	}
}
