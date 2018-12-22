using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1 {
	class TxtSegment {
		private string name, id;

		public TxtSegment(string name, string id) {
			this.name = name;
			this.id = id;
		}

		public string Name {
			get { return name; }
			set { this.name = value; }
		}

		public string ID {
			get { return id; }
			set { this.id = value; }
		}

	}
}
