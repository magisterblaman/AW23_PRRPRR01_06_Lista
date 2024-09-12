using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_06_Lista {
	internal class Program {
		static void Main(string[] args) {

			List<int> uniqueNumbers = new List<int>();

			bool run = true;

			while (run) {
				Console.Clear();
				Console.WriteLine("Mata in ett heltal!");

				string numInput = Console.ReadLine();
				int num = int.Parse(numInput);

				if (uniqueNumbers.Contains(num)) {
					int index = uniqueNumbers.IndexOf(num);
					uniqueNumbers.RemoveRange(0, index);
					
					for (int i = 0; i < uniqueNumbers.Count; i++) {
						Console.WriteLine(uniqueNumbers[i]);
					}
				} else {
					uniqueNumbers.Add(num);
				}

				Console.WriteLine("Vill du köra igen?");
				string runAgainInput = Console.ReadLine().ToLower();

				if (runAgainInput == "nej") {
					run = false;
				}
			}

		}
	}
}
