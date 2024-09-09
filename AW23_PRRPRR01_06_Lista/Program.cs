using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_06_Lista {
	internal class Program {
		static void Main(string[] args) {

			//string[] petNames = new string[] { 
			//	"Miss Saigon",
			//	"Linus",
			//	"Findus",
			//	"Pettsson"
			//};

			List<string> petNames = new List<string>() {
				"Miss Saigon",
				"Linus",
				"Findus",
				"Pettsson"
			};

			for (int i = 0; i < petNames.Count; i++) {
				Console.WriteLine(petNames[i]);
			}
			Console.WriteLine("=======");

			petNames.Add("Ola");

			for (int i = 0; i < petNames.Count; i++) {
				Console.WriteLine(petNames[i]);
			}
			Console.WriteLine("=======");

			petNames.RemoveAt(2);

			for (int i = 0; i < petNames.Count; i++) {
				Console.WriteLine(petNames[i]);
			}

		}
	}
}
