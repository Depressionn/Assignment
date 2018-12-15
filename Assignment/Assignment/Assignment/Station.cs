using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment {
    class Station {
        private string description, name;
        private Lines line;

        /* Constructors */
        public Station() { }//default

        public Station(string name, string description, Lines line) {
            this.name = name;
            this.description = description;
            this.line = line;
        }
        /* Properties */

        public string Name {
            get { return name; }
            set { name = value; }
        }//Number prop

        public string Description {
            get { return description; }
            set { description = value; }
        }//Description prop


    }//end class
}
