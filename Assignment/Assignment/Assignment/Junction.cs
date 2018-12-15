using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment {
    class Junction : Station {
        private int noOfLinesBelonging;
        private Lines[] lines;

        public Junction() { }//default

        public Junction(string name, string description, Lines line, Lines[] lines) : base(name, description, line) {
            this.lines = lines;
            this.noOfLinesBelonging = lines.Length;
        }


    }//end class
}
