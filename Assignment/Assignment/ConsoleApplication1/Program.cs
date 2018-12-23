using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1 {
	class Program {
        [STAThread]
		static void Main(string[] args) {
			Guide testGuide = new Guide();
			testGuide.InitLines();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.Write("Enter starting station : ");
			string starting = Console.ReadLine();
			Console.Write("Enter ending station : ");
			string ending = Console.ReadLine();

			InputToStation input1 = new InputToStation(testGuide.Lines, starting);
			InputToStation input2 = new InputToStation(testGuide.Lines, ending);

			if(input1.Output == null || input2.Output == null) {
				Console.WriteLine("Enter valid inputs");
				Console.ReadKey();
				return;
			}//input validation

			Station startStation = input1.Output;
			Station endStation = input2.Output;

			//test if find path works
			Console.WriteLine("*********************************************");
			Console.WriteLine("Starting station : {0, -30}", startStation.StationName);
			Console.WriteLine("Ending station : {0, -30}", endStation.StationName);
			Console.WriteLine("*********************************************");
			Console.WriteLine("{0, -30}{1, 15}", "(Start)", "*");

			Path path = new Path(startStation, endStation);

			if (path.CompletePath == null) {
				Console.WriteLine("Wrong values");
				Console.ReadKey();
				return;
			}//error checking

			List<string> output = new List<string>();
			/*
			for (int count = 0; count <= path.CompletePath.Count() - 1; count++) {
				output.Add(path.CompletePath[count].StationName);
			}//change station objs to string list
			bool doneAlr = false;
			for(int x = 0; x <= output.Count() - 2; x++) {
				Console.WriteLine("{0, -30}{1, 15}", output[x], "*");
				if(output[x].Equals(output[output.Count() - 1]) && !doneAlr) {
					Console.WriteLine("Switch here---------------------------");
					doneAlr = true;
				}
			}
			*/
			List<string> temp = new List<string>();
			path.FirstPath.ForEach(x => temp.Add(x.StationName));
			temp = path.removeDuplicates(temp);
			temp.ForEach(x => Console.WriteLine("{0, -30}{1, 15}", x, "*"));
			temp = new List<string>();
			if(path.SecondPath.Count() != 0) {
				Console.WriteLine("Change lines here ----------------------------");
				path.SecondPath.ForEach(x => temp.Add(x.StationName));
				temp = path.removeDuplicates(temp);
				temp.ForEach(x => Console.WriteLine("{0, -30}{1, 15}", x, "*"));
			}

			Console.WriteLine("{0, -30}{1, 15}", "(End)", "*");
			Console.WriteLine("*********************************************");
			Console.WriteLine("Total number of stops : " + output.Count());

			Console.WriteLine("End of program");
			Console.ReadKey();
		}//end main

	}//Console program for testing purposes

}
