using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment {
    class Lines {
        private int numberOfStations;
        private Station[] stations;
        private string lineName, id;
        private double[] distances;


        public Lines() { } //default

        public Lines(int numberOfStations) {
            this.numberOfStations = numberOfStations;
            stations = new Station[numberOfStations];
        }//constructor


    }
}
