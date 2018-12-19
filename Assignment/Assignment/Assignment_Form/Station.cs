using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Form
{
	class Station {

		private string stationName;
		private Line lineBelong;
		private int stationNumber;
		private bool junction;

		//Default constructor
		public Station() { }

		//Main constructor to construct a new Station
		public Station(string name, Line line, int stationNumber) {
			stationName = name;
			lineBelong = line;
			this.stationNumber = stationNumber;
			this.junction = false;
		}

		//Properties
		public string StationName {
			get { return stationName; }
			set { stationName = value; }
		}

		public Line LineBelong {
			get { return lineBelong; }
			set { lineBelong = value; }
		}

		public int StationNumber {
			get { return stationNumber; }
			set { stationNumber = value; }
		}

		public bool Junction {
			get { return junction; }
			set { junction = value; }
		}
	}
}
