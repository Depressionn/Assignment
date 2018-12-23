using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1 {
	class Line {
		private string name, id;
		private List<double> distances = new List<double>();
		private List<Station> stations = new List<Station>();
		private List<string> stationNames = new List<string>();

		//Constructor
		public Line() { }//default

		public Line(string name, string id) {
			this.name = name;
			this.id = id;
		}

		//Properties
		public string Name {
			get { return this.name; }
			set { this.name = value; }
		}

		public string Id {
			get { return this.id; }
			set { this.id = value; }
		}

		public List<double> Distances {
			get { return this.distances; }
			set { this.distances = value; }
		}

		public List<string> StationNames {
			get { return this.stationNames; }
			set { this.stationNames = value; }
		}

		public List<Station> Stations {
			get { return this.stations; }
			set { this.stations = value; }
		}
	}
}
