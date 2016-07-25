using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
	public class SportsCar : Car
	{
		public SportsCar() { }
		public SportsCar(string name, int maxSpd, int currSpd)
			: base(name, maxSpd, currSpd) { }
		public override void TurboBoost()
		{
			MessageBox.Show("Ramming speed!", "Faster is better...");
		}
	}
}
